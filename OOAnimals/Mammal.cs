using System;
namespace OOAnimals
{
    public abstract class Mammal : Animal
    {
        public int MonthBirth { get; private set; }

        public Mammal(int MonthBirth, string name, int age, double weight, int speed, EGender gender, int axis) :
            base(name, age, weight, speed, gender, axis)
        {
            this.MonthBirth = MonthBirth;
        }
        public override string ToString()
        {
            return $"MonthBirth: {MonthBirth}, {base.ToString()}";
        }
        public override void Move(int x, int y)
        {
            Axis += x * Speed;
        }
    }
}
