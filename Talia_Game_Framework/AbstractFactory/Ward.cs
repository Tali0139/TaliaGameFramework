using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
    class Ward: IDefense
    {
        public string Name { get; set; }
        public Position Placement { get; set; }
        public int Defensepoints { get; set; }
      public bool Enhanced { get; set; }

        public Ward(string name, int defensepoints, Position position, bool enhanced)
        {
            Name = name;
            Defensepoints = defensepoints;
            Placement = position;
            Enhanced = enhanced;
        }

        public override string ToString()
        {
            string s;
            s= base.ToString() + $" It is a Ward, and it is {Enhanced}, that it is enhanced!";
            return s;
        }
    }

}
