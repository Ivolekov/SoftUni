function add(numbers){
    var sum = numbers;

    function func(num){
        sum += num;
        return func;
    }
    func.toString = function() {return sum};
    return func;
}

// works only with '+' operator
console.log(+add(1)); // returns 1
console.log(+add(2)(3));// returns 5
console.log(+add(1)(1)(1)(1)(1)); // returns 5
console.log(+add(1)(0)(-1)(-1)); // returns -1

var addTwo = add(2);
console.log(+addTwo); // 2
console.log(+addTwo(3)); // 5
