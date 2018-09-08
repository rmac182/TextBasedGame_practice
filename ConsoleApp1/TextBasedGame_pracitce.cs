using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    enum Direction
    { North ,
        South ,
        East ,
        West
    };
   

   
   


    class Program
    {
        //prints a symbol for a single map tile based on it's accessibility and whether or not it is occupied by the player
        public static void PrintTile(Tile _tile , Player _player)
        {
            if (_tile.Accessible == true)
            {
                if (_tile.x == _player.LocX && _tile.y == _player.LocY)
                {
                    Console.Write(" * ");
                }
                else
                {
                    Console.Write("   ");
                }
            
            }else if(_tile.Accessible == false)
            {
                Console.Write("|x|");
            }
            
        }
        // prints all of the map's tile symbols in grid form. will only be shown each turn if player's inventory contains the map item. 
        public static void PrintMap(int _width , int _height , Tile[,] _map , Player _player )
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    _map[x, y].x = x;
                    _map[x, y].y = y;
                    PrintTile(_map[x, y], _player);
                }
                Console.WriteLine();
            }
        }
        //fills a 2d array of tiles and sets accessibility of each at game start.
        public static void CreateMap(int _width, int _height, Tile[,] _map)
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    _map[x, y] = new Tile();


                    if (x == 1)
                    {
                        if (y == 3 || y == 6 || y == 7 || y == 8)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                    else if (x == 2)
                    {
                        if (y == 1 || y == 4 || y == 6 || y == 8)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                    else if (x == 3)
                    {
                        if ( y == 1 || y == 2 || y == 3 || y == 4 || y == 5 || y == 6 || y == 8)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                    else if (x == 4)
                    {
                        if (y == 8)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                    else if (x == 5)
                    {
                        if (y == 5 || y == 6 || y == 8)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                    else if (x == 6)
                    {
                        if (y == 1 || y == 2 || y == 5 || y == 6 || y == 7 || y == 8)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                    else if (x == 7)
                    {
                        if (y == 1 || y == 5 || y == 6 || y == 8)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                    else if (x == 8)
                    {
                        if (y == 1 || y == 3 || y == 5 || y == 6)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                    else if (x == 9)
                    {
                        if (y == 1 || y == 2 || y == 3 || y == 4 || y == 5)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                    else if (x == 10)
                    {
                        if (y == 5 || y == 6)
                        {
                            _map[x, y].Accessible = true;
                        }
                    }
                }
            }
        }
        // asks player for input for a direction to move. runs the move method of player 
        public static void GetPlayerDirection(Player _player , Tile[,] _map)
        {
        start:
            string direction;
            Console.WriteLine("Move: N,S,E,W");
            direction = Convert.ToString(Console.ReadLine());

            if (direction == "n")
            {
                _player.Move(Direction.North , _map[_player.LocX , _player.LocY] );
            }
            else if (direction == "s")
            {
                _player.Move(Direction.South);
            }
            else if (direction == "e")
            {
                _player.Move(Direction.East);
            }
            else if (direction == "w")
            {
                _player.Move(Direction.West);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
                goto start;
            }
        }
        static void Main(string[] args)
        {
            int width = 12;
            int height = 12;
            Tile[,] map = new Tile[width, height];
            Player player = new Player();
            
            CreateMap(width, height, map);
            PrintMap(width, height, map, player);
            GetPlayerDirection(player , map);

            
            
            
                
            

            
            









            Console.ReadKey();

            
        }
    }
}
