function findYoungestPerson(array) {
    var age = Number.POSITIVE_INFINITY;
    var personName;

    array.forEach(function(x){
        if (x["hasSmartphone"] && x["age"] < age){
            age = x["age"];
            personName = x["firstname"] +" " +  x["lastname"];
        }
    })

    console.log("The youngest person is " + personName);
}

var people = [
    { firstname : 'George', lastname: 'Kolev', age: 32, hasSmartphone: false },
    { firstname : 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true },
    { firstname : 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true },
    { firstname : 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false }];


findYoungestPerson(people);