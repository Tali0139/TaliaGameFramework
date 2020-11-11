using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
    public class DefenseFactory : AbstractFactory
    {
        public override IEquiptment CreateMagic()
        {
            return new Ward("Orb of Protection",3,new Position(2,17),true );
        }

        public override IEquiptment CreateBasic()
        {
            return new Shield("Protector",3,new Position(13,4));
        }
    }
}

