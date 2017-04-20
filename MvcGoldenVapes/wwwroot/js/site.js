function validateCard(card) {
    var re = /^(?:4[0 - 9]{12}(?:[0 - 9]{3})?|5[1 - 5][0 - 9]{14 }|6(?:011 | 5[0 - 9][0 - 9])[0 - 9]{12 }|3[47][0 - 9]{13 }|3(?:0[0 - 5] | [68][0 - 9])[0 - 9]{11 }|(?:2131 | 1800 | 35\d{3 })\d{11 })$/
    return re.test(card);
}

function validateName(name) {
    var re = /^(([A-Za-z]+[\-\']?)*([A-Za-z]+)?\s)+([A-Za-z]+[\-\']?)*([A-Za-z]+)?$/
    return re.test(name)
}

function validateExpDate(date) {
    var re = /^(0[1-9]|1[0-2])\/?([0-9]{4}|[0-9]{2})$/
    return re.test(date)
}

function validateSVC(security){
    var re = /^[0-9]{3,4}$/
    return re.test(security)
}

function validate() {

    var Name = $("#name").val();
    if (validateName(Name)) {
    }
    else {
        alert("Please enter a Valid Name");
    }

    var card = $("#card").val();
    if (validateCard(card)) {
    }
    else {
        alert("Please enter Valid Card Details");
    }

    var ExpDate = $("#ExpDate").val();
    if (validateExpDate(date)) {
    }
    else {
        alert("Please enter a Valid Expiry Date");
    }

    var security = $("#security").val();
    if (validateSVC(security)) {
    }
    else {
        alert("Please enter a Valid SVC number");
    }

    return false;
}

$("#validate").bind("click", validate);