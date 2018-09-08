using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Player
    {
        public String Name = "Player 1";
        public int LocX = 10;
        public int LocY = 5;

        // checks accessibility of target location and changes location if accessible
        public void Move(Direction _dir, Tile[,] _map)
        {

            if (_dir == Direction.North)
            {
                if (_map[LocX - 1, LocY].Accessible == true)
                {
                    LocX -= 1;
                }
                else
                {
                    Console.WriteLine(_map[LocX, LocY].NoAccessDescription);
                }



            }
            else if (_dir == Direction.East)
            {
                if (_map[LocX, LocY + 1].Accessible == true)
                {
                    LocY += 1;
                }
                else
                {
                    Console.WriteLine(_map[LocX, LocY].NoAccessDescription);
                }

            }
            else if (_dir == Direction.West)
            {
                if (_map[LocX, LocY - 1].Accessible == true)
                {
                    LocY -= 1;
                }
                else
                {
                    Console.WriteLine(_map[LocX, LocY].NoAccessDescription);
                }

            }
            else if (_dir == Direction.South)
            {
                if (_map[LocX + 1, LocY].Accessible == true)
                {
                    LocX += 1;
                }
                else
                {
                    Console.WriteLine(_map[LocX, LocY].NoAccessDescription);
                }
            }
        }
    }
}
