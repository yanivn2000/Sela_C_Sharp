using System;

namespace ObjectOriented1
{
    public class FormulaCar : Vehicle
    {

        private int _roundPerTire;

        private const int NUM_OF_WEELS = 4;

        public FormulaCar(int roundPerTire, string color, string brand, string model, float weight, int maxSpeed, int numOfGears, int price, double maxTankCapacityLiters, bool isAutomatic = true, bool isFit = true)
            : base(color, brand, model, weight, maxSpeed, numOfGears, price, maxTankCapacityLiters, NUM_OF_WEELS, isAutomatic, isFit)
        {
            _roundPerTire = roundPerTire;
        }

        public override string ToString()
        {
            return base.ToString() + ", " +
                $"roundPerTire: {_roundPerTire}";
        }

    }
}
