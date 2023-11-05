document.addEventListener('DOMContentLoaded', function() {
    const minusButton = document.getElementById('minus');
    const plusButton = document.getElementById('plus');
    const valueElement = document.getElementById('value');

    let value = 0;

    function updateValue(newValue) {
        value = newValue;
        valueElement.textContent = value;
    }

    minusButton.addEventListener('click', function() {
        if (value > 0) {
            updateValue(value - 0.5);
        }
    });

    plusButton.addEventListener('click', function() {
        updateValue(value + 0.5);
    });
});
  