using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WASP_ACADEMY
{
    public class Station
    {
        protected string name;
        protected ConsoleColor color;
        protected Line line;
        protected bool isWheelChairAccessible;
        protected bool hasParkAndRide;
        protected bool hasNearbyCableCar;
        protected List<Station> transfers;

        public Station(string name, ConsoleColor color, params bool[] info)
        {
            this.name = name;
            this.color = color;
            this.isWheelChairAccessible = info[0];
            this.hasParkAndRide = info[1];
            this.hasNearbyCableCar = info[2];

            this.transfers = new List<Station>();
        }
        public Station(string name, ConsoleColor color, List<Station> transfers, params bool[] info)
        {
            this.name = name;
            this.color = color;
            this.isWheelChairAccessible = info[0];
            this.hasParkAndRide = info[1];
            this.hasNearbyCableCar = info[2];

            this.transfers = new List<Station>(transfers);
        }
        public Station(string name, List<Station> transfers)
        {
            this.name = name;

            this.transfers = new List<Station>(transfers);
        }
        public Station(string name)
        {
            this.name = name;

            this.transfers = new List<Station>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool IsWheelChairAccessible
        {
            get { return isWheelChairAccessible; }
        }
        public bool HasParkAndRide
        {
            get { return hasParkAndRide; }
        }
        public bool HasNearbyCableCar
        {
            get { return hasNearbyCableCar; }
        }
        public string GetLineName
        {
            get { return line.Name; }
            set { name = value; }
        }
        public List<Station> GetTransferList()
        {
            return transfers;
        }
        public void Addtransfers(Station station)
        {
            this.transfers.Add(station);
        }
        public override string ToString()
        {
            return "BOBA";
        }
    }
}
