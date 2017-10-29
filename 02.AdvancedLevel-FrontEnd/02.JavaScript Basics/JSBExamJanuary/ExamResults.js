function solve(input){
    var avgCourseName = input[input.length-1].trim();
    var avgCoursePoints = 0;
    var count = 0;
    for (var i = 0; i < input.length-1; i++) {
        var tokens = input[i].trim().split(/\s+/g);
        var name = tokens[0].trim();
        var courseName = tokens[1].trim();
        var examPoints = parseFloat(tokens[2]);
        var bonus = parseFloat(tokens[3]);
        var resultPoints = (examPoints * 0.2) + bonus;
        resultPoints = parseFloat(resultPoints.toFixed(2));
        var resultGrades = ((resultPoints / 80) * 4) + 2;

        if (avgCourseName === courseName) {
            avgCoursePoints += examPoints;
            count++;
        }
        if(examPoints < 100){
            console.log(name + ' failed at "' + courseName + '"');
            continue;
        }
        if (resultGrades > 6){
            resultGrades = 6;
        }
        if (input[i] != avgCourseName) {
            console.log(name + ': Exam - "' + courseName + '"; Points - ' + resultPoints + '; Grade - ' +
                resultGrades.toFixed(2));
        }
    }
    var resultAvgCoursePoints = Number(avgCoursePoints / count);
    resultAvgCoursePoints = parseFloat(resultAvgCoursePoints.toFixed(2));
    console.log('"' + avgCourseName + '" average points -> ' + resultAvgCoursePoints);
}

solve([ 'Pesho C#-Advanced 100 3',
    'Gosho Java-Basics 157 3',
    'Tosho HTML&CSS 317 12',
    'Minka C#-Advanced 57 15',
    'Stanka C#-Advanced 157 15',
    'Kircho C#-Advanced 300 0',
    'Niki C#-Advanced 400 10',
    'C#-Advanced' ]);