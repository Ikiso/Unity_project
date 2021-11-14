using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LabaPoOPP
{
    public class Garage
    {
        private int _amount;
        static List<Vehicle> _storedTransport;
        private string _name;
        //private string _cost //Стоимость аренды или ежемесячные затраты

        public Garage()
        {
            
        }

        public Garage(string _name, int _amount)
        {
            _name = Name;
            _amount = Amount;
            _storedTransport = new List<Vehicle>();
            //_storedTransport = StoregTransport;
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
        //public List<Vehicle> StoregTransport
        //{
        //    get => _storedTransport;
        //    set => _storedTransport = new List<Vehicle>();
        //}
        public void AddCar(Vehicle vehicle)
        {
            _storedTransport.Add(vehicle);
            _storedTransport.Sort(); //Сортирует список
        }
        public void DeleteCar(Vehicle vehicle)
        {
            foreach(Vehicle veh in _storedTransport)
            {
                if (veh == vehicle)
                {
                    _storedTransport.Remove(veh);
                    return;
                }
            }
            Console.WriteLine("Машины с Таким именем в списке нет!");
            return;
        }
        public void ViewVehicle()
        {
            foreach (Vehicle vehicle in _storedTransport)
            {
                //Console.WriteLine("{1}\n", vehicle._model);
                vehicle.Draw();
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