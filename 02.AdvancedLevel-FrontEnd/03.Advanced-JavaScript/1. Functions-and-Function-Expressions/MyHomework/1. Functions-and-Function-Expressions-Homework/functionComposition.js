function compose(f, g){
    return function (){
        var gResult = g.apply(null, arguments);
        var result = f(gResult);
        return console.log(result);
    }
}
function add(x, y) {
    return x + y;
}
function addOne(x) {
    return x + 1;
}
function square(x) {
    return x * x;
}

compose(addOne, square)(5);
compose(addOne, add)(5, 6);
compose(Math.cos, addOne)(-1);
compose(addOne, Math.cos)(-1);
var compositeFunction = compose(Math.sqrt, Math.cos);
compositeFunction(0.5);
compositeFunction(1);
compositeFunction(-1);
