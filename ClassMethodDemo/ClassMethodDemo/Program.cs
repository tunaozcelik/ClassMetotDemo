using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(id: 1234, name: "Tuna", surname: "Özçelik");
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer);
            Console.Read();
        }
    }
}
