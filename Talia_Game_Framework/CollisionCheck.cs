using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
    public class CollisionCheck
    {
        public bool Collision(Position hero, Position obstacle)
        {

            if (hero.X > 0 || hero.X < obstacle.X - 1 ||   //tjekker for, om hero er nået kanten af verden
                hero.Y > 0 || hero.Y <obstacle.Y - 1 ||  //tjekker for, om hero er nået kanten af verden
                hero == obstacle) //tjekker for, om hero deler position med et objekt (item eller opponent)
            {
                return true;
            }
            return false;
        }
    }
}
