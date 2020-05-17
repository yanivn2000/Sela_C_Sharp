using System;
namespace ObjectOriented1
{
    public abstract class Vehicle
    {
        //Properties
        private string _color;
        private string _brand;        private string _model;        private float _weight;
        private int _maxSpeed;        private int _numOfGears;
        private int _price;
        private double _maxTankCapacityLiters;
        private int _numOfWheels;        private bool _isFit;
        private bool _isAutomatic;

        public int MaxSpeed() { return _maxSpeed; }
        public Vehicle(string color, string brand, string model, float weight, int maxSpeed, int numOfGears, int price, double maxTankCapacityLiters, int numOfWheels, bool isFit, bool isAutomatic)
        {
            _color = color;
            _brand = brand;
            _model = model;
            _weight = weight;
            _maxSpeed = maxSpeed;
            _numOfGears = numOfGears;
            _price = price;
            _maxTankCapacityLiters = maxTankCapacityLiters;
            _numOfWheels = numOfWheels;
            _isFit = isFit;
            _isAutomatic = isAutomatic;
        }


        public override string ToString()
        {
            return $"brand: {_brand}, " +
                $"model: {_model}, " +
                $"color: { _color}, " +
                $"weight: {_weight}Kg, " +
                $"maxSpeed: {_maxSpeed}KPH, " +
                $"numOfGears: {_numOfGears}, " +
                $"price: {_price}K $, " +
                $"maxTankCapacityLiters: {_maxTankCapacityLiters}L, " +
                $"numOfWheels: {_numOfWheels}, " +
                $"isAutomatic: {_isAutomatic}, " +
                $"isFit: {_isFit}";
        }
        /*
        //more complex
        private float _horsePower;        private float _height;
        private float _acceleration;        private double _currentTankCapacityLiters;
        private double _engineCapacityCC;
        private double _rpm;        private float _consumption;        */
            //end of props

    }
}
