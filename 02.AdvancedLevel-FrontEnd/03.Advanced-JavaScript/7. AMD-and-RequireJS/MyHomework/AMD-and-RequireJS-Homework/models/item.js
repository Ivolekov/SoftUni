define([], function () {
    return (function () {
        var count = -2; // counter offset

        function checkContent(content) {
            if (!content) {
                throw new Error('The content of a list item cannot be empty.');
            }
        }

        function Item(content) {
            checkContent(content);
            count++;
            this._content = content;
        }

        Item.prototype.getDomElement = function () {
            var div = document.createElement('div'),
                checkbox = document.createElement('input'),
                label = document.createElement('label');

            checkbox.type = 'checkbox';
            checkbox.id = 'list-item-' + count;

            label.innerHTML = this._content;
            label.htmlFor = checkbox.id;

            div.appendChild(checkbox);
            div.appendChild(label);

            this._domElement = div;
        };

        Item.prototype.addToDOM = function (event) {
            var parent = event.target.parentNode,
                title = parent.querySelector('input[name=itemName]').value,
                container = parent.querySelector('.listContainer'),
                Item = new Item(title),
                newItem;

            Item.getDomElement();
            newItem = Item._domElement;

            container.appendChild(newItem);
        };

        return Item;

    })();
});
