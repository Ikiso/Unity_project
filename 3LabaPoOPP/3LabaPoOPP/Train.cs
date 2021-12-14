using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _3LabaPoOPP
{
    public class Train : Vehicle
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

        public Train( int _amountTrain, int _maxWorldLoad, string _model, int _cost, string _year, string _typeFuel, int speed, float health)
        {
            _amountTrain = _amountTrain;
            _maxWorldLoad = _maxWorldLoad;
            _model = _model;
            _cost = _cost;
            _year = _year;
            _typeFuel = _typeFuel;
            speed = speed;
            health = SetDamage(health);
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
        public bool SetListAmontVans(int amount, string type)
        {
            if ((_amountTrain + amount) > maxAmountsTrain)
            {
                Debug.Print("Ошибка превышено количество вагонов для поезда");
                return false;
            }
            else
            {
                _amountTrain = +amount;
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

        public bool SoldTrain(int amount, string type)
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
        public new void Draw(string _model, int _cost, string _year, string _typeFuel, int speed, float health)
        {
            Console.WriteLine("Данные по поезду:\n");
            base.Draw(_model, _cost, _year, _typeFuel, speed, health);
        }
        public new float SetDamage(float health)
        {
            return base.SetDamage(health);
        }

    }
}