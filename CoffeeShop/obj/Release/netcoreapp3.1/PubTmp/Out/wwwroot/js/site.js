// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//var emailField = document.querySelector("email");
//var signInForm = document.querySelector("signIn");

//emailField.addEventListener('keyup', function (event) {
//    isValidEmail = emailField.checkValidity();
//});

//function called on form submit, controls whether form gets submitted
function Validate() {
    //console.log to know i am entering this function
    var confirmPassword = document.querySelector("#ConfirmPassword").value;


    if (name == confirmPassword) {
        return true;
    }
    else {
        //if no match is found return false stopping submission
        return false;
    }
}