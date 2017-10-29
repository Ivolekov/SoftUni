using System;
using System.Collections.Generic;
using System.Linq;
using ClassStudent;
namespace StudentsByGroup
{
    class StudentsByGroup
    {
        static void Main(string[] args)
        {
             var student = new List<Student>
            {
                new Student("Sara", "Mills", 20, "99945635", "+3592565687", "smills0@marketwatch.com",
                    new List<int> { 2, 3, 6, 6 }, 1),
                new Student("Georgy", "Ivanov", 32, "998654", "+3598896352545", "georgy@abv.com",
                    new List<int> { 4, 3, 5, 6 }, 6),
                new Student("Ivan", "Petkov", 36, "98524354", "+359685487", "ipetrov@hotmail.com",
                    new List<int> { 6, 2, 4, 6 }, 3),
                new Student("Lubomir", "Kirov", 22, "945684354", "+359568479887", "lubomir@gmail.com", 
                    new List<int> { 3, 6, 4, 5 }, 5),
                new Student("Rosica", "Petrova", 20, "9856321478", "+359896374775", "rosi@abv.com", 
                    new List<int> { 4, 4, 4, 4 }, 2),
                new Student("Ivan", "Iliev", 36, "9856587354", "+359898652475", "vankata@hotmail.com", 
                    new List<int> { 6, 3, 3, 6 }, 2),
                new Student("Kiro", "Ivanov", 25, "985658795", "+359897568532", "kero@abv.bg",
                    new List<int> { 6, 3, 5, 5 }, 4),
            };
             var groupTwoStudents =
                from st in student
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;
            foreach (var st in groupTwoStudents)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1}\nAge = {2}, Faculty Number = {3}", st.FirstName,
                    st.LastName, st.Age, st.FacultyNumber);
                Console.WriteLine("Phone = {0}, Email = {1}, Marks = {2}", st.Phone, st.Email, string.Join(" ", st.Marks));
                Console.WriteLine("Group Number = {0}", st.GroupNumber);
            }
        }
    }
}
