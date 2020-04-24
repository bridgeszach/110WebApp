function Car(make, model, year, color, price, mileage, mpg, image, seating, condition) {
    this.make = make;
    this.model = model;
    this.year = year;
    this.color = color;
    this.price = price;
    this.mileage = mileage;
    this.mpg = mpg;
    this.image = image;
    this.seats = seats;
    this.condition = condition;
}

function registerCar() {
    var make = $("//#endregiontxtMake").val();
    var model = $("#txtModel").val();
    var year = $("#txtYear").val();
    var color = $("#txtColor").val();
    var price = $("txtPrice").val();
    var mileage = $("txtMileage").val();
    var mpg = $("txtMPG").val();
    var image = $("txtImage").val();
    var seats = $("#txtSeats").val();
    var condition = $("#selCondition").val();

    var priceNum = 0;
    if (price) {
        priceNum = parseFloat(price);
    }

    var yearNum = 0;
    if (year) {
        yearNum = parseInt(year);
    }

    var seatsNum = 0;
    if (seats) {
        seatsNum = parseInt(seats);
    }

    var mpgNum = 0;
    if (mpg) {
        mpgNum = parseFloat(mpg);
    }

    var car = new Car(make, model, yearNum, color, priceNum, mileage, mpgNum, image, seatsNum, condition);
    console.log(car);

    $.ajax({
        url: '',
        type: 'Post',
        contentType: 'application/json',
        data: JSON.stringify(car),
        success: function (res) {
            console.log("Server responded", res);
        },
        error: function (detail) {
            console.log("Error on request", detail);
        }

    })
}

function init() {
    console.log("Register Here!");
    $('#btn-Save').click(registerCar);
}

window.onload = init;