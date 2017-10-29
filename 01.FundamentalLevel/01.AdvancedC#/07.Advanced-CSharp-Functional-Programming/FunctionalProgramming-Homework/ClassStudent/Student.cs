using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentsClass
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string GroupNumber { get; set; }
        public IList<int> Marks { get; set; }

        public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email,
            IList<int> marks, string groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public static void GetStudentByFirstName(List<Student> students, string groups)
        {
            var groupTwoStudents =
                from st in students
                where st.GroupNumber == groups
                orderby st.FirstName
                select st;

                foreach (var st in groupTwoStudents)
                {
                    Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}", 
                        st.FirstName, st.LastName, st.Age, st.FacultyNumber);
                    Console.WriteLine("Phone = {0} Email = {1}, Marks = {2}", 
                        st.Phone, st.Email, string.Join(" ", st.Marks));
                    Console.WriteLine("Group Number = {0}", st.GroupNumber);
                    Console.WriteLine();
                }
        }

        public static void GetFirstAndLastName(List<Student> students)
        {
            var firstAndLastName =
                from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;

                foreach (var st in firstAndLastName)
                {
                    Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}",
                         st.FirstName, st.LastName, st.Age, st.FacultyNumber);
                    Console.WriteLine("Phone = {0} Email = {1}, Marks = {2}",
                        st.Phone, st.Email, string.Join(" ", st.Marks));
                    Console.WriteLine("Group Number = {0}", st.GroupNumber);
                    Console.WriteLine();
                }
        }

        public static void GetFirstNameLastNameAndAge(List<Student> students)
        {
            var studentByAge =
                from st in students
                where (st.Age >= 18 && st.Age >= 24)
                select new { st.FirstName, st.LastName, st.Age };

                foreach (var st in studentByAge)
                {
                    Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}",
                        st.FirstName, st.LastName, st.Age);
                }
        }

        public static void SortStudentBy(List<Student> students, string sortByWith, bool print)
        {
            if (sortByWith.Contains("lambda"))
            {
                var sortWithLambda = students.OrderByDescending(st => st.FirstName)
                    .ThenByDescending(st => st.LastName)
                    .Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));
                if (print)
                {
                    Console.WriteLine("SortStudentsBy");
                    Console.WriteLine("With Lambda:");
                    foreach (string s in sortWithLambda)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            if (sortByWith.Contains("linq"))
            {
                var sortWithLinq = from st in students
                                   orderby st.FirstName descending, st.LastName descending
                                   select st;
                if (print)
                {
                    Console.WriteLine("SortStudentsBy");
                    foreach (var student in sortWithLinq)
                    {
                        Console.WriteLine("With LINQ:");
                        StringBuilder str = new StringBuilder();
                        str.Append(student.FirstName);
                        str.Append(" ");
                        str.Append(student.LastName);
                        Console.WriteLine(str.ToString());
                    }
                }
            }

        }

        public static void FilterStudentsByEmail(List<Student> students, string emailPattern, bool print)
        {
            Regex regex = new Regex(emailPattern);
            var emailGroup =
                from student in students
                where regex.IsMatch(student.Email)
                select student;

            if (print)
            {
                Console.WriteLine("FilterStudentByEmailAddress");
                foreach (var student in emailGroup)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append(student.FirstName);
                    str.Append(" ");
                    str.Append(student.LastName);
                    str.Append(" ===>>> ");
                    str.Append(student.Email);
                    Console.WriteLine(str.ToString());
                }
            }
        }

        public static void FilterStudentsByPhone(List<Student> students, bool print)
        {
            var phoneGroup =
                from student in students
                where
                    (student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") ||
                     student.Phone.StartsWith("+359 2") || student.Phone.StartsWith("87"))
                select student;

            if (print)
            {
                Console.WriteLine("FilterStudentByPhoneAddress");
                foreach (var student in phoneGroup)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append(student.FirstName);
                    str.Append(" ");
                    str.Append(student.LastName);
                    str.Append(" ===>>> ");
                    str.Append(student.Phone);
                    Console.WriteLine(str.ToString());
                }
            }
        }
        public static void ExelentStudents(List<Student> students, bool print)
        {
            var exelentStudents =
                from student in students
                where student.Marks.Max() == 6
                select student;

            if (print)
            {
                Console.WriteLine("ExelentStudents");
                foreach (var student in exelentStudents)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append(student.FirstName);
                    str.Append(" ");
                    str.Append(student.LastName);
                    str.Append(" ===>>> ");
                    str.Append(student.Marks.Max());
                    Console.WriteLine(str.ToString());
                }
            }
        }
    }
}