using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowerGame
{
    internal class TowerElements
    {
        // Characters needed for creating a Disc
        public const string DiscChar = "-";
        // Characters needed for Creating a Disc
        public const string TowerBaseChar = "▀";
        public const string TowerRodChar = "│";
        public static readonly char[] RodLabels = { 'A', 'B', 'C' };

        // Fixed space betweet two towers
        public const string SpaceBetweenTowers = "   ";
    }
}
