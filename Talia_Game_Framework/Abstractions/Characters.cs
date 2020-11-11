using System;
using System.Collections.Generic;
using System.Text;
using Talia_Game_Framework.Interfaces;

namespace Talia_Game_Framework.Abstractions
{
    public abstract class Characters 
    {
        public string Name { get; set; }
        public Position Position { get;  set; }
        public int Lifeforce { get; set; }
        public int Hitpoints { get; set; }

        public Characters(string name, Position position, int lifeforce,  int hitpoints)
        {
            Name = name;
            Position = position;
            Lifeforce = lifeforce;
            Hitpoints = hitpoints;
            this.Dead();
        }

        public virtual bool Dead()  //alternativ implementering i opponent-klassen, hvor opponent fjernes fra liste i world, når han dør!
        {
            if (Lifeforce > 0)
            {
                return false;
            }

            Console.WriteLine($"{this.Name} is dead!");
            return true;
        }

      

    }
}
