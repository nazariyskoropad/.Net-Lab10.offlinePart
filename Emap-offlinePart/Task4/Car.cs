using System;

namespace Epam.Task4
{
    [Serializable]
    public class Car
    {
        public int carId;
        public decimal price;
        public int quantity;
        [NonSerialized]
        public decimal total;
        public Car() { }
        public Car(int _carId, decimal _price, int _quantity, decimal _total)
        {
            carId = _carId;
            price = _price;
            quantity = _quantity;
            total = _total;
        }
    }
}
