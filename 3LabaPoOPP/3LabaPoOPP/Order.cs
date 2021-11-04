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
            
        }

        public Order(string customerCompanyName, int _amount, int _number, int _time)
        {
            _time = Time;
            _number = Number;
            _customerCompanyName = CustomerCompanyName;
            _amount = Amount;
        }

        public int Amount
        {
            get => _amount;
            set => _amount = value;
        }
        public int Time
        {
            get => _time;
            set => _time = value;
        }
        public int Number
        {
            get => _number;
            set => _number = value;
        }


        public string CustomerCompanyName
        {
            get => _customerCompanyName;
            set => _customerCompanyName = value;
        }

        ~Order()
        {
            
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