var app = app || {};

(function () {
    app.router = Sammy(function () {
        var selector = '#wrapper';

        this.get('#/:name', function () {
            var name = this.params['name'];
            sayHello(selector, name);
        });
    });

    app.router.run()
}());

function sayHello(selector, name) {
    $(selector).empty();
    $('<p/>').html('<h2>Hello ' + name + '</h2>').appendTo(selector)
}