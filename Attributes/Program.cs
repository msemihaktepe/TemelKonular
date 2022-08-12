using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Engin", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",customer.Id,customer.FirstName,
                customer.LastName,customer.Age);
        }
    }

    class RequiredPropertyAttribute:Attribute
    {

    }

    class ToTable:Attribute
    {
        string _tableName;
        public ToTable(string tableName)
        {
            _tableName = tableName;
        }            
    }
}
