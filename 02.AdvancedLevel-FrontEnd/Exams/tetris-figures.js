function solve(input){
    var output = [];

    for (var i = 0; i < input.length; i++) {
        output[i] = input[i].split('');
    }

    for (var row = 0; row < output.length; row++) {
        for (var col = 0; col < output[row].length; col++) {

            if ((output[row][col] === output[row+1][col]) && (output[row+2][col] === output[row+3][col])){
                console.log('a')
            }

        }
    }
}

solve([ '--o--o-', '--oo-oo', 'ooo-oo-', '-ooooo-', '---oo--' ]);