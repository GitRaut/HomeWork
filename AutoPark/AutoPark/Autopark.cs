using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Autopark
    {
        private string name;
        private List<PassengerCar> lightcar;
        private List<Truck> trucks;

        public Autopark(string name, List<PassengerCar> lightcar, List<Truck> trucks)
        {
            this.name = name;
            this.lightcar = new List<PassengerCar>(lightcar);
            this.trucks = new List<Truck>(trucks);
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

