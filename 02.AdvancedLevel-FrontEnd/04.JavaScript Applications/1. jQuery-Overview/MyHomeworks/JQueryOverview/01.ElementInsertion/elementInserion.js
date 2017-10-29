var beforeElement = $('<li>').text('123').addClass('before'),
    afterElement = $('<li>').text('!@#').addClass('after');

$('#element').before(beforeElement).after(afterElement);
