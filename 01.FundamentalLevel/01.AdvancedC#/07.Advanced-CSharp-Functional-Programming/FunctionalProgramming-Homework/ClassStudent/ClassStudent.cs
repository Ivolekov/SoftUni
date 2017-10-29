//Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), 
//GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsClass;

namespace ClassStudent
{

    internal class ClassStudent
    {
        private static void Main(string[] args)
        {

            var students = new List<Student>
            {
                new Student("Sara", "Mills", 20, "99945635", "+3592565687", "smills0@marketwatch.com",
                    new List<int> {2, 3, 6, 6}, "2"),
                new Student("Georgy", "Ivanov", 32, "998654", "+3598896352545", "georgy@abv.com",
                    new List<int> {4, 3, 5, 6}, "6"),
                new Student("Ivan", "Petkov", 36, "98524354", "+359685487", "ipetrov@hotmail.com",
                    new List<int> {6, 2, 4, 6}, "3"),
                new Student("Lubomir", "Kirov", 22, "945684354", "+359568479887", "lubomir@gmail.com",
                    new List<int> {3, 6, 4, 5}, "5"),
                new Student("Rosica", "Petrova", 20, "9856321478", "+359896374775", "rosi@abv.com",
                    new List<int> {4, 4, 4, 4}, "2"),
                new Student("Ivan", "Iliev", 36, "9856587354", "+359898652475", "vankata@hotmail.com",
                    new List<int> {6, 3, 3, 6}, "1"),
                new Student("Kiro", "Ivanov", 25, "985658795", "+359897568532", "kiro@abv.bg",
                    new List<int> {6, 3, 5, 5}, "4"),
            };

            Console.WriteLine("Group student by group");
            Student.GetStudentByFirstName(students, "2");

            Console.WriteLine("GetFirstAndLastName");
            Student.GetFirstAndLastName(students);

            Console.WriteLine("GetFirstNameLastNameAndAge");
            Student.GetFirstNameLastNameAndAge(students);
            
            //SortStudentsBy - to print change false to true
            Student.SortStudentBy(students, "linq", false);

            //FilterStudentByEmailAddress - to print change false to true
            Student.FilterStudentsByEmail(students, @"@abv.bg", false);

            //FilterStudentByPhoneAddress - to print change false to true
            Student.FilterStudentsByPhone(students, false);

            //ExelentStudents - to print change false to true
            Student.ExelentStudents(students, false);
        }
    }
}
