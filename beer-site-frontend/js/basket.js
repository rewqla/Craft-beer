function removeProduct(button) {
    // Find the parent product element
    const product = button.closest('.product');

    // Display a confirmation message when the item is removed
    if (product) {
        // Remove the product from the favorites
        product.remove();

        // Show the confirmation message
        const confirmationMessage = document.createElement('div');
        confirmationMessage.classList.add('confirmation-message');
        confirmationMessage.textContent = 'Товар видалено з кошика';
        document.body.appendChild(confirmationMessage);

        // Remove the confirmation message after a short delay
        setTimeout(() => {
            confirmationMessage.remove();
        }, 4000);
    }
}

function updateTotalPrice() {};
var plusButtons = document.querySelectorAll(".plus");
var minusButtons = document.querySelectorAll(".minus");
var litresElements = document.querySelectorAll(".litres");
var costElements = document.querySelectorAll(".cost");
var resultCostElements = document.querySelectorAll(".res-cost");

var initialCosts = Array.from(costElements).map(costElement => parseFloat(costElement.textContent));
var currentLitres = Array.from(litresElements).map(litresElement => parseFloat(litresElement.textContent));
var resultCosts = calculateResultCosts(currentLitres, initialCosts);

updateValues();

function calculateResultCosts(litresArray, costsArray) {
    return litresArray.map((litres, index) => litres * costsArray[index]);
}

function updateValues() {
    Array.from(resultCostElements).forEach((resultCostElement, index) => {
        litresElements[index].textContent = currentLitres[index].toFixed(1);
        resultCosts[index] = calculateResultCost(currentLitres[index], initialCosts[index]);
        resultCostElement.textContent = resultCosts[index].toFixed(0) + " грн";
    });
}

function calculateResultCost(litres, cost) {
    return litres * cost;
}

Array.from(plusButtons).forEach((plusButton, index) => {
    plusButton.addEventListener("click", function() {
        currentLitres[index] += 0.5;
        updateValues();
        updateFinalCost();
    });
});

Array.from(minusButtons).forEach((minusButton, index) => {
    minusButton.addEventListener("click", function() {
        if (currentLitres[index] > 0) {
            currentLitres[index] -= 0.5;
            updateValues();
        }
    });
});

function calculateTotalCost() {
    var totalCost = 0;
    Array.from(resultCostElements).forEach(resultCostElement => {
        totalCost += parseFloat(resultCostElement.textContent);
    });
    return totalCost;
}

function updateFinalCost() {
    var finalCostElement = document.getElementById("final-cost");
    if (finalCostElement) {
        finalCostElement.textContent = calculateTotalCost().toFixed(0) + " грн";
    }
}

updateFinalCost();

var continueBtn = document.querySelector(".next-step-div");
var firstBlock = document.querySelector(".first-main-container");
var secondBlock = document.querySelector(".second-main-container")
continueBtn.addEventListener("click", () => {
    firstBlock.style.display="none";
    secondBlock.style.display="flex";
});
