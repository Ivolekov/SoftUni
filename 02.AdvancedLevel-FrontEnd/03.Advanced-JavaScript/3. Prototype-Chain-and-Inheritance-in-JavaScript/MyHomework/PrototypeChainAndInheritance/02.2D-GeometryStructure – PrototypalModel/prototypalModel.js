Object.prototype.extend = function (properties) {
    function Func() {
    }
    Func.prototype = Object.create(this);
    for (var i in properties) {
        Func.prototype[i] = properties[i];
    }
    Func.prototype._super = this;
    return new Func();
};

var shapes = (function () {
    var shape = {
        init: function init(color) {
            this._color = color;
        },
        toString: function () {
            return 'Color: ' + this._color;
        }
    };

    var circle = shape.extend({
        init: function init(x, y, radius, color) {
            this._x = x;
            this._y = y;
            this._radius = radius;
            this._super.init(color);
        },
        toString: function () {
            var result = 'Circle: ';
            result += 'O(' + this._x + ',' + this._y + '), ';
            result += 'Radius: ' + this._radius + ', ';
            result += this._super.toString();
            return result;
        }
    });

    var rectangle = shape.extend({
        init: function init(x, y, width, height, color) {
            this._x = x;
            this._y = y;
            this._width = width;
            this._height = height;
            this._super.init(color);
        },
        toString: function () {
            var result = 'Rectangle: ';
            result += 'Start point at top-left corner A(' + this._x + ',' + this._y + '), ';
            result += 'Width: ' + this._width + ', ';
            result += 'Height: ' + this._height + ', ';
            result += this._super.toString();
            return result;
        }
    });

    var triangle = shape.extend({
        init: function init(aX, aY, bX, bY, cX, cY, color) {
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            this._cX = cX;
            this._cY = cY;
            this._super.init(color);
        },
        toString: function () {
            var result = 'Triangle: ';
            result += 'A(' + this._aX + ',' + this._aY + '), ';
            result += 'B(' + this._bX + ',' + this._bY + '), ';
            result += 'C(' + this._cX + ',' + this._cY + '), ';
            result += this._super.toString();
            return result;
        }
    });

    var line = shape.extend({
        init: function init(aX, aY, bX, bY, color) {
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            this._super.init(color);
        },
        toString: function () {
            var result = 'Line: ';
            result += 'A(' + this._aX + ',' + this._aY + '), ';
            result += 'B(' + this._bX + ',' + this._bY + '), ';
            result += this._super.toString();
            return result;
        }
    });

    var segment = line.extend({
        init: function init(aX, aY, bX, bY, color) {
            this._super.init(aX, aY, bX, bY, color);
        },
        toString: function () {
            var result = 'Segment: ';
            result += 'A(' + this._aX + ',' + this._aY + '), ';
            result += 'B(' + this._bX + ',' + this._bY + '), ';
            result += this._super.toString();
            return result;
        }
    });
    return {
        circle: circle,
        rectangle: rectangle,
        triangle: triangle,
        line: line,
        segment: segment
    }
})();

var circle = Object.create(shapes.circle);
circle.init(1, 8, 45, "#879632");
console.log(circle.toString());

var rect = Object.create(shapes.rectangle);
rect.init(5, 7, 98, 78, '#000000');
console.log(rect.toString());

var triangle = Object.create(shapes.triangle);
triangle.init(3, 4, 5, 6, 6, 6, '#123456');
console.log(triangle.toString());

var line = Object.create(shapes.line);
line.init(45, 78, 99, 33, '#098900');
console.log(line.toString());

var segment = Object.create(shapes.segment);
segment.init(4, 7, 9, 3, '#099900');
console.log(segment.toString());