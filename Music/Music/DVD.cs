using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class DVD : Disk
    {
        private string producer;
        private string filmCompany;
        private int minutesCount;

        public DVD(string producer, string filmCompany, int minutesCount, string name, string genre) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
        }

        public override int DiskSize { get { return (minutesCount / 64) * 2; } }
        public override void Burn(params string[] values)
        {
            name = values[0];
            genre = values[1];
            producer = values[2];
            filmCompany = values[3];
            int.TryParse(values[4], out minutesCount);
            burnCount++;
        }
        public override string ToString()
        {
            return string.Join("\n", "Name - " + name, "Genre - " + genre, "Producer - " + producer, "Film Company - " + filmCompany, "Minutes count - " + minutesCount, "Count of burns - " + burnCount);
        }
        public string GetName { get { return name; } }
        public int GetSize { get { return DiskSize; } }
    }
}
