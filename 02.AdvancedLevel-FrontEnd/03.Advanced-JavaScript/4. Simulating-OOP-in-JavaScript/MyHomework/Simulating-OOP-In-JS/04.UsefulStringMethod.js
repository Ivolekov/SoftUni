String.prototype.startsWith = function (string) {

    for (var i = 0; i < string.length; i++) {
        if (!(string[i] === this[i])) {
            return false;
        }
    }
    return true;
};

String.prototype.endsWith = function (string) {

    for (var i = 0; i < string.length; i++) {
        if ((string[string.length - i] !== this[this.length - i])) {
            return false;
        }
    }
    return true;
};

String.prototype.left = function (count) {
    count = parseInt(count);
    var result = '';
    if (count > this.length) {
        count = this.length;
    }
    for (var i = 0; i < count; i++) {
        result += this[i];

    }

    return result;
};

String.prototype.right = function (count) {
    count = parseInt(count);
    var result = '';

    if (count > this.length) {
        count = this.length;
    }

    var index = this.length - count;
    for (var i = index; i < this.length; i++) {
        result += this[i];

    }

    return result;
};

String.prototype.padLeft = function (count, character) {
    var result = "";

    if (character === undefined) {
        character = " ";
    }

    count -= this.length;

    if (count < 0) {
        count = 0;
    }

    for (var i = 0; i < count; i += 1) {
        result += character;
    }

    result += this;

    return result;
};

String.prototype.padRight = function (count, character) {
    var result = "" + this;

    if (character === undefined) {
        character = " ";
    }

    count -= this.length;

    if (count < 0) {
        count = 0;
    }

    for (var i = 0; i < count; i += 1) {
        result += character;
    }

    return result;
};

String.prototype.repeat = function (count) {
    var result = "";

    for (var i = 0; i < count; i += 1) {
        result += this;
    }

    return result;
};

var example = "This is an example string used only for demonstration purposes.";
console.log(example.startsWith("This"));
console.log(example.startsWith("this"));
console.log(example.startsWith("other"));
console.log();
var example = "This is an example string used only for demonstration purposes.";
console.log(example.endsWith("poses."));
console.log(example.endsWith ("example"));
console.log(example.startsWith("something else"));
console.log();
var example = "This is an example string used only for demonstration purposes.";
console.log(example.left(9));
console.log(example.left(90));
console.log();
var example = "This is an example string used only for demonstration purposes.";
console.log(example.right(9));
console.log(example.right(90));
console.log();
// Combinations must also work
var example = "abcdefgh";
console.log(example.left(5).right(2));
console.log();
var hello = "hello";
console.log(hello.padLeft(5));
console.log(hello.padLeft(10));
console.log(hello.padLeft(5, "."));
console.log(hello.padLeft(10, "."));
console.log(hello.padLeft(2, "."));
console.log();
var hello = "hello";
console.log(hello.padRight(5));
console.log(hello.padRight(10));
console.log(hello.padRight(5, "."));
console.log(hello.padRight(10, "."));
console.log(hello.padRight(2, "."));
console.log();
var character = "*";
console.log(character.repeat(5));
// Alternative syntax
console.log("~".repeat(3));
console.log();
// Another combination
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));
console.log();


