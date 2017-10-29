function extractObjects(array) {
    var object = [];

    array.forEach(function (index) {
        if (typeof index === 'object' && !Array.isArray(index)) {
            object.push(index);
        }
    });

    console.log(object)
}

var data = [
    "Pesho",
    4,
    4.21,
    { name : 'Valyo', age : 16 },
    { type : 'fish', model : 'zlatna ribka' },
    [1,2,3],
    "Gosho",
    { name : 'Penka', height: 1.65}
];
extractObjects(data);