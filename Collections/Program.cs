using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer", "bilgisayar");

           // Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }
            
            Console.ReadLine();
        }

        private static void List()
        {
            //Tip Güvenli Koleksiyon
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Semih" });
            customers.Add(new Customer { Id = 2, FirstName = "Veli" });


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Feyyaz"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4,FirstName="Ali"},
                new Customer{Id=5,FirstName="Mehmet"}
            });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }


        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }

}
