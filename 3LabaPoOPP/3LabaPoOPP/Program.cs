using System;

namespace _3LabaPoOPP
{
    class Program
    {
        delegate void mValueTuple();
        static void Main(string[] args)
        {
            mValueTuple msg;

            float health = 5;
            int _amountTrain = 5, _maxWorldLoad = 5;
            string _model = "Model";
            int _cost = 6;
            string _year = "1992";
            string _typeFuel = "Oil";
            int speed = 56;

            Garage DED = new Garage("DedInside", 10);

            Vehicle trainVehical = new Train( _amountTrain, _maxWorldLoad, _model , _cost, _year, _typeFuel, speed, health);
            Vehicle truckVTruck = new Truck(_model, _cost, _year, _typeFuel, speed, health);

            DED.AddCar(truckVTruck);
            //DED.AddCar(trainVehical);

            DED.ViewVehicle();

            trainVehical.Draw(_model, _cost, _year, _typeFuel, speed, health);
            truckVTruck.Draw(_model, _cost, _year, _typeFuel, speed, health);

            health = trainVehical.SetDamage(health);
            health = truckVTruck.SetDamage(health);


            IMove move = new Vehicle();
            IMove2 move2 = new Vehicle();

            msg = move.MovementLogic;
            msg += move2.MovementLogic;

            msg();

        }
    }
}
