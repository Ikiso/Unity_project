using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LabaPoOPP
{
    public class Warehouse
    {
        private int _amount; //Сколько сейчас занято
        private string _adress;
        private int _maxAmount;
        private List<goods> _listGoods;
        public struct goods
        {
            public int amount;
            public string type;
        };
        public Warehouse()
        {
            
        }
        public Warehouse(string _adress, int _maxAmount)
        {
            _adress = Adress;
            _maxAmount = MaxAmount;
            _amount = Amount;
            _listGoods = ListGoods;
        }
        public string Adress
        {
            get => _adress;
            private set => _adress = value;
        }
        public int Amount
        {
            get => _amount;
            private set => _amount = 0;
        }
        public int MaxAmount
        {
            get => _maxAmount;
            private set => _maxAmount = value;
        }
        public List<goods> ListGoods
        {
            get => _listGoods;
            private set => _listGoods = new List<goods>();
        }
        public bool importGoods(int amount, string type)
        {
            if ((_amount + amount) > _maxAmount)
            {
                Console.WriteLine("Недостаточно места на складе!");
                return false;
            }
            else
            {
                _amount = _amount + amount;
                goods temp;
                for (int i = 0; i < _listGoods.Count; i++)
                {
                    if (_listGoods[i].type == type)
                    {
                        temp.amount = amount + _listGoods[i].amount;
                        temp.type = type;
                        _listGoods[i] = temp;
                        return true;
                    }
                }
                temp.amount = amount;
                temp.type = type;
                _listGoods.Add(temp);
                return true;
            }
        }
        public bool deleteGoods(int amount, string type)
        {
            foreach(goods _goods in _listGoods)
            {
                if (_goods.amount == amount && _goods.type == type)
                {
                    _listGoods.Remove(_goods);
                    return true;
                }
            }
            Console.WriteLine("На складе нет {0} шт. {1}", amount, type);
            return false;
        }
        public void ViewListGoods()
        {
            foreach (goods _goods in _listGoods)
            {
                Console.WriteLine("{0} - {1}шт.\n", _goods.type, _goods.amount);
            }
        }
        public int ViewListGoods(string type)
        {
            foreach(goods _goods in _listGoods)
            {
                if (_goods.type == type)
                {
                    return _goods.amount;
                }
            }
            return 0;
        }
        //public void info() //можно возвращать сколько занято места, сколько максимум места, сколько типов товара ...
        //{

        //}
        public Company Company
        {
            get => default;
            set
            {
            }
        }
    }
}