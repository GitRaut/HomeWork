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

        public Station(string name, ConsoleColor color, params string[] info)
        {
            this.name = name;
            this.color = color;

            this.transfers = new List<Station>();
        }
        public Station(string name, ConsoleColor color, List<Station> transfers, params string[] info)
        {
            this.name = name;
            this.color = color;
            this.transfers = new List<Station>(transfers);
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
        }
        public List<Station> GetTransferList()
        {
            return transfers;
        }
        public override string ToString()
        {
        }
    }
}
