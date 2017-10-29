namespace CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new List<int> { 1, 2, 3, 43, 5, 6, 8, 10 };
            var result = nums.WhereNot(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", result));

            var students = new List<Student>()
                               {
                                   new Student("Gosho", 4),
                                   new Student("Pesho", 3),
                                   new Student("Nasko", 2),
                                   new Student("Maria", 6),
                                   new Student("Monika", 5),
                                   new Student("Soniya", 5.5)
                               };
            Console.WriteLine(students.Max(st => st.Grade));
        }
    }
}
