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
        public Order(int number, int amount, int time, string _customerCompanyName)
        {
            _number = Number;
            _amount = Amount;
            _time = Time;
            _customerCompanyName = СustomerCompanyName;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
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

        public string СustomerCompanyName
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