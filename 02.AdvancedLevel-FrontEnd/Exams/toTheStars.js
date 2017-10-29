function solve(input){
    var firstStar = input[0].split(/\s+/);
    var secondStar = input[1].split(/\s+/);
    var thirdStar = input[2].split(/\s+/);
    var info = input[3].split(/\s+/);
    var infoX = parseInt(info[0]);
    var infoY = parseInt(info[1]);
    var turn = parseInt(input[4]);

    var starX = [firstStar[1], secondStar[1], thirdStar[1]];
    var starY = [firstStar[2], secondStar[2], thirdStar[2]];

    for (var i = 0; i < turn; i++) {
        var foundStar = false;

        if (infoX == ){

        }
    }
}

solve([ 'Sirius 3 7', 'Alpha-Centauri 7 5', 'Gamma-Cygni 10 10', '8 1', '6' ]);