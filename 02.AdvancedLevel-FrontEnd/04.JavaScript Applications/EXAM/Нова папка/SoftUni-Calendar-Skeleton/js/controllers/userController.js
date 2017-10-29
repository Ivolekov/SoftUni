var app = app || {};

app.userController = (function () {
    function UserController(viewBag, model) {
        this.viewBag = viewBag;
        this.model = model
    }

    UserController.prototype.loadLoginPage = function (selector) {
        this.viewBag.showLoginPage(selector)
    };

    UserController.prototype.login = function (data) {
        return this.model.login(data).then(function (success) {
            sessionStorage['sessionId'] = success._kmd.authtoken;
            sessionStorage['username'] = success.username;
            sessionStorage['userId'] = success._id;
            noty({
                theme: 'relax',
                text: 'Successfully login!',
                type:'success',
                timeout: 2000,
                closeWith: ['click']
            });
            Sammy(function() {
                this.trigger('redirectUrl', {url: '#/home/'});
            });
        }).done()
    };

    UserController.prototype.loadRegisterPage = function (selector) {
        this.viewBag.showRegisterPage(selector)
    };

    UserController.prototype.register = function (data) {
        return this.model.register(data).then(function (success) {
            sessionStorage['sessionId'] = success._kmd.authtoken;
            sessionStorage['username'] = success.username;
            sessionStorage['userId'] = success._id;
            noty({
                theme: 'relax',
                text: 'Successfully registered!',
                type:'success',
                timeout: 2000,
                closeWith: ['click']
            });
            Sammy(function() {
                this.trigger('redirectUrl', {url: '#/home/'});
            });
        }).done()
    };

    UserController.prototype.logout = function () {
        return this.model.logout().then(function () {
            sessionStorage.clear();
            noty({
                theme: 'relax',
                text: 'Successfully logged out!',
                type:'success',
                timeout: 2000,
                closeWith: ['click']
            });
            Sammy(function () {
                this.trigger('redirectUrl', {url: '#/'})
            })
        })
    };

    return{
        load: function (viewBag, model) {
            return new UserController(viewBag, model)
        }
    }

})();