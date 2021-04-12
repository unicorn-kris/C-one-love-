using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3_3
{
    class Customer
    {
        private string _name;
        public Customer(string name)
        {
            _name = name;
        }
        public string GetName
        {
            get
            {
                return _name;
            }
        }
    }
}
