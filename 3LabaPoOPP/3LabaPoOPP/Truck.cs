using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace _3LabaPoOPP
{
    public class Truck : Vehicle, IMove
    {
        private string _callSign;
        private string _driver;
        private int _loadСapacity;

        public Truck()
        {

        }

        public Truck(string _callSign)
        {

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

        public override void Draw()
        {
            Console.WriteLine("Данные по транспорту:\n");
            base.Draw();
        }

        public override float SetDamage(float _health)
        {
            return base.SetDamage(_health);
        }
        void FixedUpdate()
        {
            MovementLogic();
        }
        public void MovementLogic()
        {
            // т.к. мы сейчас решили использовать физическое движение снова,
            transform.Translate(_movementVector.normalized * speed);
        }
        ~Truck()
        {

        }

    }
}