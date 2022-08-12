using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList("Ankara","İzmir","Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName="Engin"},new Customer { FirstName="Sezgin"});
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }
    //Metotlarda Generics Kullanımı
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product
    {

    }
    interface IProductDal:IRepository<Product>
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Delete(Product product);
        void update(Product product);

    }

    class Customer
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal :IRepository<Customer>
    {
       
    }

    interface IRepository<T> where T:class //Generic Yapıyı Oluşturuyoruz
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void update(T entity);
    }

    class ProductDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}

