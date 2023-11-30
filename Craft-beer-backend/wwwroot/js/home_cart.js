let shoppingCart = JSON.parse(localStorage.getItem('shopping-cart')) || [];
const totalPriceElement = document.getElementById('total-price-span');
const cartItemsList = document.getElementById('cart-items');
const emptyCartMessage = document.getElementById('empty-cart-message');
const clearCartButton = document.getElementById('clear-cart');
const orderButton = document.getElementById('make-order');
function createInputNumber(value = 1, min = 1, max = 15, changeHandler) {
    const input = document.createElement('input');
    input.type = 'number';
    input.value = value;
    input.min = min;
    input.max = max;
    input.addEventListener('change', changeHandler);
    return input;
}

function displayCart() {
    cartItemsList.innerHTML = '';

    if (shoppingCart.length === 0) {
        emptyCartMessage.style.display = 'block';
        document.getElementById("total-price").style.display = "none";
        clearCartButton.style.display = "none";
        orderButton.style.display = "none";
    } else {
        emptyCartMessage.style.display = 'none';
        clearCartButton.style.display = "block";
        orderButton.style.display = "block";

        let total = 0;

        shoppingCart.forEach(item => {
            const listItem = document.createElement('li');
            listItem.textContent = `${item.Name} ${item.Volume} Л - Price: $${item.Price}`;
            item.Count = 1;
            const itemCountInput = createInputNumber(item.Count, 1, 15, function () {
                total -= item.Price * (item.Count || 1);
                item.Count = parseInt(this.value);
                total += item.Price * +item.Count
                totalPriceElement.textContent = `${total.toFixed(2)}`;
            });

            listItem.appendChild(itemCountInput);
            cartItemsList.appendChild(listItem);

            total += +item.Price;

        });

        document.getElementById("total-price").style.display = 'block';
        totalPriceElement.textContent = `${total.toFixed(2)}`;
    }
}


function clearShoppingCart() {
    localStorage.removeItem('shopping-cart');
    shoppingCart = [];
    displayCart();
}

function parseNumber(value) {
    return parseFloat(value.replace(',', '.'));
}

async function makeOrder() {
    shoppingCart.forEach(item => {
        item.Id = +item.Id;
        item.Volume = parseNumber(item.Volume);
        item.Price = parseNumber(item.Price);
    });
    const model = { Items: shoppingCart, TotalPrice: parseNumber(totalPriceElement.textContent) };


    const orderModelJson = JSON.stringify(model);
    const encodedOrderModelJson = encodeURIComponent(orderModelJson);
    const url = `/Order/?cartModel=${encodedOrderModelJson}`;

    window.location.href = url;
}
document.getElementById('clear-cart').addEventListener('click', clearShoppingCart);
orderButton.addEventListener('click', makeOrder);

displayCart();