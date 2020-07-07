using System;
namespace OOAnimals
{
    public enum Gender
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
    }
    public class Animal
    {
        public Animal(string name, int age, double weight, int speed, Gender gender, Position myPosition)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Speed = speed;
            Gender = gender;
            MyPosition = new Position(myPosition.X, myPosition.Y);
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Weight { get; private set; }
        public int Speed { get; private set; }
        public Gender Gender { get; set; }
        public Position MyPosition { get; set; }

        public bool isFemale()
        {
            if (Gender == Gender.FEMALE) return true;
            return false;
        }

        public void Move(int x, int y)
        {
            MyPosition.Move(x,y);
        }

    }
}
