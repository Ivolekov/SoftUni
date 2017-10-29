function buildTable(input){
    for (var i = 1; i < input.length; i++) {

        var start = parseInt(input[0]);
        var end = parseInt(input[1]);
        console.log("<table>");
        console.log("<tr><th>Num</th><th>Square</th><th>Fib</th></tr>");
        for (var j = start; j <= end; j++) {
            function isPerfectSquare(x){
                var s = Math.sqrt(x);
                return s % 1 == 0;
            }
            function isFibonacci(n) {
                return isPerfectSquare((5*Math.pow(n,2)) + 4) || isPerfectSquare((5*Math.pow(n,2)) - 4);
            }

            console.log("<tr><td>" + j + "</td><td>"+ j*j +"</td><td>"+((isFibonacci(j))?"yes":"no") +  "</td></tr>");
        }
        console.log("</table>")
    }
}

buildTable([5, 10]);