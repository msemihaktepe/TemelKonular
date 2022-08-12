using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());            
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();


            Console.ReadLine();
        }


        class CustomerManager
        {
            private int _count = 15;
            public CustomerManager(int count)
            {
                _count = count;
            }

            public CustomerManager()
            {

            }
            public void List()
            {
                Console.WriteLine("Listed {0} İtems", _count);
            }

            public void Add()
            {
                Console.WriteLine("Added!");
            }
        }

        class Product
        {
            public Product()
            {

            }
            private int _id;
            private string _name;
            public Product(int id, string name)
            {
                _id = id;
                _name = name;
            }
            public int Id { get; set; }
            public string Name { get; set; }
        }

        interface ILogger
        {
            void Log();
        }

        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to database");
            }
        }

        class FileLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to File");
            }
        }

        class EmployeeManager
        {
            private ILogger _logger;
            public EmployeeManager(ILogger logger)
            {
                _logger = logger;
            }
            public void Add()
            {
                _logger.Log();
                Console.WriteLine("Added!");
            }
        }

        class BaseClass
        {
            private string _entity;
            public BaseClass(string entity)
            {
                _entity = entity;
            }

            public void Message()
            {
                Console.WriteLine("{0} message",_entity);
            }
        }

        class PersonManager:BaseClass
        {
            public PersonManager(string entity):base(entity)
            {
                
            }

            public void Add()
            {
                Console.WriteLine("Added!");
                Message();
            }
        }


    }
}
