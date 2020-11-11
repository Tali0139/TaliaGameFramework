using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
    public class Position : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position() //initialiserer x og y værdier til 0, ved hjælp af InitPosition-metoden, så vi ikke risikerer null-object reference exception.
        {
            X = InitPosition().X;
            Y = InitPosition().Y;
        }

        public Position( int X, int Y) //overload af metoden, giver mulighed for at initialisere X og Y metoder med egne værdier.
        {
            this.X = X;
            this.Y = Y;
        }

        public static Position InitPosition() //initialiserer x og y til 0 via position metoden, sådan at vi har en startposition.
        {
            return new Position(0, 0);
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
