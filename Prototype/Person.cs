using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Address Address { get; set; }

        public GenderEnum Gender { get; set; }


        public Person(string name, int age, int height, int weight , GenderEnum gender, Address address)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Gender = gender;
            Address = address;
        }


        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            using (var memoryStream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, this);
                memoryStream.Position = 0;

                return (Person)formatter.Deserialize(memoryStream);
            }
        }
    }
}
