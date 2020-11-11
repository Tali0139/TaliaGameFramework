using System;
using System.Collections.Generic;
using System.Text;
using Talia_Game_Framework.Abstractions;

namespace Talia_Game_Framework.Interfaces
{
   public interface IDamage
   {
       int DealDamage();
        

        void ReceiveDamage(int damage);
    }
}
