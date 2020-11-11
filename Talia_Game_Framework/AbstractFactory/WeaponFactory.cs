using System;
using System.Collections.Generic;
using System.Text;
using Talia_Game_Framework;


namespace Talia_Game_Framework
{
   public class WeaponFactory:AbstractFactory
    {
        public override IEquiptment CreateMagic()
        {
            return new Wand("SpellCaster",4,new Position(10,11),true );
        }

        public override IEquiptment CreateBasic()
        {
            return new Sword("Stinger",4,new Position(6,5));
        }
    }
}
