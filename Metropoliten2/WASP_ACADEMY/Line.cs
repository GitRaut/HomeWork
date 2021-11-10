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
            foreach(Station station in this.stations)
            {
                if (name == station.GetName())
                {
                    return station;
                }
            }
            return null;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public ConsoleColor GetColor()
        {
            return color;
        }
        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }
        public void AddStation(string name, ConsoleColor color, params string[] info)
        {
            Station station = new Station(name, color, info);
            stations.Add(station);
        }
        public void AddStation(string name, ConsoleColor color, List<Station> transfers, params string[] info)
        {
            Station station = new Station(name, color, transfers, info);
            stations.Add(station);
        }
        public Station RemoveStation(string name)
        {
            Station station = this.GetStation(name);
            if (station != null)
            {
                stations.Remove(station);
            }
            return station;
        }
        public Station FindStationByName(string name)
        {
            foreach (Station station in this.stations)
            {
                if (name == station.GetName())
                {
                    return station;
                }
            }
            return null;
        }
        public List<Station> GetStationList()
        {
            return this.stations;
        }
    }
}
