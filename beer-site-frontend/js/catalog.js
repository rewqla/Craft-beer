
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

function changeHeartIcon(x){
    if (x.classList.contains("fa-regular")) {
        x.classList.remove("fa-regular");
        x.classList.remove("fa-heart");
        x.classList.add("fa-solid");
        x.classList.add("fa-heart");
    } else {
        x.classList.remove("fa-solid");
        x.classList.remove("fa-heart");
        x.classList.add("fa-regular");
        x.classList.add("fa-heart");
    }
}
var iconTrigger = document.getElementById("showAnimation");
var basketAnim = document.getElementById("basket");
iconTrigger.addEventListener("click", function() {
    basketAnim.classList.remove("pulse-animation");
    void basketAnim.offsetWidth; 
    basketAnim.classList.add("pulse-animation");
});

