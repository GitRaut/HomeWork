using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class PassengerCar : Car
    {
        int countOfPassengers;
        Dictionary<string, int> repairBook;

        public PassengerCar(string label, double power, int year, int countOfPassengers) : base(label, power, year)
        {
            this.countOfPassengers = countOfPassengers;
            repairBook = new Dictionary<string, int>();
        }
        public void AddDetailsInRepairBook(string detail, int year)
        {
            repairBook.Add(detail, year);
        }
        public int GetDetail(string detail)
        {
            foreach (KeyValuePair<string, int> details in repairBook)
            {
                if (detail == details.Key)
                {
                    return details.Value;
                }
            }
            return 0;
        }
        public string GetRepairBook()
        {
            return string.Join("\n", repairBook);
        }
        public override string ToString()
        {
            return string.Join("\n", "Марка - " + label, "Мощность - " + power, "Дата выпуска - " + year, "Кол-во пассажиров - " + countOfPassengers);
        }
    }
}

