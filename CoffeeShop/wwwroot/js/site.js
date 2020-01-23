// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var emailField = document.querySelector("email");
var signInForm = document.querySelector("signIn");

emailField.addEventListener('keyup', function (event) {
    isValidEmail = emailField.checkValidity();
});