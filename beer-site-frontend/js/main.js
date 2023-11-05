
var modal = document.getElementById("sign-in-modal");
var btn = document.getElementById("sign-in-button");
btn.onclick = function() {
  modal.style.display = "flex";
}

// window.onclick = function(event) {
//   if (event.target == modal) {
//     modal.style.display = "none";
//   }
// }

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
document.addEventListener('DOMContentLoaded', function() {
    const stars = document.querySelectorAll('.star');
  
    stars.forEach(function(star) {
      star.addEventListener('click', function() {
        const rating = this.dataset.rating;
        alert('Ваш рейтинг: ' + rating);
      });
    });
  });
