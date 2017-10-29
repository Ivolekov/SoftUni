function solve(input){
    var start = 0;
    var end = 0;
    var numArray =[];
    for (var i = 0; i < input.length; i++) {
        start = parseInt(input[0]);
        end = parseInt(input[1]);
    }
    console.log('<ul>');
    for (var i = start; i <= end; i++) {
        numArray.push(i);
        //console.log('<li><span class=\'num\'>'+i+'</span></li>')
    }

    for (var row = 0; row < numArray.length; row++) {
        for (var col = 0; col < numArray[row].length; col++) {
            if (numArray[row][col] == numArray[row+1][col+1]){

            }
        }

    }
   // console.log('<\/ul>');
}

solve([ '11210', '11215' ]);