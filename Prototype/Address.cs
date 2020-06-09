using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
    public class Address
    {
        public Address(City city, Country country)
        {
            City = city;
            Country = country;
        }

        public City City { get; set; }
        public Country Country { get; set; }
    }

    [Serializable]
    public class Country
    {
        public Country(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    [Serializable]
    public class City
    {
        public City(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    [Serializable]
    public enum GenderEnum
    {
        Male,
        Female,
        Other
    }
}
