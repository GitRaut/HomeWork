using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP_ACADEMY
{
    public class Station
    {
        string name;
        Line line;
        bool isWheelChairAccessible;
        bool hasParkAndRide;
        bool hasNearbyCableCar;
        List<Station> transfers;

        public Station(string name)
        {
            this.name = name;

            this.transfers = new List<Station>();
        }
        public Station(string name, List<Station> transfers)
        {
            this.name = name;
            this.transfers = transfers;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public bool IsWheelChairAccessible()
        {
            return isWheelChairAccessible;
        }
        public bool HasParkAndRide()
        {
            return hasParkAndRide;
        }
        public bool HasNearbyCableCar()
        {
            return hasNearbyCableCar;
        }
        public string GetLineName()
        {
            return line.GetName();
        }
        public List<Station> GetTransferList()
        {
            return transfers;
        }
    }
}
