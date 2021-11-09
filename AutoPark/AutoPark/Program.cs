using System;
using System.Collections.Generic;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PassengerCar> list = new List<PassengerCar>();
            list.Add(new PassengerCar("Ford", 10.14, 1980, 4));
            List<PassengerCar> copy = new List<PassengerCar>(list);
            for(int i = 0; i < copy.Count; i++)
            {
                Console.Write(copy[i] + " ");
            }
        }
    }
}
