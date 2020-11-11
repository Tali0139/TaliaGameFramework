using System;
using Talia_Game_Framework;

namespace Talia_Game_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
           // World w = World.GetInstance;(new Position(20,20),"The Game",new Hero("Heroic Hector", new Position(10, 10), 25, 30, Movement.State.North));
          
          Opponent o = new Opponent("Azeroth",new Position(8,7),30,34 );
          Opponent p = new Opponent("Beelzebub",new Position(6,12),30,34 );
          Opponent q = new Opponent("Azeroth",new Position(18,7),30,34 );
          Opponent r = new Opponent("Azeroth",new Position(8,17),30,34 );
            
            World.GetInstance().ObstacleList();
         
            DefenseFactory d = new DefenseFactory();
            ItemCreator i = new ItemCreator(d);
            i.PlaceInWorld();
            World.GetInstance().ObstacleList();

            World.GetInstance().RegisterOpponents(o);
            World.GetInstance().RegisterOpponents(p);
            World.GetInstance().RegisterOpponents(q);
            World.GetInstance().RegisterOpponents(r);

            DrawGame dg = new DrawGame();
            dg.Draw();

            World.GetInstance().Hero.ToString();

        }


    }
}
