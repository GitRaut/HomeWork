using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class Audio : Disk
    {
        private string artist;
        private string recordingStudio;
        private int songsNumber;

        public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
        }
        public override int DiskSize { get { return songsNumber * 8; } }
        public override void Burn(params string[] values)
        {
            name = values[0];
            genre = values[1];
            artist = values[2];
            recordingStudio = values[3];
            int.TryParse(values[4], out songsNumber);
            burnCount++;
        }
        public override string ToString()
        {
            return string.Join("\n", "Name - " + name, "Genre - " + genre, "Artist - " + artist, "Recording Studio - " + recordingStudio, "Number of songs - " + songsNumber, "Count of burns - " + burnCount);
        }
        public string GetName { get { return name; } }
        public int GetSize { get { return DiskSize; } }
    }
}
