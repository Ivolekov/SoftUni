var app = app || {};

app.lectureModel = (function () {
    function LectureModel(requester) {
        this._requester = requester;
        this.serviceUrl = requester.baseUrl + 'appdata/' + requester.appId + '/lectures/'
    }

    LectureModel.prototype.getAllLecture = function () {
        return this._requester.get(this.serviceUrl, true)
    };

    LectureModel.prototype.getLectureByCreatorId = function(userId) {
        var requestUrl = this.serviceUrl + '?query={"_acl.creator":"'+ userId + '"}';
        return this._requester.get(requestUrl, true);
    };

    LectureModel.prototype.addLecture = function (data) {
        return this._requester.post(this.serviceUrl, data, true)
    };

    return {
        load: function (requester) {
            return new LectureModel(requester);
        }
    }

})();