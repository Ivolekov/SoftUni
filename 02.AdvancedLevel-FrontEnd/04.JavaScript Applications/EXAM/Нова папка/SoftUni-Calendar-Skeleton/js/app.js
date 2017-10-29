var app = app || {};

(function () {
    var router = Sammy(function () {
        var selector = '#container';
        var menuSelector = '#menu';
        var requester = app.requester.load('kid_bJD6NwEp1W', 'c964a203f35f4ef7a840942e1d37e83b',
            'https://baas.kinvey.com/');

        var userViewsBag = app.userView.load();
        var homeView = app.homeView.load();
        var lectureView = app.lectureView.load();

        var userModel = app.userModel.load(requester);
        var lectureModel = app.lectureModel.load(requester);

        var userController = app.userController.load(userViewsBag, userModel);
        var homeController = app.homeController.load(homeView);
        var lectureController = app.lectureController.load(lectureView, lectureModel);

        this.before(function() {
            var userId = sessionStorage['userId'];
            if(userId) {
                homeController.loadHomeMenu(menuSelector);
            } else {
                homeController.loadLoginMenu(menuSelector);
            }
        });

        this.before({except: {path:'#\/(register\/|login\/)?'}}, function() {
            var userId = sessionStorage['userId'];
            if(!userId) {
                noty({
                    theme: 'relax',
                    text: 'You should be logged in to do this action!',
                    type:'error',
                    timeout: 2000,
                    closeWith: ['click']
                });
                this.redirect('#/');
                return false;
            }
        });

        this.get('#/', function () {

            var userId = sessionStorage['userId'];
            if(userId) {
                homeController.loadHomeMenu(menuSelector);
                homeController.loadWelcomeUserPage(selector)
            } else {
                homeController.loadLoginMenu(menuSelector);
                homeController.loadWelcomeGuestPage(selector);
            }
        });

        this.get('#/home/', function () {
            homeController.loadWelcomeUserPage(selector)
        });

        this.get('#/login/', function () {
            userController.loadLoginPage(selector)
        });

        this.get('#/register/', function () {
            userController.loadRegisterPage(selector)
        });

        this.get('#/logout/', function () {
            userController.logout()
        });

        this.get('#/calendar/list/', function () {
            lectureController.loadAllLecture(selector)
        });

        this.get('#/calendar/my/', function () {
            lectureController.loadMyLecture(selector)
        });

        this.bind('redirectUrl', function (ev, data) {
            this.redirect(data.url);
        });

        this.bind('login', function (ev, data) {
            userController.login(data)
        });

        this.bind('register', function (ev, data) {
            userController.register(data)
        });


        this.bind('add-lecture', function (ev, data) {
            lectureController.addLecture(data)
        });
    });

    router.run('#/')
})();