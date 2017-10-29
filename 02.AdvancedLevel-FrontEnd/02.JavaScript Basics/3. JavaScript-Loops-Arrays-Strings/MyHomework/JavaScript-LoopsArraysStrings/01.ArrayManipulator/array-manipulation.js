function manipulate(arr) {

    function isNum(num) {
        return !isNaN(num);
    }

    function mostOccurring(arr) {
        var biggestCount = 1;
        var currentCount = 0;
        var item;
        for (var i = 0; i < arr.length; i++)
        {
            for (var j = i; j < arr.length; j++)
            {
                if (arr[i] === arr[j]) {
                    currentCount++;
                }
                if (biggestCount < currentCount)
                {
                    biggestCount = currentCount;
                    item = arr[i];
                }
            }
            currentCount = 0;
        }
        return item;
    }

    var filtered = [];

    for (var i in arr){
        if(isNum(arr[i])){
            filtered.push(arr[i]);
        }
    }

    filtered.sort(function(a, b) {
        return b - a;
    });

    var min = Math.min.apply(null, filtered);
    var max = Math.max.apply(null, filtered);
    var mostFreq = mostOccurring(filtered);
    if (mostFreq === undefined) {
        mostFreq = 'none';
    }
    console.log('Min number: ' + min);
    console.log('Max number: ' + max);
    console.log('Most frequent number: ' + mostFreq);
    console.log(filtered);
}

manipulate(["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]]);