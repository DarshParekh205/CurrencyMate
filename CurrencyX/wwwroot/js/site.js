// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function () {

    const fromCurrency = document.getElementById("FromCurrency");
    const toCurrency = document.getElementById("ToCurrency");
    const swapButton = document.getElementById("swapButton");

    swapButton.addEventListener("click", function () {

        const temporaryValue = fromCurrency.value;

        fromCurrency.value = toCurrency.value;
        toCurrency.value = temporaryValue;

    });

});
