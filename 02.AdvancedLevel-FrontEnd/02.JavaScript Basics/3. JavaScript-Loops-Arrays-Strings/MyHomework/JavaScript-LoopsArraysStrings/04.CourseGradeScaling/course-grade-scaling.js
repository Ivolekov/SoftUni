var array = [
    {
        'name' : 'Пешо',
        'score' : 91
    },
    {
        'name' : 'Лилия',
        'score' : 290
    },
    {
        'name' : 'Алекс',
        'score' : 343
    },
    {
        'name' : 'Габриела',
        'score' : 400
    },
    {
        'name' : 'Жичка',
        'score' : 70
    }
]

function gradeScaling(array){
    for(var i in array){
        array[i].score = array[i].score + (array[i].score * 0.1);

        if(array[i].score < 100){
           array[i].hasPass = false;
        } else {
            array[i].hasPass = true;
        }
    }

    var filtered = array.filter(function(item){
        return item.hasPass
    });
    filtered.sort(function compare(a,b) {
        if (a.name < b.name) {
            return -1;
        }
        else if (a.name > b.name) {
            return 1;
        }
        else {
            return 0;
        }
    });

    for (var item in filtered){
        console.log(filtered[item]);
    }

}

gradeScaling(array);