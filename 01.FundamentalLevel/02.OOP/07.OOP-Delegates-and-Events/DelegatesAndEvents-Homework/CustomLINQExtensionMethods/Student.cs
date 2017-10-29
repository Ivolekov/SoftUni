namespace CustomLINQExtensionMethods
{
    public class Student
    {
        private string name;

        private double grade;

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name { get; set; }

        public double Grade { get; set; }
    }
}
