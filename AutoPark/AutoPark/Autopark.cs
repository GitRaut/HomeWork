using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Autopark
    {
        string name;
        List<PassengerCar> lightcar;
        List<Truck> trucks;

        public Autopark(string name, List<PassengerCar> lightcar, List<Truck> trucks)
        {
            this.name = name;
            this.lightcar = lightcar;
            this.trucks = trucks;
        }

        public override string ToString()
        {
            string str = "Информация об автопарке:" + "\nНазвание - " + name + "\nЛегковые автомобили:";
            for (int i = 0; i < lightcar.Count; i++)
            {
                str += "\n\n" + lightcar[i].ToString();
            }
            str += "\nГрузовые автомобили:";
            for (int i = 0; i < trucks.Count; i++)
            {
                str += "\n\n" + trucks[i].ToString();
            }
            return str;
        }
    }
}

