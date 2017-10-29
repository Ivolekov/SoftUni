var app = app || {};

app.booksViews = (function () {
    function showAllBooks(selector, data) {
        $.get('templates/books.html', function (templ) {
            var rendered = Mustache.render(templ, data);
            $(selector).html(rendered);
            $('#addNewBook').on('click', function (e) {
                Sammy(function () {
                    this.trigger('redirectUrl', {url: '#/addNewBook'});
                })
            });
            $('#deleteBook').on('click', function (e) {
                $.get(bookId)
                Sammy(function () {
                    this.trigger('delete-book', {_id:bookId});
                })
            });
        })
    }

    function showAddNewBook(selector) {
        $.get('templates/addNewBook.html', function (templ) {
            $(selector).html(templ);
            $('#addNewBook').on('click', function () {
                var title = $('#title').val();
                var author = $('#author').val();
                var isbn = $('#isbn').val();
                Sammy(function () {
                    this.trigger('add-new-book', {title: title, author: author, isbn: isbn});
                });
            })
        })
    }

    return {
        load: function () {
            return {
                showAllBooks: showAllBooks,
                showAddNewBook: showAddNewBook
            }
        }
    }
}());