using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Tile
    {
        public string Description = "This is a tile.";
        public string NoAccessDescription = "You cannot go this way.";
        public bool Accessible = false;
        public int x;
        public int y;


    }
}
