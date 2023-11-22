
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


function loginUser() {

    $.ajax({
        url: '/Account/Login',
        type: 'POST',
        data: { username: document.getElementById("logUsername").value, password: document.getElementById("logPassword").value, rememberMe: document.getElementById("logRememberMe").checked  },
        success: function (result) {
            if (!result.success) {
                // Користувач з таким ім'ям вже існує
                document.getElementById("loginError").innerHTML = "Wrong password or email!";

            } else {
                // Продовжуємо реєстрацію
                location.reload();
                // Викликайте інший серверний метод для завершення реєстрації
                // ...
            }
        },
        error: function () {
            console.error('Помилка при перевірці унікальності користувача.');
        }
    });
}

function registerUser() {
    var email = document.getElementById("regEmail").value;
    var username = document.getElementById("regUsername").value;
    var password = document.getElementById("regPassword").value;
    var repassword = document.getElementById("regRePassword").value;

    $.ajax({
        url: '/Account/Register',
        type: 'POST',
        data: { email: email, username: username, password: password},
        success: function (result) {
            if (!result.success) {
                // Користувач з таким ім'ям вже існує
                document.getElementById("loginError").innerHTML = "User with this email already exist!";

            } else {
                // Продовжуємо реєстрацію
                location.reload();
            }
        },
        error: function () {
            console.error('Помилка при перевірці унікальності користувача.');
        }
    });
}