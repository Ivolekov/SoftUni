var app = app || {};

app.booksController = (function () {
    function BooksController(model, viewBag) {
        this._model = model;
        this._viewBag = viewBag;
    }

    BooksController.prototype.loadAllBooks = function (selector) {
        var _this = this;

        this._model.getAllBooks()
            .then(function (successData) {
                var result = {
                    books: []
                };

                successData.forEach(function (book) {
                    result.books.push({title: book.title, bookId: book._id, author: book.author, isbn: book.isbn});
                });

                _this._viewBag.showAllBooks(selector, result);
            })
    };

    BooksController.prototype.loadAddBookPage = function (selector) {
        this._viewBag.showAddNewBook(selector)
    };

    BooksController.prototype.addNewBook = function (data) {
        var _this = this;
        this._model.addNewBook(data)
            .then(function () {
                Sammy(function () {
                    this.trigger('redirectUrl', {url: '#/books'});
                })
            })
    };

    BooksController.prototype.deleteBook = function (data) {
        var _this = this;
        this._model.deleteBook(data)
            .then(function () {
                Sammy(function () {
                    this.trigger('redirectUrl', {url: '#/books'});
                })
            })
    };
    //var makeBookDelete = function(selector) {
    //    var _this = this;
    //    $(selector).on('click', '.delete-button', function(event) {
    //        var target = $(event.target).parents('.list-row');
    //        _this._data.lib.deleteBook(target.data('id'))
    //            .then(function(data) {
    //                target.remove();
    //                $('#edit-row').empty();
    //            }, function(error) {
    //                return alert('Removing book from list fail!')
    //            })
    //    })
    //}


    return {
        load: function (model, viewBag) {
            return new BooksController(model, viewBag);
        }
    }
}());