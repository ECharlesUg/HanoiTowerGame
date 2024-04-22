using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowerGame
{
    internal class Disc
    {
        private int _size;
        private string _discString;
        public int Size 
        {
            get { return _size; }
            set { _size = value; }  
        }

        public string DiscString 
        { 
            get { return _discString; }
            set { _discString = value; }
        }
        public Disc(int size)
        {
            Size = size;
            DiscString = String.Concat(Enumerable.Repeat(TowerElements.DiscChar, size));
            DiscString += TowerElements.TowerRodChar;
            DiscString += String.Concat(Enumerable.Repeat(TowerElements.DiscChar, size));
        }

        public override string ToString() 
        { 
            return DiscString;
        }
    }
}
