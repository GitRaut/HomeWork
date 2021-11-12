using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public interface IStoreItem
    {
        public double Price { get; set; }
        public void DiscountPrice(int percent)
        {
            Price = Price * (100 - percent) / 100;
        }
    }
    class Disk
    {
        protected string name;
        protected string genre;
        protected int burnCount;

        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;

            burnCount = 0;
        }
        public virtual int DiskSize { get; set; }
        public double Price { get; set; }
        public virtual void Burn(params string[] values)
        {
            name = values[0];
            genre = values[1];

            burnCount++;
        }
        public void DiscountPrice(int percent)
        {
            double perc = percent;
            Price = Price * (100 - perc) / 100;
        }
    }
}
