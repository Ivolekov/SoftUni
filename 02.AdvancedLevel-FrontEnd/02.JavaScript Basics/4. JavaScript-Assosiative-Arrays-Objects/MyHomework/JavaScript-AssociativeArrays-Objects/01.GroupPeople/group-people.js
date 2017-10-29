function Person(firstName, lastName, age){
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)
];

function groupBy(criteria) {
    function personToString(person) {
        var result = person.firstName + ' ' + person.lastName + '(age ' + person.age + ')';
        return result;
    }
    var criteriaArr = [];
    for (var i in people) {
        var tempCriteria = people[i][criteria];
        criteriaArr.push(tempCriteria);
    }
    criteriaArr = criteriaArr.reduce(function(a,b){if(a.indexOf(b)<0)a.push(b);return a;},[]);
    var resultObj = [];
    for (var k in criteriaArr) {
        var tempArr = [];
        for (var m in people) {
            if (people[m][criteria] === criteriaArr[k]) {
                tempArr.push(personToString(people[m]));
            }
        }
        var obj = {'group' : 'Group ' + criteriaArr[k], 'array' : tempArr};
        resultObj.push(obj);
    }
    for (var z in resultObj) {
        console.log(resultObj[z].group + ' : ' + resultObj[z].array);
    }
}

console.log('By First Name')
groupBy('firstName');
console.log('By Last Name')
groupBy('lastName');
console.log('By Age')
groupBy('age');