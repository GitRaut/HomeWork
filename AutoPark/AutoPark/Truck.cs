using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Truck : Car
    {
        int maxWeight;
        string fio;
        Dictionary<string, int> cargo;

        public Truck(string label, double power, int year, int maxWeight, string fio) : base(label, power, year)
        {
            this.maxWeight = maxWeight;
            this.fio = fio;
            cargo = new Dictionary<string, int>();
        }
        public void AddCargo(string name, int weight)
        {
            cargo.Add(name, weight);
        }
        public void RemoveCargo(string name, int weight)
        {
            cargo.Remove(name, out weight);
        }
        public string GetCargo()
        {
            return string.Join("\n", cargo);
        }
        public override string ToString()
        {
            return string.Join("\n", "Марка - " + label, "Мощность - " + power, "Дата выпуска - " + year, "Грузоподъёмность - " + maxWeight, "Владелец - " + fio);
        }
    }
}

