using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public List<Station> FindStation(string name)
        {
            List<Station> res = new List<Station>();
            foreach(Line line in lines)
            {
                if(line.GetStation(name) != null)
                {
                    res.Add(line.GetStation(name));
                }
            }
            return res;
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
        public Line FindOrCreateLine(string name)
        {
            Line line = FindLine(name);
            if (line == null)
            {
                line = new Line(name);
                this.lines.Add(line);
            }
            return line;
        }
        public Station FindOrCreateStation(string linename, string stationname)
        {
            Line line = FindLine(linename);
            if(line == null)
            {
                return null;
            }
            Station station = line.FindStationByName(stationname);
            if (station == null)
            {
                station = new Station(stationname);
                line.AddStation(station);
            }
            return station;
        }
        public void LoadStationsFromFile(string filename)
        {
            StreamReader sr = new StreamReader("C:\\Users\\SERGE\\OneDrive\\Документы\\GitHub\\f\\HomeWork\\Moscow_Metro_dataset");
            while (!sr.EndOfStream)
            {
                string[] point = sr.ReadLine().Split(";");
                Line line = FindOrCreateLine(point[0]);
                Station station = FindOrCreateStation(point[0], point[1]);
                string[] trans = point[3].Split(",");
                string[] prom;
                foreach(string i in trans)
                {
                    prom = i.Split("-");
                    Line line_trans = FindOrCreateLine(prom[0]);
                    Station station_trans = FindOrCreateStation(prom[0], prom[1]);
                    station.Addtransfers(station_trans);
                }
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
