let shoppingCart = JSON.parse(localStorage.getItem('shopping-cart')) || [];

function addToCart(Id, Name, Volume, Price, Image, Button) {

    const newItem = { Id, Name, Volume, Price, Image };

    shoppingCart.push(newItem);

    localStorage.setItem('shopping-cart', JSON.stringify(shoppingCart));

    Button.textContent = 'В корзині';
    Button.disabled = true;
}   

document.addEventListener('DOMContentLoaded', () => {
    const buttons = document.querySelectorAll('[name="craft-beer-button"]');
    buttons.forEach(button => {
        const itemId = button.getAttribute('data-id');
        if (shoppingCart.some(item => item.Id === itemId)) {
            button.textContent = 'В корзині';
            button.disabled = true;
        }
    });
});