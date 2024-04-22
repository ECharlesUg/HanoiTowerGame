using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowerGame
{
    internal class Tower
    {
        private int _height;
        private string _towerBase;
        private string _label;
        private Stack<int> _discs;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        
        public string TowerBase
        {
            get { return _towerBase; }
            set { _towerBase = value; }
        }

        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }

       
        public Stack<int> Discs
        {
            get { return _discs; }
            set { _discs = value; }
        }
        public Tower(Stack<int> inputTower, int height, string label)
        {
            Height = height;
            Label = label;
            TowerBase = String.Concat(Enumerable.Repeat(TowerElements.TowerBaseChar, Height*4));
            Discs = inputTower;
        }
        public string GetDisc(int level)
        {
            String output = String.Empty;
            if (Discs.Count == 0)
            {
                output += String.Concat(Enumerable.Repeat(" ", Height * 2));
                output += TowerElements.TowerRodChar;
                output += String.Concat(Enumerable.Repeat(" ", Height * 2));
            }
            else
            {
                if (level > Discs.Count)
                {
                    // fill the tower with spaces to show empty space
                    output += String.Concat(Enumerable.Repeat(" ", Height * 2));
                    output += TowerElements.TowerRodChar;
                    output += String.Concat(Enumerable.Repeat(" ", Height * 2));
                }
                else
                {
                    // if there are disks
                    Disc d = new Disc(Discs.ElementAt(Discs.Count - level));
                    output += String.Concat(Enumerable.Repeat(" ", Height * 2 - d.Size));
                    output += d.ToString();
                    output += String.Concat(Enumerable.Repeat(" ", Height * 2 - d.Size));
                }
            }
            return output;
        }
        public string GetBase()
        {
            return String.Concat(Enumerable.Repeat(TowerElements.TowerBaseChar, Height * 4 + 1));
        }
        public string GetLabel()
        {

            string output = String.Concat(Enumerable.Repeat(" ", Height * 2));
            output += Label;
            output += String.Concat(Enumerable.Repeat(" ", Height * 2));
            return output;
        }
        public override string ToString()
        {
            string output = String.Empty;
            for (int i = Height; i > 0; i--)
            {
                output += GetDisc(i) + "\n";
            }
            output += GetBase() +"\n";
            output += GetLabel() + "\n";
            return output;
        }
    }
}
