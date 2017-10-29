var app = app || {};

(function() {
    var router = Sammy(function () {
        var selector = '#container';

        var requester = app.requester.config('kid_ZJn5gwCm1b','bec3c56e41be4df6b41ba05ad616789f');

        var userViewBag = app.userViews.load();
        var booksViewBag =app.booksViews.load();

        var userModel = app.userModel.load(requester);
        var booksModel = app.booksModel.load(requester);

        var userController = app.userController.load(userModel, userViewBag);
        var booksController = app.booksController.load(booksModel, booksViewBag);

        this.get('#/', function() {
            this.redirect('#/welcome');
        });

        this.get('#/welcome', function() {
            userController.showWelcomePage(selector);
        });

        this.get('#/login', function() {
            userController.showLoginPage(selector);
        });

        this.get('#/logout', function() {
            userController.logout();
        });

        this.get('#/register', function() {
            userController.showRegisterPage(selector);
        });

        this.get('#/books', function() {
            booksController.loadAllBooks(selector);
        });

        this.get('#/addNewBook', function() {
            booksController.loadAddBookPage(selector);
        });

        this.bind('redirectUrl', function(e, data) {
            this.redirect(data.url);
        });

        this.bind('login', function(e, data) {
            userController.login(data);
        });

        this.bind('register', function(e, data) {
            userController.register(data);
        });

        this.bind('add-new-book', function(e, data) {
            booksController.addNewBook(data);
        });

        this.bind('delete-book', function(e, data) {
            booksController.deleteBook(data);
        });
    });

    router.run('#/');
}());