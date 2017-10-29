var app = app || {};

app.booksModel = (function () {
    function BooksModel(requester) {
        this._requester = requester;
        this.serviceUrl = requester.baseUrl + 'appdata/' + requester.appId + '/books';
        this.deleteBook = requester.baseUrl + 'appdata/' + requester.appId + '/books/' +'bookId'
    }

    BooksModel.prototype.getAllBooks = function () {
        return this._requester.get(this.serviceUrl, true);
    };

    BooksModel.prototype.addNewBook = function(data) {
        return this._requester.post(this.serviceUrl, data, true);
    };

    BooksModel.prototype.deleteBook = function() {
        return this._requester.delete(this.deleteBook, true);
    };

    return {
        load: function (requester) {
            return new BooksModel(requester);
        }
    }
}());