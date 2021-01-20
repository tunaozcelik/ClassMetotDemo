using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Customer : IPerson
    {
        public int _id;
        public string _name;
        public string _surname;
        public Customer(int id, string name, string surname)
        {
            _id = id;
            _name = name;
            _surname = surname;
        }
    }
}
