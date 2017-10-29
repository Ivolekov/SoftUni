function quadraticErquation (a, b, c){
    var d = Math.pow(b, 2) - 4 * a * c;
    if(d<0) {
        console.log('No real roots');
        return;
    }else if(d===0) {
        var x3 = (-b) / (2 * a);
        console.log('X= ', x3);
        return;
    } else {
        var x1 = ((-b) - Math.sqrt(d)) / (2 * a);
        console.log('x1=' , x1);
        var x2 = ((-b) + Math.sqrt(d)) / (2 * a);
        console.log('x2= ', x2);

    }
}

quadraticErquation(2, 5, -3);
quadraticErquation(2, -4, 2);
quadraticErquation(4, 2, 1);