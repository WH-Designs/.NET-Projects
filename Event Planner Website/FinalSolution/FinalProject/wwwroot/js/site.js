// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#remove").on("click", function() {
        var tablerow = $(this).closest('tr');
        tablerow.remove();
    });

    $(".mb-3").mouseover(function () { 
        $(".mb-3").css("height", "100px");
    });

    $(".mb-3").mouseout(function () { 
        $(".mb-3").css("height", "80px");
    });

    $("#index-btn").mouseover(function () { 
        $("#index-btn").css({"height": "25%", "width": "25%", "font-size": "12px"});
    });

    $("#index-btn").mouseout(function () { 
        $("#index-btn").css({"height": "50%", "width": "40%", "font-size": "20px"});
    });

    $("#listing-btn").mouseover(function () { 
        $("#listing-btn").css({"height": "25%", "width": "25%", "font-size": "12px"});
    });

    $("#listing-btn").mouseout(function () { 
        $("#listing-btn").css({"height": "50%", "width": "40%", "font-size": "20px"});
    });
});