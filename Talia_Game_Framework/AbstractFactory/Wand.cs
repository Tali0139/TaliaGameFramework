using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
    class Wand:IWeapon
    {
        public string Name { get; set; }
        public int Attackpoints { get; set; }
        public Position Placement { get; set; }
        public bool Enhanced { get; set; }

        public Wand(string name, int attackpoints, Position placement, bool enhanced)
        {
            Name = name;
            Attackpoints = attackpoints;
            Placement = placement;
            Enhanced = enhanced;
        }
        public override string ToString()
        {
            string s;
            s = base.ToString() + $" It is a Wand, and it is {Enhanced}, that it is enhanced!";
            return s;
        }
    }
}
