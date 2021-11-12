using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class Store
    {
        private string storeName;
        private string address;
        public List<Audio> audios;
        public List<DVD> dvds;

        public Store(string storeName, string address)
        {
            this.storeName = storeName;
            this.address = address;

            audios = new List<Audio>();
            dvds = new List<DVD>();
        }

        public static Store operator +(Store store, Audio value)
        {
            store.audios.Add(value);
            return store;
        } 
        public static Store operator -(Store store, Audio value)
        {
            store.audios.Remove(value);
            return store;
        }
        public static Store operator +(Store store, DVD value)
        {
            store.dvds.Add(value);
            return store;
        }
        public static Store operator -(Store store, DVD value)
        {
            store.dvds.Remove(value);
            return store;
        }
        public override string ToString()
        {
            string au = string.Join("\n\n", audios);
            string dv = string.Join("\n\n", dvds);
            return string.Join("\n\n", "Store's name:\n" + storeName,"Address:\n" + address + "\n__________", "Audio Disks:\n" + au + "\n__________", "DVD Disks:\n" + dv + "\n__________");
        }
        public List<Audio> GetAudio { get { return audios; } }
        public List<DVD> GetDvds { get { return dvds; } }
    }
}
