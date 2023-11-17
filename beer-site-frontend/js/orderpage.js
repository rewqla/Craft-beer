
var select = document.querySelector(".form-select");
var addUserWindow = document.getElementById("addNewUserSpan");
var selectSpan = document.querySelector("#select-input");

select.addEventListener("click", () => {
    if(document.querySelector("#add-new-user").selected){
        addUserWindow.style.display = "flex";
        selectSpan.style.display = "none";
        
    }
});
var safeNewCustBtn = document.querySelector(".save-new-custumer-btn");
safeNewCustBtn.addEventListener("click", ()=> {
        var inputElements = document.querySelectorAll('.input-new-customer');
        var allInputsFilled = Array.from(inputElements).every(function(input) {
            return input.value.trim() !== '';
        });
        if (allInputsFilled) {
            var newUserOption = document.createElement("option");
            newUserOption.value = "newUser";
            newUserOption.text = "Новий користувач";
    
            select.insertBefore(newUserOption, select.lastChild);
            select.value = "newUser";
    
            addUserWindow.style.display = "none";
            selectSpan.style.display = "flex";
        } else {
            alert("Будь ласка, заповніть всі поля.");
        }
})

// обчислення ціни і функція +-
var plusButtons = document.querySelectorAll(".plus");
var minusButtons = document.querySelectorAll(".minus");
var litresElements = document.querySelectorAll(".litres");
var costElements = document.querySelectorAll(".cost");
var resultCostElements = document.querySelectorAll(".res-cost");

var initialCosts = Array.from(costElements).map(costElement => parseFloat(costElement.textContent));
var currentLitres = Array.from(litresElements).map(litresElement => parseFloat(litresElement.textContent));
var resultCosts = calculateResultCosts(currentLitres, initialCosts);

updateValues();

function calculateResultCosts(litresArray, costsArray) {
    return litresArray.map((litres, index) => litres * costsArray[index]);
}

function updateValues() {
    Array.from(resultCostElements).forEach((resultCostElement, index) => {
        litresElements[index].textContent = currentLitres[index].toFixed(1);
        resultCosts[index] = calculateResultCost(currentLitres[index], initialCosts[index]);
        resultCostElement.textContent = resultCosts[index].toFixed(0) + " грн";
    });
}

function calculateResultCost(litres, cost) {
    return litres * cost;
}

Array.from(plusButtons).forEach((plusButton, index) => {
    plusButton.addEventListener("click", function() {
        currentLitres[index] += 0.5;
        updateValues();
        updateFinalCost();
    });
});

Array.from(minusButtons).forEach((minusButton, index) => {
    minusButton.addEventListener("click", function() {
        if (currentLitres[index] > 0) {
            currentLitres[index] -= 0.5;
            updateValues();
        }
    });
});

function calculateTotalCost() {
    var totalCost = 0;
    Array.from(resultCostElements).forEach(resultCostElement => {
        totalCost += parseFloat(resultCostElement.textContent);
    });
    return totalCost;
}

function updateFinalCost() {
    var finalCostElement = document.getElementById("final-cost");
    if (finalCostElement) {
        finalCostElement.textContent = calculateTotalCost().toFixed(0) + " грн";
    }
}

updateFinalCost();

var continueBtn = document.querySelector(".next-step-div");
var firstBlock = document.querySelector(".first-main-container");
var secondBlock = document.querySelector(".second-main-container")
continueBtn.addEventListener("click", () => {
    firstBlock.style.display="none";
    secondBlock.style.display="flex";
});




////////////////////////////////////////
const courierRadio = document.getElementById('courier');
const delCompany = document.querySelector('.del-company');
const selfDel = document.querySelector("#self-delivery");
courierRadio.addEventListener('change', function () {
    if (courierRadio.checked) {
        delCompany.style.display = 'flex';
    } else {
        delCompany.style.display = 'none';
    }
});
selfDel.addEventListener('change', function () {
    if(selfDel.checked){
        delCompany.style.display = 'none';
        courierRadio.nextElementSibling.textContent = `Кур’єром`;

    }
});
const delCompanies = document.querySelectorAll('.del-company div');
delCompanies.forEach(company => {
    company.addEventListener('click', function (event) {
        const selectedCompany = event.currentTarget;
        if (selectedCompany) {
            const companyName = selectedCompany.dataset.company;
            courierRadio.nextElementSibling.textContent = `Кур’єром (${companyName})`;
        }
        delCompany.style.display = 'none';
    });
});

var naclad = document.querySelector("#naclad");
var payByCard = document.querySelector("#payByCard");
var cardForm = document.querySelector(".bank-card");

payByCard.addEventListener('change', function () {
    if(payByCard.checked){
        cardForm.style.display = 'flex';
    }
});
naclad.addEventListener('change', function () {
    if(naclad.checked){
        cardForm.style.display = 'none';
    }
});


// умови для інпута карти
var title = document.querySelector("#title");
var orderButton = document.querySelector('.order-btn');
var lastWindow = document.querySelector("#end");
document.addEventListener('DOMContentLoaded', function () {
    const cardNumberInput = document.querySelector('.bank-card #card-num input');
    const expiryDateInput = document.querySelector('.bank-card span input[placeholder="ММ/РР"]');
    const cvvInput = document.querySelector('.bank-card span input[placeholder="123"]');
    const payByCardRadio = document.getElementById('payByCard');

    orderButton.addEventListener('click', function () {
        // Перевіряємо, чи вибрана опція "Онлайн-оплата банківською картою"
        if (payByCardRadio.checked) {
            validateCardNumber();
            validateExpiryDate();
            validateCVV();
        }
    });

    function validateCardNumber() {
        const cardNumber = cardNumberInput.value.replace(/\s/g, ''); // видаляємо пробіли
        const cardNumberRegex = /^\d{16}$/;

        if (!cardNumberRegex.test(cardNumber)) {
            alert('Номер карти має містити рівно 16 цифр');
        }
    }

    function validateExpiryDate() {
        const expiryDateRegex = /^(0[1-9]|1[0-2])\/\d{2}$/;

        if (!expiryDateRegex.test(expiryDateInput.value)) {
            alert('Неправильний формат терміну дії карти. Використовуйте ММ/РР формат.');
        }
    }

    function validateCVV() {
        const cvvRegex = /^\d{3}$/;

        if (!cvvRegex.test(cvvInput.value)) {
            alert('CVV має містити рівно 3 цифри');
        }
    }
});


orderButton.addEventListener('click', function () {
    title.style.display='none';
    secondBlock.style.display='none';
    lastWindow.style.display='flex';
});