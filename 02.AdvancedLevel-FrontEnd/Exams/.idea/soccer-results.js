function solve(input){
    var output = {};

    for (var i = 0; i < input.length; i++) {
        var tokens = input[i].split(':');
        var countries = tokens[0].trim().split('/');
        var score = tokens[1].trim().split('-');

        var homeTeam = countries[0].trim();
        var awayTeam = countries[1].trim();
        var homeScore = Number(score[0]);
        var awayScore = Number(score[1]);

        if (!output[homeTeam]){
            output[homeTeam] = { goalsScored: 0, goalsConceded: 0, matchesPlayedWith: []};
        }
        output[homeTeam].goalsScored += homeScore;
        output[homeTeam].goalsConceded += awayScore;
        if (output[homeTeam].matchesPlayedWith.indexOf(awayTeam) == -1){
            output[homeTeam].matchesPlayedWith.push(awayTeam);
        }
    }

    output = sortObjectProperties(output);

    for (var team in output){
        output[team].matchesPlayedWith.sort();
    }

    console.log(JSON.stringify(output));

    function sortObjectProperties(obj) {
        var keysSorted = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < keysSorted.length; i++) {
            var key = keysSorted[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }
}

solve([ 'Germany / Argentina: 1-0',
    'Brazil / Netherlands: 0-3',
    'Netherlands / Argentina: 0-0',
    'Brazil / Germany: 1-7',
    'Argentina / Belgium: 1-0',
    'Netherlands / Costa Rica: 0-0',
    'France / Germany: 0-1',
    'Brazil / Colombia: 2-1' ]);