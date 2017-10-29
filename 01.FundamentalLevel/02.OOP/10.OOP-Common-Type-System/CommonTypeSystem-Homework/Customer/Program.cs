using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentArrey = new Payment("Ford Mustang", 1000000m);

            var vankata = new Customer(
            "Ivan",
            "Petrov",
            "Georgiev",
            "8702053654",
            "Sofia-Lulin",
            "+35988815500",
            "ivan4oo@abv.bg",
            CustomerType.OneTime,
            paymentArrey);

            var petar = vankata.Clone() as Customer;
            petar.FirstName = "Pe6o";
            petar.LastName = "Pe6ev";

            Console.WriteLine(petar);
            Console.WriteLine(vankata);
            var mariasPayments = new Payment("Masajen stol", 1000m);

            var maria = new Customer(
                "Maria",
                "Krasimirova",
                "Georgieva",
                "8599883854",
                "Nadejda5",
                "+359899339949",
                "mimi@gmail.com",
                CustomerType.Diamond,
                mariasPayments);

            var desi = maria.Clone() as Customer;
            desi.Id = "8234353535";
            desi.LastName = "Bakarkov";

            var customers = new List<Customer> { vankata, petar, maria, desi };
            customers.Sort();

            Console.WriteLine(string.Join("\n", customers));
        }
    }
}
