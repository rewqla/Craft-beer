let shoppingCart = JSON.parse(localStorage.getItem('shopping-cart')) || [];

const productContainer = document.getElementById('product-container');
const basketContainer = document.getElementById('basket-container');
const emptyCart = document.getElementById('empty-cart');

function displayCart() {
    productContainer.innerHTML = '';

    console.log(shoppingCart);

    if (shoppingCart.length == 0) {
        emptyCart.style.display = 'block';
        basketContainer.style.display = "none";
    } else {
        emptyCart.style.display = 'none';
        basketContainer.style.display = "block";

        let total = 0;

        shoppingCart.forEach(item => {
            var productDiv = document.createElement("div");
            productDiv.className = "product";

            total += +item.Price;
            item.Count = 1;

            productDiv.innerHTML = `
                <img src="${item.Image}" alt="${item.Image}" style="margin-left:45px;height:100px;width:100px" class="product-img">
                <label class="text-lab">
                    ${item.Name} ${item.Volume}Л<br>
                    Світле не фільтроване
                </label>
                <label class="label-text">${item.Price} ГРН./Л <br><input type="number" class="quantity" data-index=${item.Id} value="1" min="1" max="10" style="width:174px"></label>
                <span data-index=${item.Id} class="total-price">${item.Price} ГРН.</span>
                <button class="remove-btn button-minus" data-index=${item.Id} onclick="removeProduct(this)">X</button>
            `;

            productDiv.querySelector('.quantity').addEventListener('change', (event) => {
                total -= item.Price * (item.Count || 1);
                item.Count = parseInt(event.target.value);
                total += item.Price * +item.Count

                document.querySelector(`span[data-index="${event.target.getAttribute('data-index')}"]`).textContent = (item.Price * +item.Count) + " ГРН.";
                document.getElementById("total-price").textContent = total;
            });

            productContainer.appendChild(productDiv);
        });

        var totalDiv = document.createElement("div");
        totalDiv.className = "total";

        totalDiv.innerHTML = `<div class="total" style="margin-bottom: 1rem">
            <p class="container-total">Загальна сума: <span id="total-price">${total}</span> ГРН.</p>
            <button id="clear-cart" style="background-color: #977c49;float: right;" onClick="ClearCart()" class="btn">Очистити корзину</button>
        </div>`;

        productContainer.appendChild(totalDiv);
    }
}

displayCart();

function removeProduct(button) {
    const productId = button.getAttribute('data-index');

    const index = shoppingCart.findIndex(item => item.Id == productId);

    if (index !== -1) {
        shoppingCart.splice(index, 1);

        localStorage.setItem('shopping-cart', JSON.stringify(shoppingCart));

        displayCart();
    }
}

function ClearCart() {
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
    const model = { Items: shoppingCart, TotalPrice: parseNumber(document.getElementById("total-price").textContent) };

    const orderModelJson = JSON.stringify(model);
    const encodedOrderModelJson = encodeURIComponent(orderModelJson);
    const url = `/Order/?cartModel=${encodedOrderModelJson}`;

    window.location.href = url;
}
document.getElementById("order-button").addEventListener('click', makeOrder);