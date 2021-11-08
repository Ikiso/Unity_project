using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LabaPoOPP
{
    public class Order
    {
        private int _number;
        private int _amount;
        private string _customerCompanyName;
        private int _time;

        public Order()
        {
            throw new System.NotImplementedException();
        }

        ~Order()
        {
            throw new System.NotImplementedException();
        }

        public Company Company
        {
            get => default;
            set
            {
            }
        }
    }
}