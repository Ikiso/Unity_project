using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LabaPoOPP
{
    public class Product
    {
        private string _type;
        private int _weight;

        public Product()
        {



        }

        public Product(string type, int _weight)
        {
            _type = Type;
            _weight = Weight;
        }

        public int Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public Order Order
        {
            get => default;
            set
            {
            }
        }

        ~Product()
        {

        }
    }
}