$(function () {
    'use strict';
    var APP_ID = "Basic cGVzaG86MTIzNA==";

    pageLoad();
    function pageLoad(){
        $('.divEdit').hide();
        getBooks();
    }

    function getBooks() {
        $.ajax({
            method: "GET",
            headers: {
                Authorization: APP_ID
            },
            url: "https://baas.kinvey.com/appdata/kid_ZJn5gwCm1b/books",
            success: function (data) {
                for (var i in data) {
                    var book = data[i];
                    //console.log(book.title);

                    var authorName = $('<li id="authorName">');
                    authorName.text(book.author);
                    authorName.appendTo($("#wrapper"));
                    var bookTitle = $('<ul id="bookTitle">');
                    bookTitle.text(book.title);
                    bookTitle.appendTo(authorName);
                    var isbn = $('<ul id="isbn">');
                    isbn.text(book.isbn);
                    isbn.appendTo(bookTitle);
                    //var deleteButton = $('<input type="button", id="delete" value="Delete Book">')
                    //deleteButton.appendTo('#authorName')
                    var bookId = book._id;
                    var buttonDiv =($('<button>').attr('id', 'deleteButton').text('Delete book!')
                        .click(function() {
                        deleteBook(bookId);
                    }));
                    authorName.append(buttonDiv);
                    console.log(book._id)

                }
                var form = $('<form>');
                form.appendTo($('#wrapper'));

                var titleInput = $('<input type="text" id="author" placeholder="Title"> ');
                titleInput.appendTo(form);

                var authorInput = $('<input type="text" id="title" placeholder="Author">');
                authorInput.appendTo(form);

                var isbnInput = $('<input type="text" id="isbNumber" placeholder="ISBN">');
                isbnInput.appendTo(form);

                var createBookButton = $('<input type="button" value="Create Book" id="createBook">');
                createBookButton.appendTo(form);

                var divEditButton = $('<div class="divEdit">');
                divEditButton.appendTo(form);
                var editAuthor = $('<input type="text" placeholder="Edit Author" id="editAuthor">');
                editAuthor.appendTo(divEditButton);
                var editTitleBook = $('<input type="text" placeholder="Edit Title" id="editTitleBook">');
                editTitleBook.appendTo(divEditButton);
                var editISBN = $('<input type="text" placeholder="Edit ISBN" id="editISBNumber">');
                editISBN.appendTo(divEditButton);
                var editBookButton = $('<input type="button" value="Edit Book" id="editBook">');
                editBookButton.appendTo(divEditButton);


                $('#createBook').click(createBook);
                $('#editBook').click(editBook)
            },
            error: errorMessage
        });
    }

//create a book

    function createBook() {
        var authorName = $('#author').val(),
            bookTitle = $('#title').val(),
            isbn = $('#isbNumber').val();

        $.ajax({
            method: 'POST',
            headers: {
                Authorization: APP_ID,
                "Content-Type": "application/json"
            },
            data: JSON.stringify(
                {
                    "title": bookTitle,
                    "author": authorName,
                    "isbn": isbn
                }
            ),
            url: "https://baas.kinvey.com/appdata/kid_ZJn5gwCm1b/books",
            success: function (data) {
                var author = data.author,
                    author = $('<li>');
                author.text(bookTitle);
                author.appendTo($("#wrapper"));

                var title = $('<ul id="bookTitle">');
                title.text(bookTitle);
                title.appendTo(author);

                var isbNumber = $('<ul id="isb">');
                isbNumber.text(isbn);
                isbNumber.appendTo(title);

                location.reload(true);
            },
            error: errorMessage
        })
    }

// edit a book

    function editBook(){
        var editAuthor = $('#editAuthor').val(),
            editTitle = $('#editTitleBook').val(),
            editISBN = $('#editISBNumber').val(),
            data = this.data;

        $.ajax({
            method:"PUT",
            headers:{
                Authorization: APP_ID,
                "Content-Type": "application/json"
            },
            url: "https://baas.kinvey.com/appdata/kid_ZJn5gwCm1b/books/" + data,
            data: JSON.stringify({
                "title": editTitle,
                "author": editAuthor,
                "isbn": editISBN
            }),
            success: function () {
                pageLoad()
            },
            error: function(){
                errorMessage
            }

        })

    }

    //delete book

function deleteBook(bookId) {
      $.ajax({
          headers: {
              Authorization: APP_ID
        },
        url: "https://baas.kinvey.com/appdata/kid_ZJn5gwCm1b/books/" + bookId,
        method: 'DELETE',
        contentType: 'application/json',
        success: function() {
            pageLoad()
        },
        error: errorMessage
    });
}

    function errorMessage() {
        return alert("ERROR")
    }
});