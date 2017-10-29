var app = app || {};

app.homeView = (function () {
    function showLoginMenu(selector) {
        $.get('templates/menu-login.html', function (templ) {
            $(selector).html(templ);
        })
    }

    function showHomeMenu(selector, data) {
        $.get('templates/menu-home.html', function (template) {
            $(selector).html(template);
        })
    }

    function showWelcomeGuestPage(selector){
        $.get('templates/welcome-guest.html', function (templ) {
            $(selector).html(templ);

        })
    }

    function showWelcomeUserPage(selector, data){
        $.get('templates/welcome-user.html', function (template) {
            var rendered = Mustache.render(template, data);
            $(selector).html(rendered);

        })
    }


    return {
        load: function () {
            return {
                showLoginMenu: showLoginMenu,
                showHomeMenu: showHomeMenu,
                showWelcomeGuestPage: showWelcomeGuestPage,
                showWelcomeUserPage: showWelcomeUserPage
            }
        }
    }
})();