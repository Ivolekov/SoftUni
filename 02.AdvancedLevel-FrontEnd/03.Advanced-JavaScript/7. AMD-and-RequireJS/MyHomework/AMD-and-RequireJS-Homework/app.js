(function () {
    require.config({
        paths: {
            'container': 'models/container',
            'section': 'models/section',
            'item': 'models/item',
            'factory': 'factory'
        }
    })
})();

require(['factory'], function (Factory) {
   var container,
       section,
       item;

    container = new Factory.Container('Sunday TODO List');
    section = new Factory.Section('Section');
    item = new Factory.Item('Item');

    container.addToDOM();

    var parent = document.getElementById('listWrapper')[0];
    section.addToDOM(parent);
    //item.addToDOM(parent.lastChild)
});