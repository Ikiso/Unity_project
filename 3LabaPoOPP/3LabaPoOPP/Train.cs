using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _3LabaPoOPP
{
    public class Train : Vehicle, IMove
    {
        private List<train> _listamountTrain;
        private int _maxWorldLoad;
        private int _amountTrain;
        public int maxAmountsTrain;
        public struct train
        {
            public int amountTrain;
            public string type;
        }
        public Train()
        {

        }

        public Train(int _amountTrain, int _maxWorldLoad)
        {
            _amountTrain = AmountTrain;
            _maxWorldLoad = MaxWorldLoad;
        }

        public int AmountTrain
        {
            get => _amountTrain;
            private set => _amountTrain = value;
        }

        public int MaxWorldLoad
        {
            get => _maxWorldLoad;
            private set => _maxWorldLoad = value;
        }

        public List<train> ListVansAmount
        {
            get => _listamountTrain;
            private set => _listamountTrain = value;
        }
        public bool setListAmontVans(int amount , string type)
        {
            if ((_amountTrain + amount) > maxAmountsTrain)
            {
                Debug.Print("Ошибка превышено количество вагонов для поезда");
                return false;
            }
            else
            {
                _amountTrain =+ amount;
                train listtemp = default;
                for (int i = 0; i < _listamountTrain.Count; i++)
                {
                    if (_listamountTrain[i].type == type)
                    {
                        listtemp.amountTrain = amount + _listamountTrain[i].amountTrain;
                        listtemp.type = type;
                        _listamountTrain[i] = listtemp;
                        return true;
                    }
                }

                listtemp.amountTrain = amount;
                listtemp.type = type;
                _listamountTrain.Add(listtemp);
                return true;
            }
        }

        public bool SoldTrain(int amount , string type)
        {
            foreach (train _train in _listamountTrain)
            {
                if (_train.amountTrain == amount && _train.type == type)
                {
                    _listamountTrain.Remove(_train);
                    return true;
                }
            }
            Debug.Print("Невозможно продать поезд, т.к у вас их нет");
            return false;
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