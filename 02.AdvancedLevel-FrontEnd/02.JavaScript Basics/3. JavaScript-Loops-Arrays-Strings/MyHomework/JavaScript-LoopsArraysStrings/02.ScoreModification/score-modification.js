var score = [200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1];

function filterScore(arr){
    var filtered = [];
    for(var i in arr) {
        if (arr[i] >= 0 && arr[i] <= 400) {
            filtered.push(arr[i] - arr[i]*0.2);
        }
    }
    filtered.sort(function(a, b){
        return a-b;
    });
    console.log(filtered);
}

filterScore(score);
