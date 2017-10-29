$(function () {
    var APP_ID = "Basic SXZvOjE=";

    getCountries();

    function getCountries() {
        $.ajax({
            method: 'GET',
            headers: {
                "Authorization": APP_ID
            },
            url: 'https://baas.kinvey.com/appdata/kid_W17j_ecyy-/Country',
            success: function (data) {
                attachCountryEvents(data);
                attachTownEvents(data);
                showInHTML(data, '#country', 'Country');
            },
            error: errorMessage
        });
    }

    function attachCountryEvents(data) {
        addClassObject('country', data);
        editClassObject('country', data);
    }

    function attachTownEvents(data) {
        addClassObject('town', data);
        editClassObject('town', data);
    }

    function getTowns(countryId, countryName) {
        jQuery.ajax({
            url: 'https://baas.kinvey.com/appdata/kid_W17j_ecyy-/Town?query={"country":{"_type":"KinveyRef","_id":"' +
            ''+countryId+'","_collection":"Country"}}',
            type: 'GET',
            headers: {
                "Authorization": APP_ID
            },
            success: function (data) {
                showInHTML(data, '#town', 'Town', countryName, countryId);
            },
            error: errorMessage
        });
    }

    function showInHTML(data, panel, className, countryName, countryId) {
        var list = $('<ul>').attr('class', 'list');
        $(panel).empty();
        if (className === 'Town') {
            $('#wrapperTown').css('display', 'block');
            $(panel).empty();
            if (data.length === 0) {
                $('<h2>').text(countryName + ' have not towns yet...')
                    .data('countryName', countryName)
                    .data('townData', data)
                    .prependTo($(panel));
            } else {
                data.forEach(function (item) {
                    var town = $('<li>').attr('class', 'names').text(item.name + ' ')
                        .append($('<a href="#">')
                            .text('[Remove]')
                            .data('countryId', countryId)
                            .data('countryName', countryName)
                            .click(function () {
                                removeTown(countryId, countryName, item._id);
                            }));
                    town.appendTo(list);
                });
                list.prependTo($(panel));
                $('<h2>').text('Towns of ' + countryName).data('countryName', countryName).data('townData', data).prependTo($(panel));
            }
        } else {
            data.forEach(function (item) {
                var country = $('<li>').attr('class', 'names').text(item.name + ' ')
                    .append($('<a href="#">')
                        .text('[Remove]')
                        .data('countryId', item._id)
                        .click(function () {
                            removeCountry(item._id, item.name);
                        }))
                    .append(' / ')
                    .append($('<a href="#">')
                        .text('[Show towns]')
                        .data('countryId', item._id)
                        .data('countryName', item.name)
                        .click(function () {
                            getTowns(item._id, item.name);
                        }));
                country.appendTo(list);
            });
            list.prependTo($(panel));
            $('<h2>').text('Countries panel').prependTo($(panel));
        }
    }

    function addCountry(name, data) {
        console.log(name);
        var counter = 0;

        data.forEach(function (elem) {
            if (name === elem.name) {
                counter++;
            }
        });

        if (counter == 0) {
            jQuery.ajax({
                headers: {
                    "Authorization": APP_ID
                },
                url: 'https://baas.kinvey.com/appdata/kid_W17j_ecyy-/Country',
                method: 'POST',
                data: JSON.stringify({
                    "name": name
                }),
                contentType: "application/json",
                success: function () {
                    location.reload(true);
                },
                error: errorMessage
            });
        } else {
            return alert('Country with this name already exist');
        }

    }

    function removeCountry(countryId) {
        jQuery.ajax({
            url: 'https://baas.kinvey.com/appdata/kid_W17j_ecyy-/Country/' + countryId,
            type: 'DELETE',
            headers: {
                "Authorization": APP_ID
            },
            success: function () {
                location.reload(true);
            },
            error: errorMessage
        });

    }

    function editCountry(currentName, newName, data) {
        var countryId;

        data.forEach(function (elem) {
            if (elem.name === currentName) {
                countryId = elem._id;
            }
        });

        if (!countryId) {
            return alert('This country is not exist');
        } else {
            jQuery.ajax({
                headers: {
                    "Authorization": APP_ID
                },
                url: 'https://baas.kinvey.com/appdata/kid_W17j_ecyy-/Country/' + countryId,
                type: 'PUT',
                contentType: "application/json",
                data: JSON.stringify({
                    'name': newName
                }),
                success: function () {
                    location.reload(true);
                },
                error: errorMessage
            });
        }
    }

    function addTown(name, data) {
        var townData = $('#wrapperTown').find('h2').data('townData');
        var counter = 0;

        townData.forEach(function (elem) {
            if (name === elem.name) {
                counter++;
            }
        });

        if (counter === 0) {
            var countryName = $('#wrapperTown h2').data('countryName');
            var countryId;
            data.forEach(function (elem) {
                if (elem.name === countryName) {
                    countryId = elem._id
                }
            });

            jQuery.ajax({
                headers: {
                    "Authorization": APP_ID
                },
                url: 'https://baas.kinvey.com/appdata/kid_W17j_ecyy-/Town',
                method: 'POST',
                data: JSON.stringify({
                    "country": {
                        "_type": "KinveyRef",
                        "_id": countryId,
                        "_collection": "Country"
                    },
                    "name": name
                }),
                contentType: "application/json",
                success: function () {
                    getTowns(countryId, countryName)
                },
                error: errorMessage
            });
        } else {
            return alert('Town with this name already exist');
        }
    }

    function removeTown(countryId, countryName, townId) {
        jQuery.ajax({
            url: 'https://baas.kinvey.com/appdata/kid_W17j_ecyy-/Town/' + townId,
            type: 'DELETE',
            headers: {
                "Authorization": APP_ID
            },
            success: function () {
                getTowns(countryId, countryName)
            },
            error: errorMessage
        });
    }

    function editTown(currentName, newName, countryData) {
        var townData = $('#wrapperTown h2').data('townData');
        var countryName = $('#wrapperTown h2').data('countryName');
        var countryId;

        countryData.forEach(function (elem) {
            if (elem.name === countryName) {
                countryId = elem._id
            }
        });

        var townId;
        townData.forEach(function (elem) {
            if (elem.name === currentName) {
                townId = elem._id
            }
        });

        jQuery.ajax({
            headers: {
                "Authorization": APP_ID
            },
            url: 'https://baas.kinvey.com/appdata/kid_W17j_ecyy-/Town/' + townId,
            type: 'PUT',
            contentType: "application/json",
            data: JSON.stringify({
                "name": newName
            }),
            success: function () {
                getTowns(countryId, countryName)
            },
            error: errorMessage
        });
    }

    function addClassObject(kind, data) {
        var addButton = $(('#' + kind + 'AddButton'));
        addButton.on('click', function (event) {
            event.preventDefault();
            var name = $('#' + kind + 'AddName').val();
            if (!name) {
                return alert('The name should be non-empty string.');
                event.stopPropagation();
            }
            ;
            switch (kind) {
                case 'country':
                    addCountry(name, data);
                    event.stopPropagation();
                    break;
                case 'town':
                    addTown(name, data);
                    event.stopPropagation();
                    break;
            }
            event.stopPropagation();
        });
    }

    function editClassObject(kind, data) {
        var editButton = $('#' + kind + 'NameEditButton');
        editButton.on('click', function (event) {
            event.preventDefault();
            var currentName = $('#' + kind + 'CurrentName').val();
            var newName = $('#' + kind + 'NewName').val();
            if (!currentName || !newName) {
                return alert('The name should be non-empty string.');
            }
            ;
            switch (kind) {
                case 'country':
                    editCountry(currentName, newName, data);
                    break;
                case 'town':
                    editTown(currentName, newName, data);
                    break;
            }
            event.stopPropagation();
        })
    }

    function errorMessage() {
        return alert('Cannot load data.');
    }
});