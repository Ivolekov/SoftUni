function solve(input){
    var output = {};

    for (var i = 0; i < input.length; i++) {
        var tokens = input[i].split(':');
        var countries = tokens[0].trim().split('/');
        var score = tokens[1].split('-');

        var homeTeam = countries[0].trim();
        var awayTeam = countries[1].trim();
        var homeScore = Number(score[0].trim());
        var awayScore = Number(score[1].trim());

        processResults(output, homeTeam, awayTeam, homeScore, awayScore);
        processResults(output, awayTeam, homeTeam, awayScore, homeScore);

    }

    output = sortObjectProperties(output);

    for (var team in output){
        output[team].matchesPlayedWith.sort();
    }

    console.log(JSON.stringify(output));

    function processResults(results, teamHome, teamAway, goalsHome, goalsAway) {
        if (!results[teamHome]) {
            results[teamHome] = { goalsScored: 0, goalsConceded: 0, matchesPlayedWith: []};
        }
        results[teamHome].goalsScored += goalsHome;
        results[teamHome].goalsConceded += goalsAway;
        if (results[teamHome].matchesPlayedWith.indexOf(teamAway) == -1) {
            results[teamHome].matchesPlayedWith.push(teamAway);
        }
    }

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