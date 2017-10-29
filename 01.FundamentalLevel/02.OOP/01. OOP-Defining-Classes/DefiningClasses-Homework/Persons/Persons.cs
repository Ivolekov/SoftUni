using System;


namespace Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get{return this.name;}

            set
                {
                    if (string.IsNullOrEmpty(value) )
                    {
                        throw new ArgumentNullException("name", "Name can not be empty");
                    }
                    this.name = value;
                }
        }

        public int Age
        {
            get { return this.age; }

            set
                {
                    if (value <= 0 || value > 100)
                    {
                        throw new ArgumentOutOfRangeException("age", "The age must be in range [1..100]");
                    }
                    this.age = value;
                }
        }

        public string Email
        {
            get { return this.email; }
            set
                {
                    if (value != null && (value.Length==0 || !value.Contains("@")))
                    {
                        throw new ArgumentException("Invalid E-mail");
                    }
                    this.email = value;
                }
        }

        public override string ToString()
        {
            return string.Format("Your name is {0}  Your age is {1}  Your E-mail is {2}",
                this.Name, this.Age, this.Email ?? "[unknown]");
        }
    }
}
