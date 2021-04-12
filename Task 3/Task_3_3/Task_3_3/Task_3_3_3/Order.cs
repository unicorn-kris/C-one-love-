using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3_3
{
    class Order
    {
        private int _pizza;
        private int _orderInt;
        private Customer _customer;

        public Order(int pizza, Customer customer)
        {
            _pizza = pizza;
            _customer = customer;
            _orderInt = 0;
        }
        public int GetSetOrderInt
        {
            get
            {
                return _orderInt;
            }
            set
            {
                _orderInt = value;
            }
        }
        public string GetCustomer
        {
            get
            {
                return _customer.GetName;
            }
        }
    }
}
