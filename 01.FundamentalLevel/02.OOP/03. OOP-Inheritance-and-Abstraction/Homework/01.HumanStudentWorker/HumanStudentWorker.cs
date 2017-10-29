using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    public class HumanStudentWorker
    {
        static void Main(string[] args)
        {
            List<Student> numStudent = new List<Student>()
            {
                new Student("Ileksandar", "Bumbarov", 11111),
                new Student("Miroslav", "Milichin", 31245),
                new Student("Diana", "Spasova", 44444),
                new Student("Dimitar", "Bojkov", 67895),
                new Student("Encho", "Dikov", 34256),
                new Student("Stanimira", "Metodieva", 93452),
                new Student("Joanna", "Dimitrova", 71234),
                new Student("Tzetzka", "Ivanova", 69856),
                new Student("Ivan", "Ivanov", 78743),
                new Student("Andrey", "Georgiev", 77889)
            };
            numStudent = new List<Student>(numStudent.OrderBy(x =>x.FirstName ).ThenBy(x=>x.LastName).ToList());

            foreach (var student in numStudent)
            {
                Console.WriteLine(student + " Faculty number:" + student);
            }
            Console.WriteLine();

            List<Worker> lsitWorker = new List<Worker>()
            {
                new Worker("Sasho", "Yovkov", 200, 8),
                new Worker("Bash", "Maistora", 1000, 8),
                new Worker("Jelqzko", "Sopata", 600, 8),
                new Worker("Masha", "Grigorova", 1200, 8),
                new Worker("Kyncho", "Jordanov", 300, 8),
                new Worker("Dimitar", "Petkanov", 160, 8),
                new Worker("Biser", "Kirov", 720, 8),
                new Worker("Georgi", "Dimitrov", 4000, 8),
                new Worker("Vldimir", "Putin", 50, 8),
                new Worker("Barak", "Obama", 670, 8),
            };

            lsitWorker = new List<Worker>(lsitWorker.OrderBy(w => w.MoneyPerHours()));
            foreach (var worker in lsitWorker)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker);
            }
            Console.WriteLine();


            List<Human> allHumans = new List<Human>();

            numStudent.ForEach(student => allHumans.Add(student));
            lsitWorker.ForEach(worker => allHumans.Add((worker)));

            allHumans = new List<Human>(allHumans.OrderBy(a => a.FirstName));
            foreach (var human in allHumans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName + " - " + human.GetType().Name);
            }
        }
    }
}
