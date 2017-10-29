function solve(input){
    var mood = '',
        bill = 0,
        tip = 0;

    for (var i = 0; i < input.length; i++) {
        mood = input[1];
        bill = input[0];
    }

    switch (mood) {
        case 'happy':
            tip = bill * 0.1;
            break;
        case 'married':
            tip = bill * 0.0005;
            break;
        case 'drunk':
            tip = bill * 0.15;
            var n = tip.toString()[0];
            tip = Math.pow(tip, parseInt(n));
            break;
        default:
            tip = bill * 0.05;
            break;
    }

    console.log(tip.toFixed(2));
}

solve([ '716.00', 'married' ]);