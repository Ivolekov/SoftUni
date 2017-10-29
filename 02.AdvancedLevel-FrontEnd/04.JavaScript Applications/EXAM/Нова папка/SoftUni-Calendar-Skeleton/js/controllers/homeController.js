var app = app || {};

app.homeController = (function () {
    function HomeController(viewBag, model){
        this.viewBag = viewBag;
        this.model = model
    }

    HomeController.prototype.loadLoginMenu = function (selector) {
        this.viewBag.showLoginMenu(selector);
    };

    HomeController.prototype.loadHomeMenu = function (selector) {
        var data = {
            "username":sessionStorage['username']
        };

        this.viewBag.showHomeMenu(selector, data)
    };

    HomeController.prototype.loadWelcomeGuestPage = function (selector) {
        this.viewBag.showWelcomeGuestPage(selector);
    };

    HomeController.prototype.loadWelcomeUserPage = function (selector) {
        this.viewBag.showWelcomeUserPage(selector);
    };

    return {
        load: function (viewBag, model) {
            return new HomeController(viewBag, model)
        }
    }
})();