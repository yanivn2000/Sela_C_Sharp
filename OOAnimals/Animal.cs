using System;
namespace OOAnimals
{
    public enum EGender
    {
        FEMALE,
        MALE
    }

    public struct Position
    {
        public int X;
        public int Y;
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
        public override string ToString()
        {
            return $"Position: (X: {X}, Y: {Y})";
        }
    }
    public abstract class Animal
    {
        public Animal(string name, int age, double weight, int speed, EGender gender, int axis/*Position myPosition*/)
        {
            Name = name;
            Age = age;
            Weight = weight;
            if (speed <= 0) speed = 1;
            Speed = speed;
            Gender = gender;
            Axis = axis;
            MyPosition = new Position(myPosition.X, myPosition.Y);
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Weight { get; private set; }
        public int Speed { get; private set; }
        public EGender Gender { get; set; }
        public Position MyPosition { get; set; }
        public int Axis { get; set; }

        public abstract string WayOfMoving();

        public bool isFemale()
        {
            if (Gender == EGender.FEMALE) return true;
            return false;
        }

        public abstract void Move(int x, int y);

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Speed: {Speed}, Gender: {Gender}, MyPosition {Axis}";
        }
    }
}
