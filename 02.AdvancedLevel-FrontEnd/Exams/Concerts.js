function solve(arr){
    var output = { };
    for (var i in arr){
        var data = arr[i].split('|');
        var band = data[0].trim();
        var town = data[1].trim();
        var date = data[2];
        var venue = data[3].trim();

        if (!output[town]){
            output[town] = {};
        }
        if (!output[town][venue]){
            output[town][venue] = [];
        }
        if (output[town][venue].indexOf(band) == -1){
            output[town][venue].push(band);
        }
    }

    output = sorting(output);

    for (var town in output){
        output[town] = sorting(output[town]);
        for (var venue in output[town]){
            output[town][venue].sort();
        }
    }

    console.log(JSON.stringify(output));

    function sorting(obj){
        var sortedKey = Object.keys(obj).sort();
        var sortedData = {};
        for (var i = 0; i < sortedKey.length; i++) {
            var key = sortedKey[i];
            sortedData[key] = obj[key];
        }
        return sortedData;
    }
}



solve([ 'ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
    'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
    'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
    'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
    'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
    'Helloween | London | 28-Jul-2014 | Wembley Stadium',
    'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
    'Metallica | London | 03-Oct-2014 | Olympic Stadium',
    'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
    'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium' ]);