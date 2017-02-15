using System.Collections.Generic;

namespace StaticExamples
{
    public class Car
    {

        public static int NoOfObjectCars = 0;
        public static int GetLincePlate = 0;
        public static int GetPrice = 0;
        

        private string _licensePlate;
        private int _price;

        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            NoOfObjectCars++;
            GetLincePlate++;
            GetPrice++;
        }

        public static int PrintUsageStatistics()
        {
            return NoOfObjectCars + GetLincePlate + GetPrice;
        }


    }
}