using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _3LabaPoOPP
{
    public class Van
    {
        private int _loadCapacity;
        private string _type;
        private List<vans> _listamountVans;
        private int _amountVans;
        public int maxAmountsVans;
        public struct vans
        {
            public int amountVans;
            public string type;
        }
        public Van()
        {
            throw new System.NotImplementedException();
        }

        public Train Train
        {
            get => default;
            set
            {
            }
        }
        public List<vans> ListVansAmount
        {
            get => _listamountVans;
            private set => _listamountVans = value;
        }
        public bool setListAmontVans(int amount, string type)
        {
            if ((_amountVans + amount) > maxAmountsVans)
            {
                Debug.Print("Ошибка превышено количество вагонов для поезда");
                return false;
            }
            else
            {
                _amountVans = +amount;
                vans listtemp = default;
                for (int i = 0; i < _listamountVans.Count; i++)
                {
                    if (_listamountVans[i].type == type)
                    {
                        listtemp.amountVans = amount + _listamountVans[i].amountVans;
                        listtemp.type = type;
                        _listamountVans[i] = listtemp;
                        return true;
                    }
                }

                listtemp.amountVans = amount;
                listtemp.type = type;
                _listamountVans.Add(listtemp);
                return true;
            }
        }
        public Poduct Poduct
        {
            get => default;
            set
            {
            }
        }
    }
}