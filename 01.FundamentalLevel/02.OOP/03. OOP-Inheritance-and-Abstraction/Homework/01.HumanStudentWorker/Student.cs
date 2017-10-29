using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    class Student:Human
    {
        private const int MinFacNumber = 5;
        private const int maxFacNumber = 10;
        private  int facultyNumber;

        public Student(string firstName,string lastName,int facultyNumber):base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        private int FacultyNumber
        {
            get { return this.facultyNumber; }
            set 
            {
                if(value.ToString().Length<MinFacNumber || value.ToString().Length>maxFacNumber)
                {
                    throw new ArgumentOutOfRangeException("The faculty number is must be a range[5-10}");
                }
                this.facultyNumber = value;
            }
        }
    }
}
