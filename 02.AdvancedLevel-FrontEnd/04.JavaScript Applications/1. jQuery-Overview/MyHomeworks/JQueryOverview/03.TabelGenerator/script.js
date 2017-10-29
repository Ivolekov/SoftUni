//var obj = [{"manufacturer": "BMW", "model": "E92 320i", "year": 2011, "price": 50000, "class": "Family"},
//    {"manufacturer": "Porsche", "model": "Panamera", "year": 2012, "price": 100000, "class": "Sport"},
//    {"manufacturer": "Peugeot", "model": "305", "year": 1978, "price": 1000, "class": "Family"}];


$(document).ready(function () {
    'use strict';

    function createJSONtable() {
        var tableContent = $('#tableContainer'),
            data = $.parseJSON($('#input').val()),
            title,
            table,
            head,
            body;

        function getTitles(data) {
            var titles = [];
            $.each(data, function (i, value) {
                var car = Object.keys(value).map(function (title) {
                    return title;
                });
                $.merge(titles, car);
            });
            return titles.filter(function (item, i) {
                return titles.indexOf(item) === i;
            })
        }

        function getTableHeader(titles) {
            var header = $('<tr>'),
                cell;

            $.each(titles, function (index, value) {
                cell = $('<th>').text(value);
                header.append(cell);
            });

            return header;
        }

       function getTableRow(titles, car) {
            var tableRow = $('<tr>'),
                cell;

            $.each(titles, function (index, title) {
                if (car[title]) {
                    cell = $('<td>').text(car[title]);
                } else {
                    cell = $('<td>').text('N/A');
                }

                tableRow.append(cell);
            });

            return tableRow;
        }

        tableContent.html('');
        title = getTitles(data);
        table = $('<table>');
        head = $('<thead>').append(getTableHeader(title));
        body = $('<tbody>');
        $.each(data, function (index, car) {
            body.append(getTableRow(title, car));
        });

        table.append(head).append(body);
        tableContent.append(table);
    }

    $('#btn').click(createJSONtable);
});