Object.prototype.extends = function (parant) {
    this.prototype = Object.create(parant.prototype);
    this.prototype.constructor = this;
};

var shape = (function () {
    function Shape(color) {
        this._color = color;
    }

    Shape.prototype.toString = function () {
        return 'Color: ' + this._color;
    };

    var Circle = (function () {
        function Circle(x, y, radius, color) {
            this._x = x;
            this._y = y;
            this._radius = radius;
            Shape.call(this, color);
        }

        return Circle;
    })();

    Circle.prototype = Object.create(Shape.prototype);
    Circle.prototype.constructor = Circle;
    Circle.prototype.toString = function () {
        var result = 'Circle: ';
        result += 'O(' + this._x + ',' + this._y + '), ';
        result += 'Radius: ' + this._radius + ', ';
        result += Shape.prototype.toString.call(this);
        return result;
    };

    var Rectangle = (function () {
        function Rectangle(x, y, width, height, color) {
            this._x = x;
            this._y = y;
            this._width = width;
            this._height = height;
            Shape.call(this, color);
        }

        return Rectangle;
    })();

    Rectangle.prototype = Object.create(Shape.prototype);
    Rectangle.prototype.constructor = Rectangle;
    Rectangle.prototype.toString = function () {
        var result = 'Rectangle: ';
        result += 'Start point at top-left corner A(' + this._x + ',' + this._y + '), ';
        result += 'Width: ' + this._width + ', ';
        result += 'Height: ' + this._height + ', ';
        result += Shape.prototype.toString.call(this);
        return result;
    };

    var Triangle = (function () {
        function Triangle(aX,aY, bX, bY, cX, cY, color){
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            this._cX = cX;
            this._cY = cY;
            Shape.call(this, color);
        }
        return Triangle;
    })();
    Triangle.prototype = Object.create(Shape.prototype);
    Triangle.prototype.constructor = Triangle;
    Triangle.prototype.toString = function(){
        var result = 'Triangle: ';
        result += 'A(' + this._aX + ',' + this._aY + '), ';
        result += 'B(' + this._bX + ',' + this._bY + '), ';
        result += 'C(' + this._cX + ',' + this._cY + '), ';
        result += Shape.prototype.toString.call(this);
        return result;
    };

    var Line = (function (){
        function Line(aX, aY, bX, bY, color){
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            Shape.call(this, color);
        }
        return Line;
    })();
    Line.prototype = Object.create(Shape.prototype);
    Line.prototype.constructor = Line;
    Line.prototype.toString = function(){
        var result = 'Line: ';
        result += 'A(' + this._aX + ',' + this._aY + '), ';
        result += 'B(' + this._bX + ',' + this._bY + '), ';
        result += Shape.prototype.toString.call(this);
        return result;
    };

    var Segment = (function (){
        function Segment(aX, aY, bX, bY, color){
            Line.call(this, aX,aY, bX, bY, color);
        }
        return Segment;
    })();
    Segment.prototype = Object.create(Shape.prototype);
    Segment.prototype.constructor = Segment;
    Segment.prototype.toString = function(){
        var result = 'Segment: ';
        result += 'A(' + this._aX + ',' + this._aY + '), ';
        result += 'B(' + this._bX + ',' + this._bY + '), ';
        result += Shape.prototype.toString.call(this);
        return result;
    };

    return {
        Circle: Circle,
        Rectangle: Rectangle,
        Triangle: Triangle,
        Line: Line,
        Segment: Segment
    }
})();


var circle = new shape.Circle(0, 5, 20, "#527896");
console.log(circle.toString());

var rect = new shape.Rectangle(5, 8, 50, 40, '#568978');
console.log(rect.toString());

var triangle = new shape.Triangle(8, 6, 89, 1, 9, 45, '#658741');
console.log(triangle.toString());

var line = new shape.Line(59, 47, 12, 6, '#872354');
console.log(line.toString());

var Segment = new shape.Segment(79, 9, 2, 6, '#256454');
console.log(Segment.toString());
