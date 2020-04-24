function retrieveCatalog() {
    // url: /catalog/getCatalog

    $.ajax({
        url: "/catalog/getCatalog",
        type: "GET",
        success: res => {
            console.warn("from server", res);
            //display cars on the HTML
            for (let i = 0; i < res.length; i++) {
                displayCar(res[i]);
            }
        },
        error: function (detail) {
            console.error(detail);
        }
    });
}

function displayCar(car) {
    // get container
    var container = $("#catalog");

    // create template/syntax
    var sntx =
        `<div>
        <h3>Year Make Model</h3>
        image here
    </div>`;

    // add template to container
    container.append(sntx);
}

function init() {
    // get data
    retrieveCatalog();
    //hooks events
}

window.onload = init;