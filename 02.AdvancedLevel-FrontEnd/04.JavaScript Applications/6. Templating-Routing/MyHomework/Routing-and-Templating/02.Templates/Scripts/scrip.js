'use strict';
var APP_ID = "Basic cGVzaG86MTIzNA==";

$('#btn').on('click', function () {
    var name = $('#name').val(),
        jobTitle = $('#job').val(),
        website = $('#web-site').val();

    $.ajax({
        method: "POST",
        url: "https://baas.kinvey.com/appdata/kid_ZJn5gwCm1b/persons",
        headers: {
            Authorization: APP_ID
        },
        data:{
            "name":name,
            "job title":jobTitle,
            "website":website
        },
        success: function () {
            location.reload(true)
        },
        error: function (er) {
            console.log(er)
        }
    });
});

$.get('template.html', function (template) {
    var json = {};
    $.ajax({
        method: "GET",
        url: "https://baas.kinvey.com/appdata/kid_ZJn5gwCm1b/persons",
        headers: {
            Authorization: APP_ID
        },
        success: function (data) {
            json['person'] = data;
            showCollection(json);
        },
        error: function (er) {
            console.log(er)
        }
    });


    function showCollection(obj) {
        var outp = Mustache.render(template, obj);
        $('#table').html(outp);
    }
});