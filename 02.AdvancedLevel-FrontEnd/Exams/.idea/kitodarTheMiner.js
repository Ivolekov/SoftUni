function solve(input){
    var gold = 0,
        silver = 0,
        diamonds = 0;
    for (var i in input){
        var mineName = input[i].trim().split('-')
        if (mineName) {
            if (mineName[0].substr(0, 4) === 'mine') {
                var ore = mineName[1].split(/\s*:\s*/g);
                var oreName = ore[0].trim().toLowerCase();
                var oreValue = Number(ore[1].trim());

                switch (oreName) {
                    case 'gold':
                        gold += oreValue;
                        break;
                    case 'silver':
                        silver += oreValue;
                        break;
                    case 'diamonds':
                        diamonds += oreValue;
                        break;
                    default:
                        break;
                }
            }
        }

    }
    console.log('*Silver: ' + silver);
    console.log('*Gold: ' + gold);
    console.log('*Diamonds: ' + diamonds);
}

//solve([ 'mine bobovDol - gold : 10',
//    'mine medenRudnik - silver : 22',
//    'mine chernoMore - shrimps : 24',
//    'gold:50' ]);

//solve([ 'mine bobovdol - gold : 10',
//    'mine - diamonds : 5',
//    'mine colas - wood : 10',
//    'mine myMine - silver :  14',
//    'mine silver:14 - silver : 14' ]);

solve(['	mine mina - golD : 5',
        'mine mina: gold: 5'])