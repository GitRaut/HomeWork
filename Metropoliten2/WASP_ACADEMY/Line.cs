using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP_ACADEMY
{
    public class Line
    {
        protected List<Station> stations;
        protected string name;
        protected ConsoleColor color;

        public Line(string name, ConsoleColor color)
        {
            this.name = name;
            this.color = color;

            this.stations = new List<Station>();
        }
        public Station GetStation(string name)
        {
            foreach(Station station in stations)
            {
                if (name == station.Name)
                {
                    return station;
                }
            }
            return null;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }
        public void AddStation(string name, ConsoleColor color)
        {
            Station station = new Station(name, color);
            stations.Add(station);
        }
        public void AddStation(string name, ConsoleColor color, List<Station> transfers)
        {
            Station station = new Station(name, color, transfers);
            stations.Add(station);
        }
        public Station RemoveStation(string name)
        {
            Station station = GetStation(name);
            if (station != null)
            {
                stations.Remove(station);
            }
            return station;
        }
        public Station FindStationByName(string name)
        {
            foreach (Station station in stations)
            {
                if (name == station.Name)
                {
                    return station;
                }
            }
            return null;
        }
        public List<Station> GetStationList()
        {
            return stations;
        }
        public virtual void PrintLine()
        {

        }
    }
}
