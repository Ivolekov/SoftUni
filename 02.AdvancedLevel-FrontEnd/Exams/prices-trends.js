function solve(arr){

    console.log('<table>');
    console.log('<tr><th>Price</th><th>Trend</th></tr>');
    for (var i = 0; i < arr.length; i++) {
        var num = +arr[i];
        num.toFixed(2);
        if (num === +arr[0] || num === +arr[i+1]) {
            console.log('<tr><td>' + num.toFixed(2) +'</td><td><img src=\"fixed.png\"/></td></tr>');
        } else if (num < +arr[i+1]){
            console.log('<tr><td>' + num.toFixed(2) +'</td><td><img src=\"up.png\"/></td></tr>');
        } else if(num > +arr[i+1]){
            console.log('<tr><td>' + num.toFixed(2) +'</td><td><img src=\"down.png\"/></td></tr>');
        } else {
            console.log('<tr><td>' + num.toFixed(2) +'</td><td><img src=\"down.png\"/></td></tr>');
        }
    }
    console.log('</table>');
}

solve([ '36.333', '36.5', '37.019', '35.4', '35', '35.001', '36.225' ]);