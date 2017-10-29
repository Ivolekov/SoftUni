function solve(input){
    var result = { };

    for (var i in input){
        var tokens = input[i].split(' ');
        var fileName = tokens[0];
        var fileExtension = tokens[1];
        var mem = tokens[2];
        var memory = parseFloat(mem.match(/(\d+.\d+)|(\d+)/g));

        if (!result[fileExtension]){
            result[fileExtension] = {files:[],memory: []};
        }
        if (result[fileExtension].files.indexOf(fileName) == -1){
            result[fileExtension].files.push(fileName);
        }
        result[fileExtension].memory.push(memory);
    }

    for (var i in result) {
        result[i].memory = sumMemory(result[i].memory);
        result[i].files.sort();
    }

    console.log(JSON.stringify(sortObjectProperties(result)));

    function sumMemory(obj){
        var sum = 0;
        for (var i = 0; i < obj.length; i++) {
            sum += obj[i];
        }
        return sum.toFixed(2)
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

solve([ 'sentinel .exe 15MB',
    'zoomIt .msi 3MB',
    'skype .exe 45MB',
    'trojanStopper .bat 23MB',
    'kindleInstaller .exe 120MB',
    'setup .msi 33.4MB',
    'winBlock .bat 1MB' ]);