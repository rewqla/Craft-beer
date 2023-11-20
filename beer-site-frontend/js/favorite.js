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

    // Отримання деталей продукту
    const productName = product.querySelector('.text-lab').textContent.trim();
    const productPrice = parseFloat(product.querySelector('.total-price').textContent.replace(' ГРН.', '').trim());
    const productQuantity = parseFloat(product.querySelector('.quantity').value);

    // Розрахунок загальної вартості для доданої кількості
    const totalProductPrice = productPrice * productQuantity;

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