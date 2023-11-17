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
  


var modal = document.getElementById("sign-in-modal");
var btn = document.getElementById("sign-in-button");
btn.onclick = function() {
  modal.style.display = "flex";
}
var regLink = document.getElementById("reg-link");
var signUpModal = document.getElementById("sign-up-modal");
regLink.onclick = function() {
    modal.style.display = "none";
    signUpModal.style.display = "flex";
}
var signInLink = document.getElementById("sign-in-link");
signInLink.onclick = function(){
    signUpModal.style.display = "none";
    modal.style.display = "flex";
}  
window.onclick = function(event){
    if (event.target == signUpModal || event.target == modal) {
        signUpModal.style.display = "none";
        modal.style.display = "none";      
    }
}