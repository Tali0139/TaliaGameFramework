using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
   class Sword:IWeapon
   {
     
       public Sword(string name, int attackpoints, Position placement)
       {
           Name = name;
           Attackpoints = attackpoints;
           Placement = placement;
       }

       public string Name { get; set; }
       public int Attackpoints { get; set; }
       public Position Placement { get; set; }

       public override string ToString()
       {
           string s;
           s = base.ToString() + $" It is a Sword!";
           return s;
       }
    }
}
