using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LabaPoOPP
{
    public class Poduct
    {
        private string _type;
        private int _weight;
        public Poduct()
        {


        }
        public Poduct(int Weight, string _type)
        {
            _weight = Weight;
            _type = Type;
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
        ~Poduct()
        {

        }
        public Order Order
        {
            get => default;
            set
            {
            }
        }

        //???????????
        //public void Product()
        //{
            
        //}
    }
}