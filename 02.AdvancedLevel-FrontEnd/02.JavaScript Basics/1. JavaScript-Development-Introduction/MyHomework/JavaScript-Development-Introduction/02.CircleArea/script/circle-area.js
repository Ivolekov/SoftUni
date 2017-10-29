function calcCircleArea(r){
    var area = Math.PI * Math.pow(r, 2);
    document.write("r = "+r+"; area = "+area+"</br>");
}

function getInput(){
    var input = document.getElementById("input").value;
    return input;
}

function calc(inputR){
    var inputR = getInput();
    var area = Math.PI * Math.pow(inputR, 2);
    document.write("<p>r = "+inputR+"; area = "+area+"</p><p>Press refresh button to calc again<\p>");
}

