var app = app || {};

app.lectureController = (function () {
    function LectureController(viewBag, model) {
        this.model = model;
        this.viewBag = viewBag;
    }

    LectureController.prototype.loadAllLecture = function (selector) {
        var _this = this;
        this.model.getAllLecture().then(function (data) {
            var result = {
                lectures: []
            };

            data.forEach(function (lecture) {
                result.lectures.push(
                    {
                        title: lecture.title,
                        start: lecture.start,
                        end: lecture.end,
                        lecturer: lecture.lecturer,
                        id: lecture._id
                    }
                )
            });
            _this.viewBag.showAllLecture(selector, result);
        }).done()
    };

    LectureController.prototype.loadMyLecture = function (selector) {
        var _this = this;
        var userId = sessionStorage['userId'];
        this.model.getLectureByCreatorId(userId)
            .then(function (data) {
                var result = {
                    lectures: []
                };

                data.forEach(function (lecture) {
                    result.lectures.push({
                        title: lecture.title,
                        text: lecture.text,
                        start: lecture.deadline,
                        end: lecture.end,
                        lecturer: lecture.lecturer,
                        id: lecture._id
                    })
                });

                _this.viewBag.showMyLecture(selector, result);
            })
    };

    LectureController.prototype.loadAddLecture = function (selector) {
        this.viewBag.showAddLecture(selector);
    };

    LectureController.prototype.addLecture = function (data) {
        var result = {
            title:data.title,
            text:data.text,
            start:data.start,
            end:data.end,
            lecturer:sessionStorage['username']
        };
        this.model.addLecture(result)
            .then(function (success) {
                console.log(success)
            }).done()
    };

    return {
        load: function (viewBag, model) {
            return new LectureController(viewBag, model)
        }
    }

})();