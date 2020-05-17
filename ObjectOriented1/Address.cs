using System;
namespace ObjectOriented1
{
    public class Address
    {
        string _state;        string _city;        public Address(string state, string city)
        {
            _state = state;
            _city = city;
        }

        public override string ToString()
        {
            return $"state: {_state}, city: {_city}";
        }
    }
}
