using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LabaPoOPP
{
    public class Garage
    {
        private int _amount;
        private List<string> _storedTransport;
        private string _name;
        //private string _cost //Стоимость аренды или ежемесячные затраты

        public Garage()
        {
            
        }

        public Garage(string _name, int _amount)
        {
            _name = Name;
            _amount = Amount;
            _storedTransport = StoregTransport;
        }
        ~Garage()
        {
            _storedTransport.Clear();
        }
        public int Amount
        {
            get => _amount;
            private set => _amount = value;
        }
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public List<string> StoregTransport
        {
            get => _storedTransport;
            private set => _storedTransport = new List<string>();
        }
        public void AddCar(string Name)
        {
            _storedTransport.Add(Name);
            _storedTransport.Sort(); //Сортирует список
        }
        public void DeleteCar(string Name)
        {
            foreach(string str in _storedTransport)
            {
                if (str == Name)
                {
                    _storedTransport.Remove(str);
                    return;
                }
            }
            Console.WriteLine("Машины с Таким именем в списке нет!");
            return;
        }
        public void ViewVehicle()
        {
            foreach (string str in _storedTransport)
            {
                Console.WriteLine("{1}\n");
            }
        }
        public int Filling() //Сколько сейчас машин в Гараже
        {
            return _storedTransport.Count;
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