using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
   public abstract class AbstractFactory
    {
        public abstract IEquiptment CreateMagic();
        public abstract IEquiptment CreateBasic();

    }
}
