function removeProduct(heartIcon) {
    // Find the parent product element
    const product = heartIcon.closest('.product');

    // Check if the heart icon is red
    const isRedHeart = heartIcon.classList.contains('fa-heart-o');

    // Toggle the heart icon color
    heartIcon.classList.toggle('fa-heart', !isRedHeart);
    heartIcon.classList.toggle('fa-heart-o', isRedHeart);

    // Display a confirmation message when the item is removed
    if (!isRedHeart) {
        // Remove the product from the favorites
        product.remove();

        // Show the confirmation message
        const confirmationMessage = document.createElement('div');
        confirmationMessage.classList.add('confirmation-message');
        confirmationMessage.textContent = 'Товар видалено з улюбленого';
        document.body.appendChild(confirmationMessage);

        // Remove the confirmation message after a short delay
        setTimeout(() => {
            confirmationMessage.remove();
        }, 4000);
    }
}
function addProduct(addButton) {
    // Знаходження батьківського елемента продукту
    const product = addButton.closest('.product');

    // Отримання деталей продукту з другого блоку
    const productName = product.querySelector('.text-lab').textContent.trim();
    const productPrice = parseFloat(product.querySelector('.cost').textContent.replace(' ГРН./Л', '').trim());
    const productQuantity = parseFloat(product.querySelector('.litres').textContent);

    // Розрахунок загальної вартості для доданої кількості
    const totalProductPrice = calculateResultCost(productQuantity, productPrice);

    // Створення нового елемента товару в кошику
    const cartItem = document.createElement('div');
    cartItem.classList.add('cart-item');
    // cartItem.innerHTML = `
    //     <p>${productName}</p>
    //     <p>${productQuantity} Л</p>
    //     <p>${totalProductPrice.toFixed(2)} ГРН.</p>
    //     <i class="fa fa-solid fa-times" onclick="removeCartItem(this)"></i>
    // `;
    
    // Додавання товару в кошик
    const cart = document.querySelector('.basket-button');
    cart.appendChild(cartItem);
    
    // Оновлення лічильника кошика (можливо, вам потрібно адаптувати це відповідно до вашої HTML-структури)
    const cartCounter = document.getElementById('cartCounter');
    const currentCartCount = parseInt(cartCounter.textContent);
    cartCounter.textContent = currentCartCount + 1;

    // Оновлення загальної вартості в головному контейнері
    updateTotalPrice();

    // Відображення повідомлення про підтвердження
    const confirmationMessage = document.createElement('div');
    confirmationMessage.classList.add('confirmation-message');
    confirmationMessage.textContent = 'Товар додано в кошик';
    document.body.appendChild(confirmationMessage);

    // Видалення повідомлення про підтвердження після короткої затримки
    setTimeout(() => {
        confirmationMessage.remove();
    }, 4000);
}

function updateTotalPrice() {
    // Розрахунок та оновлення загальної вартості в головному контейнері
    const cartItems = document.querySelectorAll('.cart-item');
    let totalPrice = 0;
    cartItems.forEach((item) => {
        const itemPrice = parseFloat(item.querySelector('p:nth-child(3)').textContent.replace(' ГРН.', '').trim());
        totalPrice += itemPrice;
    });

    // Відображення загальної вартості в визначеному елементі (можливо, вам потрібно адаптувати це відповідно до вашої HTML-структури)
    const totalPriceElement = document.querySelector('.all-price');
    totalPriceElement.textContent = `Загальна вартість: ${totalPrice.toFixed(2)} ГРН.`;
}

function removeCartItem(removeIcon) {
    // Видалення товару з кошика
    const cartItem = removeIcon.closest('.cart-item');
    cartItem.remove();

    // Оновлення лічильника кошика
    const cartCounter = document.getElementById('cartCounter');
    const currentCartCount = parseInt(cartCounter.textContent);
    cartCounter.textContent = currentCartCount - 1;

    // Оновлення загальної вартості в головному контейнері
    updateTotalPrice();
}
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