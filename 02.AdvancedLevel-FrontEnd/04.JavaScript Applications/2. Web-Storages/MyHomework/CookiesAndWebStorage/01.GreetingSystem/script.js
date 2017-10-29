(function () {
    function login(e){
        var userName =$('#logIn').val();
        localStorage.setItem('userName', userName);
    }

    if(!localStorage['countVisit']){
        localStorage.setItem('countVisit', 0);
    }

    if(!sessionStorage['countVisit']){
        sessionStorage.setItem('countVisit', 0)
    }

    localStorage['countVisit']++;
    sessionStorage['countVisit']++;

    $('<div>').text('Total visits' + localStorage['countVisit']).appendTo('body');
    $('<div>').text('Session visits' + sessionStorage['countVisit']).appendTo('body');

    if(localStorage['userName']) {
        $('#hide').hide();
        $('#greetings').text('Hello ' + localStorage['userName'])
    }
    else {
        $('#btn').on('click', login);
    }
})();