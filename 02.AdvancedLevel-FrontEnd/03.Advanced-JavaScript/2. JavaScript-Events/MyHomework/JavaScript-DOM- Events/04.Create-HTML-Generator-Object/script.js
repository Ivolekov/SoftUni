window.HTMLGen = function (){

};

HTMLGen.createParagraph = function(id, text) {
    var paragraph = document.createElement('p');
    var content = document.createTextNode(text);
    var mainDiv = document.getElementById(id);
    paragraph.appendChild(content);
    mainDiv.appendChild(paragraph)
};

HTMLGen.createDiv = function(id,clName){
    var createDiv = document.createElement('div');
    createDiv.className = clName;
    var mainDiv = document.getElementById(id);
    mainDiv.appendChild(createDiv);
};

HTMLGen.createLink = function(id, text, url){
    var a = document.createElement('a');
    var aContent = document.createTextNode(text);
    var mainDiv = document.getElementById(id);
    a.href = url;
    mainDiv.appendChild(a);
    a.appendChild(aContent);
};

HTMLGen.createParagraph('wrapper', 'Soft Uni');
HTMLGen.createDiv('wrapper', 'section');
HTMLGen.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');