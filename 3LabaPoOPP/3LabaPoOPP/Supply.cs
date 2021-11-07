using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LabaPoOPP
{
    public class Supply
    {
        private int _number;
        private string _customerCompanyAdress;

        public Supply(int number, string _customerCompanyAdress)
        {


        }
        public Supply(int number, string _customerCompanyAdress)
        {
            _number = Number;
            _customerCompanyAdress = CustomerCompanyAdress;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public string CustomerCompanyAdress
        {
            get => _customerCompanyAdress;
            set => _customerCompanyAdress = value;
        }
        ~Supply()
        {
            throw new System.NotImplementedException();
        }

        public Order Order
        {
            get => default;
            set
            {
            }
        }

        public Warehouse Warehouse
        {
            get => default;
            set
            {
            }
        }

        public Truck Truck
        {
            get => default;
            set
            {
            }
        }

        public Poduct Poduct
        {
            get => default;
            set
            {
            }
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