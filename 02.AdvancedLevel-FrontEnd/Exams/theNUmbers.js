function solve(input){
    var str ='';
    var arr =[];
    for (var i = 0; i < input.length; i++) {
        str += input[i];
    }
    var reg = str.match(/[0-9]+/g);
    for (var i = 0; i < reg.length; i++) {
        var nums = (Number(reg[i]).toString(16).toUpperCase());
        arr.push('0x'+('0000'+ nums).slice(-4));
    }
    console.log(arr.join('-'));
}

solve([ '5tffwj(//*7837xzc2---34rlxXP%$".' ]);