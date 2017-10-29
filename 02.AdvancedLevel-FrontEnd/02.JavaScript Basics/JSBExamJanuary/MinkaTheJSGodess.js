function  solve(input) {
    var output = {};
    for (var i = 0; i < input.length; i++) {
        var tokens = input[i].split(/\s+&\s+/);
        var tokensName = tokens[0];
        var type = tokens[1];
        var taskNumber = tokens[2];
        var taskKey = 'Task ' + Number(taskNumber);
        var score = Number(tokens[3]);
        var linesOfCode = Number(tokens[4]);
        var obj = {name:tokensName, type:type};

        if (!output[taskKey]) {
            output[taskKey] = {tasksOut: [], averageOut: [], lineOut: 0};
        }
        if (output[taskKey].tasksOut.indexOf(obj) === -1){
            output[taskKey].tasksOut.push(obj);
        }
        output[taskKey].averageOut.push(score);
        output[taskKey].lineOut += linesOfCode;
    }

    var result = {};
    var task = Object.keys(output);
    for (var t in task){
        var taskNum = task[t];
        var taskInfo = {};
        result[taskNum] = taskInfo;
    }
    console.log(JSON.stringify(result));

    function avg(arr){
        var sum = 0;
        for (var i in arr){
            sum += arr[i];
        }
        var result = sum / arr.length;
        result = Number(result.toFixed(2));
        return result;
    }

}

solve([ 'Array Matcher & strings & 4 & 100 & 38',
        'Magic Wand & draw & 3 & 100 & 15',
        'Dream Item & loops & 2 & 88 & 80',
        'Knight Path & bits & 5 & 100 & 65',
        'Basket Battle & conditionals & 2 & 100 & 120',
        'Torrent Pirate & calculations & 1 & 100 & 20',
        'Encrypted Matrix & nested loops & 4 & 90 & 52',
        'Game of bits & bits & 5 & 100 & 18',
        'Fit box in box & conditionals & 1 & 100 & 95',
        'Disk & draw & 3 & 90 & 15',
        'Poker Straight & nested loops & 4 & 40 & 57',
        'Friend Bits & bits & 5 & 100 & 81' ]);

