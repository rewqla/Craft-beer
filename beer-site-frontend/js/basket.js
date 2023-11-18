document.addEventListener('DOMContentLoaded', function() {
    const checkboxes = document.querySelectorAll('.checkbox');
    const quantities = document.querySelectorAll('.quantity');
    const totalAmountSpan = document.getElementById('totalAmount');

    checkboxes.forEach(function(checkbox, index) {
        checkbox.addEventListener('change', function() {
            updateTotalAmount();
        });

        quantities[index].addEventListener('input', function() {
            if (parseFloat(quantities[index].value) < 0) {
                alert("Кількість не може бути від'ємною.");
                quantities[index].value = 0;
            }
            updateTotalAmount();
        });
    });

    function updateTotalAmount() {
        let totalAmount = 0;

        checkboxes.forEach(function(checkbox, index) {
            if (checkbox.checked) {
                const price = parseFloat(checkbox.getAttribute('data-price'));
                const quantity = parseFloat(quantities[index].value);

                if (quantity < 0) {
                    alert("Кількість не може бути від'ємною.");
                    quantities[index].value = 0;
                }

                const totalPrice = price * quantity;
                totalAmount += totalPrice;

                // Оновлення відображення загальної вартості товару
                const productDiv = checkbox.closest('.product');
                const totalPriceSpan = productDiv.querySelector('.total-price');
                totalPriceSpan.textContent = `${totalPrice.toFixed(2)}ГРН.`;
            }
        });

        totalAmountSpan.textContent = totalAmount.toFixed(2);
    }
});

function removeProduct(button) {
    const productDiv = button.parentElement;
    const checkbox = productDiv.querySelector('.checkbox');
    checkbox.checked = false;

    updateTotalAmount();
}
