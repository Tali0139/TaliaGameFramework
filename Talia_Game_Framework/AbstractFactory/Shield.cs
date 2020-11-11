using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
    public class Shield : IDefense
    {
        public Shield(string name, int defensepoints, Position position)
        {
            Name = name;
            Defensepoints = defensepoints;
            Placement = position;
        }
        public string Name { get; set; }
        public Position Placement { get; set; }
        public int Defensepoints { get; set; }
       
        public override string ToString()
        {
            string s;
            s = base.ToString() + $" It is a Shield!";
            return s;
        }
    }
}
