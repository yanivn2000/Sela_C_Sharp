﻿using System;
namespace ObjectOriented1
{
    public class Address
    {
        string _state;
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