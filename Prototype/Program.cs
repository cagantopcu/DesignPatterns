using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Deep Copy ---");

            Console.WriteLine("--- First Person  ---");
            Person firstPerson = new Person("Çağan Topçu", 28, 185, 85, GenderEnum.Male, new Address(new City("İzmir"), new Country("Türkiye")));
            Console.WriteLine("1. Person's Name : " + firstPerson.Name);
            Console.WriteLine("2. Person's  City: " + firstPerson.Address.City.Name);
            Console.WriteLine("1. Person's Age : " + firstPerson.Age);
            Console.WriteLine("1. Person's Height : " + firstPerson.Height);
            Console.WriteLine("1. Person's Weight : " + firstPerson.Weight);


            Console.WriteLine("----- Second Person  ---");

            Person secondPerson = firstPerson.DeepCopy();
            secondPerson.Name = "Michael Jordan";
            secondPerson.Address.City.Name = "Florida";
            Console.WriteLine("2. Person's  Name : " + secondPerson.Name);
            Console.WriteLine("2. Person's  City: " + secondPerson.Address.City.Name);
            Console.WriteLine("1. Person's Age : " + secondPerson.Age);
            Console.WriteLine("2. Person's Height : " + secondPerson.Height);
            Console.WriteLine("2. Person's Weight : " + secondPerson.Weight);



            //Console.WriteLine("--- Shallow Copy ---");

            //            Console.WriteLine("--- First Person  ---");
            //            Person firstPerson = new Person("Çağan Topçu", 28, 185, 85, GenderEnum.Male, new Address(new City("İzmir"), new Country("Türkiye")));
            //Console.WriteLine("1. Person's Name : " + firstPerson.Name);
            //            Console.WriteLine("2. Person's  City: " + firstPerson.Address.City.Name);
            //            Console.WriteLine("1. Person's Age : " + firstPerson.Age);
            //            Console.WriteLine("1. Person's Height : " + firstPerson.Height);
            //            Console.WriteLine("1. Person's Weight : " + firstPerson.Weight);


            //            Console.WriteLine("----- Second Person  ---");

            //            Person secondPerson = firstPerson.ShallowCopy();
            //secondPerson.Name = "Michael Jordan";
            //            secondPerson.Address.City.Name = "Florida";
            //            Console.WriteLine("2. Person's  Name : " + secondPerson.Name);
            //            Console.WriteLine("2. Person's  City: " + secondPerson.Address.City.Name);
            //            Console.WriteLine("1. Person's Age : " + secondPerson.Age);
            //            Console.WriteLine("2. Person's Height : " + secondPerson.Height);
            //            Console.WriteLine("2. Person's Weight : " + secondPerson.Weight);

        }

    }
}


