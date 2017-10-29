var app = app || {};

app.userView = (function () {

    function showLoginPage (selector) {
        $.get('templates/login.html', function(template) {
            $(selector).html(template);
        }).then(function() {
            $('#login-button').click(function() {
                var username = $('#username').val();
                var password = $('#password').val();

                Sammy(function() {
                    this.trigger('login', {username: username, password: password});
                });
                return false;
            })
        }).done()

    }
    function showRegisterPage(selector) {
        $.get('templates/register.html', function(template) {
            $(selector).html(template);
            $('#register-button').click(function() {
                var username = $('#username');
                var password = $('#password');
                var repeatPass = $('#confirm-password');

                if(repeatPass.val() !== password.val()) {
                    noty({
                        theme: 'relax',
                        text: 'Passwords do not match!',
                        type:'error',
                        timeout: 2000,
                        closeWith: ['click']
                    });
                    password.val('');
                    repeatPass.val('');
                } else {
                    Sammy(function() {
                        this.trigger('register', {username: username.val(), password: password.val()});
                    });
                }

                return false;
            })
        })
    }


    return {
        load: function () {
            return {
                showLoginPage: showLoginPage,
                showRegisterPage: showRegisterPage
            }
        }
    }
})();