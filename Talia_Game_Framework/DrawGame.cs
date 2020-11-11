using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
    public class DrawGame
    {
        public DrawGame()
        {
            Draw();
        }

        public void Draw()
        {
            Console.Clear();

            for (int k = 1; k <= World.GetInstance().WorldSize.X; k++)
            {
                for (int j = 1; j <= World.GetInstance().WorldSize.Y; j++)
                {
                    if ((k == 1 || k == World.GetInstance().WorldSize.X || j == 1 || j == World.GetInstance().WorldSize.Y))
                        Console.Write("*");
                    else if (World.GetInstance().Hero.Position.X == k && World.GetInstance().Hero.Position.Y == j)
                    {
                        Console.Write("X");
                         if (World.GetInstance()._worldItems != null)
                        {
                            foreach (IEquiptment item in World.GetInstance()._worldItems)
                            {
                                if (item.Placement.X == k && item.Placement.Y == j)

                                {
                                    Console.Write("i");
                                }
                            }
                        }

                         if (World.GetInstance()._opponents != null)
                        {
                            foreach (Opponent opponent in World.GetInstance()._opponents)
                            {
                                if (opponent.Position.X == k && opponent.Position.Y == j)
                                {
                                    Console.Write("O");
                                }
                            }
                        }

                    }
                    
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();

            }
            Console.WriteLine(World.GetInstance().Hero.ToString());
            Update();
        }

        public void Update()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(false);
            }

            ConsoleKeyInfo input = Console.ReadKey();
            Draw();
        }





    }
}
