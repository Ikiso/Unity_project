using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _3LabaPoOPP
{
    public class Train : Vehicle, IMove
    {
        private int _amountVans;
        private int _maxWorldLoad;

        public Train()
        {

        }

        public Train(int _amountVans, int _maxWorldLoad)
        {
            _amountVans = AmountVans;
            _maxWorldLoad = MaxWorldLoad;
        }

        public int AmountVans
        {
            get => _amountVans;
            private set => _amountVans = value;
        }

        public int MaxWorldLoad
        {
            get => _maxWorldLoad;
            private set => _maxWorldLoad = value;
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
            transform.Translate(_movementVector.normalized * Speed);
        }
    }
}