// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#remove").on("click", function() {
        var tablerow = $(this).closest('tr');
        tablerow.remove();
    });
});