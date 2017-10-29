function createParagraph(id, text) {
    var paragraph = document.createElement('p');
    var content = document.createTextNode(text);
    var mainDiv = document.getElementById(id);
    paragraph.appendChild(content);
    mainDiv.appendChild(paragraph)
}

createParagraph('wrapper', 'Some text');