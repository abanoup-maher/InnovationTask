document.addEventListener('DOMContentLoaded', function () {
    const nameInput = document.getElementById('Name');
    const nameError = document.getElementById('nameError');
    const nameErrorIcon = document.getElementById('nameErrorIcon');




    const dobInput = document.getElementById('Dateofbirth');
    const dobError = document.getElementById('dobError');
    const dobErrorIcon = document.getElementById('dobErrorIcon');




    const emailInput = document.getElementById('Email');
    const emailError = document.getElementById('emailError');
    const emailErrorIcon = document.getElementById('emailErrorIcon');



    const subjects = document.querySelectorAll('input[name="Subjects"]');
    const subjectsError = document.getElementById('subjectsError');
    const subjectsErrorIcon = document.getElementById('subjectsErrorIcon');


    /*********************************************************************************************/
    nameInput.addEventListener('input', function () {
        const nameValue = nameInput.value;
        const nameRegex = /^[a-zA-Z\s]+$/; // Only letters and spaces

        if (!nameRegex.test(nameValue)) {
            nameError.textContent = "Name contains numbers or special characters.";
            nameErrorIcon.style.display = 'inline';
        } else {
            nameError.textContent = "";
            nameErrorIcon.style.display = 'none';
        }
    });



    dobInput.addEventListener('change', function () {
        const dobValue = new Date(dobInput.value);
        const age = new Date().getFullYear() - dobValue.getFullYear();
        const monthDiff = new Date().getMonth() - dobValue.getMonth();

        if (age < 15 || (age === 15 && monthDiff < 0)) {
            dobError.textContent = "Student must be more than 15 years old.";
            dobErrorIcon.style.display = 'inline';
        } else {
            dobError.textContent = "";
            dobErrorIcon.style.display = 'none';
        }
    });



    emailInput.addEventListener('input', function () {
        const emailValue = emailInput.value;
        const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/; // Simple email regex

        if (!emailRegex.test(emailValue)) {
            emailError.textContent = "Please enter a valid email.";
            emailErrorIcon.style.display = 'inline';
        } else {
            emailError.textContent = "";
            emailErrorIcon.style.display = 'none';
        }
    });



    document.getElementById('studentForm').addEventListener('submit', function (e) {
        let subjectCount = 0;

        // Correctly get all checkboxes for the subjects
        let subjects = document.querySelectorAll('input[name="selectedsubj"]:checked');

        subjectCount = subjects.length;

        if (subjectCount > 2) {
            document.getElementById('subjectsError').textContent = "You can select up to 2 subjects only.";
            document.getElementById('subjectsErrorIcon').style.display = 'inline';
            e.preventDefault();
        } else {
            document.getElementById('subjectsError').textContent = "";
            document.getElementById('subjectsErrorIcon').style.display = 'none';
        }

        // Check if other validation errors exist
        if (document.getElementById('nameError').textContent ||
            document.getElementById('dobError').textContent ||
            document.getElementById('emailError').textContent) {
            e.preventDefault();
            alert("Please correct the errors before submitting.");
        }
    });
});

