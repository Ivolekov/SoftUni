function printArgsInfo(){
    for (var i = 0; i < arguments.length; i++) {
        var obj =  arguments[i];
        if (obj instanceof Array){
            console.log(obj +'(array)');
        } else {
            console.log(obj + '('+ typeof obj + ')');
        }
       }
}

//printArgsInfo(2, 3, 2.5, -110.5564, false);

printArgsInfo(null, undefined, "", 0, [], {});
// Note that [].toString() returns ""

//printArgsInfo([1, 2], ["string", "array"], ["single value"])

//printArgsInfo("some string", [1, 2], ["string", "array"], ["mixed", 2, false, "array"], {name: "Peter", age: 20})

//printArgsInfo([[1, [2, [3, [4, 5]]]], ["string", "array"]])

console.log('\nCall() and Apply()'); // I do not understand that :(
var obj = [130, undefined, "", 0, [], {}];
printArgsInfo.apply(null, obj);
printArgsInfo.call(null, obj);

function testContext(){
    return this;
}

// Global scope
console.log(testContext());
// Inside another function
function test(){
    console.log(testContext());
}
test();
// As an object
console.log(new testContext());
