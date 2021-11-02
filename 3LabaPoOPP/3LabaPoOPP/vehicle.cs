using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _3LabaPoOPP
{
    public class Vehicle
    {
        public Vector2 direction;
        private string _model;
        private int _cost;
        private string _year;
        private string _typeFuel;
        public int speed;
        private float health;

        public Vehicle()
        {
            
        }

        public Vehicle(string _model)
        {
            _model = Model;
            _cost = Cost;
            _year = Year;
            _typeFuel = TypeFuel;
            speed = Speed;
            health = Health;
        }

        public string Model
        {
            get => _model;
            private set => _model = value;
        }

        public int Cost
        {
            get => _cost;
            private set => _cost = value;
        }

        public string Year
        {
            get => _year;
            private set => _year = value;
        }

        public string TypeFuel
        {
            get => _typeFuel;
            private set => _typeFuel = value;
        }

        public int Speed
        {
            get => speed;
            private set => speed = value;
        }
        public float Health
        {
            get => health;
            private set => health = value;
        }

        public virtual float SetDamage(float health)
        {
            health = health % 4;
            if(health != 0)
                return health;
            return 0;
        }
        public virtual void Draw()
        {
            Console.WriteLine("{0} , {1} , {2}, {3} , {4} , {5}, {6}", _model, _cost , _year, _typeFuel, speed, health);
        }
        public Garage Garage
        {
            get => default;
            set
            {
            }
        }
    }
}