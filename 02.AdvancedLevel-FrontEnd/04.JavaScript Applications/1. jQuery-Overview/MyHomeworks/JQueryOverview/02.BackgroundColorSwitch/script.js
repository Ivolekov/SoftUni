function pantAnElement(){
    var classInput = $('#className'),
        name = classInput.val(),
        color = $('#color').val(),
        getElement = $('.' + name);

    getElement.css('background-color', color);
    classInput.val('');
}

$('#btn').click(pantAnElement);