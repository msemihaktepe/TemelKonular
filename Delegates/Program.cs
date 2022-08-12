using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int myDelegate3(int number1,int number2);
    class Program
    {
        static void Main(string[] args)
        {
            // MyDelegates();

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber2());
            Console.WriteLine(getRandomNumber());

            Console.ReadLine();
        }
        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void MyDelegates()
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Matematik matematik = new Matematik();
            myDelegate3 myDelegate3 = matematik.topla;
            myDelegate3 += matematik.carp;

            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);

            myDelegate();
            myDelegate2("Hello");
        }
    }

   

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Merhaba!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }

    }

    public class Matematik
    {
        public int topla (int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
