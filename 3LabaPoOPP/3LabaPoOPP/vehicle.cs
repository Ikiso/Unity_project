using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _3LabaPoOPP
{
    public class Vehicle : IMove, IMove2
    {
        public Vector2 direction;
        public string _model;
        private int _cost;
        private string _year;
        private string _typeFuel;
        public int speed;
        public float health;

        public Vehicle()
        {

        }

        public Vehicle(string _model, int _cost, string _year, string _typeFuel, int speed, float health)
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
            set => _model = value;
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
            health = health - 2;
            if (health != 0)
                return health;
            return 0;
        }
        public virtual void Draw(string _model, int _cost, string _year, string _typeFuel,int speed,float health)
        {
            Console.WriteLine("Model is: {0}, Cost is: {1}, Year is: {2}, Fuel is: {3}, Speed is {4}, Health is {5}", _model, _cost, _year, _typeFuel, speed, health);
        }
        public virtual void Draw()
        {

            Console.WriteLine("Model is: {0}, Cost is: {1}, Year is: {2}, Fuel is: {3}, Speed is {4}, Health is {5}", _model, _cost, _year, _typeFuel, speed, health);
        }
        void IMove.MovementLogic()
        {
            // т.к. мы сейчас решили использовать физическое движение снова,
            //transform.Translate(_movementVector.normalized * speed);
            Console.WriteLine("ДВИЖЕНИЕ ПЕРВОЕ, через таймер\n");
        }

        void IMove2.MovementLogic()
        {
            Console.WriteLine("Движение происходит в консоле, иго-го\n");
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