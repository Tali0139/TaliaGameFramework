using System;

namespace Talia_Game_Framework
{
    public interface IDefense :IEquiptment
    {
        int Defensepoints { get; set; }
     
        //public override string ToString()
        //{
        //    string s = $"{Name} has {Defensepoints} points of defensive power!";
        //    return s;
        //}
    }
}