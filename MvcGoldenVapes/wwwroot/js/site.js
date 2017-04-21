function checkName()
{

    var textField = document.getElementById("Name");
    var regexField = /^[a-zA-Z ]+$/;

    if (textField.value.match(RegExp(regexField)))
    {
        alert("Correct");
        return true;
    }
    else 
    {
        alert("Wrong");
        return false;
    }
}

function checkCreditCard()
{

    var textField = document.getElementById("CreditCard");
    var regexField = /(\b[4 | 5 | 6]\d{3}[\s-]?(\d{4 } [\s -]?){ 2 } \d{4 } \b)|(\b\d{4 } [\s -]?\d{6 } [\s -]?\d{5 } \b)/;

    if (textField.value.match(RegExp(regexField)))
    {
        alert("Correct");
        return true;
    }
    else 
    {
        alert("Wrong");
        return false;
    }
}

function checkExpiryDate()
{

    var textField = document.getElementById("ExpiryDate");
    var regexField = /^(0[1-9]|1[0-2])\/?([0-9]{4}|[0-9]{2})$/;

    if (textField.value.match(RegExp(regexField)))
    {
        alert("Correct");
        return true;
    }
    else 
    {
        alert("Wrong");
        return false;
    }
}

function checkSecurityCode()
{

    var textField = document.getElementById("SecurityCode");
    var regexField = /^[0-9]{3,4}$/;

    if (textField.value.match(RegExp(regexField)))
    {
        alert("Correct");
        return true;
    }
    else 
    {
        alert("Wrong");
        return false;
    }
}

function checkPaymentForm()
{
    checkName();
    checkCreditCard();
    checkExpiryDate();
    checkSecurityCode();
}