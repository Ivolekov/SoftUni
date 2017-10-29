var app = app || {};

app.lectureView = (function () {
    function showAllLecture(selector) {
        $.get('templates/calendar.html', function (template) {
            $(selector).html(template);
            $('#calendar').fullCalendar({
                theme: false,
                header: {
                    left: 'prev,next today addEvent',
                    center: 'title',
                    right: 'month,agendaWeek,agendaDay'
                },
                defaultDate: '2016-01-12',
                selectable: false,
                editable: false,
                eventLimit: true,
                events: null,
                customButtons: {
                    addEvent: {
                        text: 'Add Event',
                        click: function () {
                            //TODO: redirect to add event page
                        }
                    }
                },
                eventClick: function (calEvent, jsEvent, view) {
                    $.get('templates/modal.html', function (templ) {
                        var rendered = Mustache.render(templ, calEvent);
                        $('#modal-body').html(rendered);
                        $('#editLecture').on('click', function() {
                            //TODO: redirect to edit event page
                        });
                        $('#deleteLecture').on('click', function() {
                            //TODO: redirect to delete event page
                        })
                    });
                    $('#events-modal').modal();
                }
            });
        });
    }

    function showMyLecture(selector, data) {
        $.get('templates/calendar.html', function (template) {
            var rendered = Mustache.render(template, data);
            $(selector).html(rendered);

            $('#calendar').fullCalendar({
                theme: false,
                header: {
                    left: 'prev,next today addEvent',
                    center: 'title',
                    right: 'month,agendaWeek,agendaDay'
                },
                defaultDate: '2016-01-12',
                selectable: false,
                editable: false,
                eventLimit: true,
                events: null,
                customButtons: {
                    addEvent: {
                        text: 'Add Event',
                        click: function () {
                            showAddLecture(selector)
                        }
                    }
                },
                eventClick: function (calEvent, jsEvent, view) {
                    $.get('templates/modal.html', function (templ) {
                        var rendered = Mustache.render(templ, calEvent);
                        $('#modal-body').html(rendered);
                        $('#editLecture').on('click', function() {
                            //TODO: redirect to edit event page
                        });
                        $('#deleteLecture').on('click', function() {
                            //TODO: redirect to delete event page
                        })
                    });
                    $('#events-modal').modal();
                }
            });
        })
    }

    function showAddLecture(selector) {
        $.get('templates/add-lecture.html', function (templ) {
            $(selector).html(templ);
            $('#addLecture').on('click', function () {
                var title = $('#title').val(),
                    text = $('#text').val(),
                    start = $('#start').val(),
                    end = $('#end').val();

                Sammy(function () {
                    this.trigger('add-lecture', {title: title, text: text, start: start, end:end})
                })
            })
        })
    }
    //
    //function showEditLecture(selector, data) {
    //    $.get('templates/editNote.html', function (templ) {
    //        var rendered = Mustache.render(templ, data);
    //        $(selector).html(rendered);
    //        $('.edit').on('click', function () {
    //            var title = $('#title').val(),
    //                text = $('#text').val(),
    //                deadline = $('#deadline').val(),
    //                id = $(this).parent().attr('data-id');
    //            Sammy(function () {
    //                this.trigger('edit-note', {title:title, text:text, deadline:deadline, _id:id})
    //            })
    //        })
    //    })
    //}
    //
    //function showDeleteLecture(selector, data) {
    //    $.get('templates/deleteNote.html', function (templ) {
    //        var rendered = Mustache.render(templ, data);
    //        $(selector).html(rendered);
    //        $('#deleteNoteButton').on('click', function () {
    //            var id = $(this).parent().attr('data-id');
    //
    //            Sammy(function () {
    //                this.trigger('delete-note',{_id:id})
    //            })
    //        })
    //    })
    //}

    return {
        load: function () {
            return {
                showAllLecture: showAllLecture,
                showMyLecture: showMyLecture,
                showAddLecture: showAddLecture
                //showEditLecture: showEditLecture,
                //showDeleteLecture: showDeleteLecture
            }
        }
    }
})();