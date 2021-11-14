using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LabaPoOPP
{
    public class Company
    {
        private string _INN;
        private string _name;
        private string _adress;

        public Company()
        {
            
        }
        public Company(string _INN, string _name, string _adress)
        {
            _INN = INN;
            _name = Name;
            _adress = Adress;
        }
        public string INN
        {
            get => _INN;
            private set => _INN = value;
        }
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public string Adress
        {
            get => _adress;
            private set => _adress = value;
        }
    }

}