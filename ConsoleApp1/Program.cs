using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tile
    {
        public  string Description = "This is a tile.";
        public  bool Occupied = false;
        public  bool Accesible = false;

    }

    class Player
    {
        public String Name = "Player 1";
        public Tile Location;
    }



    class Program
    {
        public static void PrintMap(Tile _tile)
        {
            if (_tile.Accesible == true)
            {
                Console.Write("   ");

            }else if(_tile.Accesible == false)
            {
                if(_tile.Occupied == true)
                {
                    Console.Write(" * ");
                }
                else
                {
                    Console.Write("|||");
                }
            }
        }
        static void Main(string[] args)
        {
            int width = 12;
            int height = 12;
            Tile[,] map = new Tile[width, height];
            Console.WriteLine(map[0, 1].Accesible);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (x ==1)
                    {
                        if(y == 3 || y == 6 || y == 7)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 2)
                    {
                        if (y == 0 || y == 4 || y == 6 || y == 8)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 3)
                    {
                        if (y == 0 || y == 1 || y == 2 || y == 3 || y == 4 || y == 5 || y == 6 || y == 8)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 4)
                    {
                        if (y == 8)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 5)
                    {
                        if (y == 5 || y == 6 || y == 8)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 6)
                    {
                        if (y == 1 || y == 2 || y == 5 || y == 6 || y == 7 || y == 8)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 7)
                    {
                        if (y == 1 || y == 5  || y == 6 || y == 8)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 8)
                    {
                        if (y == 1 || y == 3 || y == 5 || y == 6)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 9)
                    {
                        if (y == 1 || y == 2 || y == 3 || y == 4 || y == 5)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 10)
                    {
                        if (y == 5)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    else if (x == 11)
                    {
                        if (y == 5 || y ==6)
                        {
                            map[x, y].Accesible = true;
                        }
                    }
                    
                }
            }

            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    PrintMap(map[x,y]);
                }
            }

            Console.ReadKey();
        }
    }
}
