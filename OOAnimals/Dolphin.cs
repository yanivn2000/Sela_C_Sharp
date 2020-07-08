using System;
namespace OOAnimals
{
    public class Dolphin: Mammal
    {
        int LenTail;
        public Dolphin(int MonthBirth, string name, int age, double weight, int speed, EGender gender, int axis) :
            base(MonthBirth, name, age, weight, speed, gender, axis)
        {
        }
        public override string WayOfMoving()
        {
            return "Swimming";
        }
    }
}
