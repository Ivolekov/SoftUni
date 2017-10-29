function solve(input){
    var output = {};
    for (var i = 0; i < input.length; i++) {
        var tokens = input[i].split('|');
        var course = tokens[1].trim();
        var student = tokens[0].trim();
        var grade = Number(tokens[2].trim());
        var visit = Number(tokens[3].trim());

        if (!output[course]){
            output[course] = { grades: [], visits: [], students: [] };
        }
        output[course].grades.push(grade);
        output[course].visits.push(visit);
        if (output[course].students.indexOf(student) == -1) {
            output[course].students.push(student);
        }
    }
    var result = {};
    var courses = Object.keys(output).sort();
    for (var c in courses){
        var courseName = courses[c];
        var courseInfo = {
            avgGrade: avg(output[courseName].grades),
            avgVisits: avg(output[courseName].visits),
            students: output[courseName].students.sort()
        };
        result[courseName] = courseInfo;
    }

    console.log(JSON.stringify(result));

    function avg(arr){
        var sum = 0;
        for (var i in arr){
            sum += arr[i];
        }
        var result = sum / arr.length;
        result = Number(result.toFixed(2));
        return result;
    }
}

solve([ 'Peter Nikolov | PHP  | 5.50 | 8',
    'Maria Ivanova | Java | 5.83 | 7',
    'Ivan Petrov   | PHP  | 3.00 | 2',
    'Ivan Petrov   | C#   | 3.00 | 2',
    'Peter Nikolov | C#   | 5.50 | 8',
    'Maria Ivanova | C#   | 5.83 | 7',
    'Ivan Petrov   | C#   | 4.12 | 5',
    'Ivan Petrov   | PHP  | 3.10 | 2',
    'Peter Nikolov | Java | 6.00 | 9' ]);