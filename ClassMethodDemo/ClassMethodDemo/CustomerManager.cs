using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer._name + " " + customer._surname + " added!");
        }
        public void ListCustomers()
        {
            //Sahte bir döngü
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Customer " + i + " listed!");
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer " + customer._id + "deleted!");
        }
    }
}
