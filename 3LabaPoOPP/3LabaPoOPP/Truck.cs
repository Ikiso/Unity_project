using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace _3LabaPoOPP
{
    public class Truck : Vehicle
    {
        private string _callSign;
        private string _driver;
        private int _loadСapacity;

        public Truck()
        {
        }

        public Truck(string _model, int _cost, string _year, string _typeFuel, int speed, float health)
        {
            Model = _model;
            _cost = _cost;
            _year = _year;
            _typeFuel = _typeFuel;
            speed = speed;
            health = SetDamage(health);
        }

        public string CallSign
        {
            get => _callSign;
            private set => _callSign = value;
        }

        public string Driver
        {
            get => _driver;
            private set => _driver = value;
        }

        public int LoadCapacity
        {
            get => _loadСapacity;
            private set => _loadСapacity = value;
        }

        //public override void Draw(string _model, int _cost, string _year, string _typeFuel, int speed, float health)
        //{
        //    Console.WriteLine("Данные по транспорту:\n");
        //    base.Draw(_model, _cost, _year, _typeFuel, speed, health);
        //}

        public override float SetDamage(float _health)
        {
            return base.SetDamage(_health);
        }
        ~Truck()
        {

        }

    }
}