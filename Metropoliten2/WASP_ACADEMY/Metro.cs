using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP_ACADEMY
{
    public class Metro
    {
        private List<Line> lines;
        private string city;

        public Metro(string city)
        {
            this.city = city;
            lines = new List<Line>();
        }
        public string GetCity
        {
            get { return city; }
        }
        public Line FindLine(string name)
        {
            foreach (Line line in lines)
            {
                if (name == line.Name)
                {
                    return line;
                }
            }
            return null;
        }
        public void AddLine(string name, ConsoleColor color)
        {
            Line line = new Line(name, color);
            lines.Add(line);
        }
        public Line RemoveLine(string name)
        {
            Line line = FindLine(name);
            if(line != null)
            {
                lines.Remove(line);
            }
            return line;
        }
        public Station FindStation(string name, string lineName)
        {
            Line line = FindLine(lineName);
            Station station = line.FindStationByName(name);
            return station;
        }
        public List<Station> GetStationList(string name)
        {
            Line line = FindLine(name);
            List<Station> list = line.GetStationList;
            return list;
        }
        public void LoadStationsFromFile(string filename)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
