using System;
using System.Collections.Generic;
using System.Text;

namespace Talia_Game_Framework
{
    public class KeyStrokes
    {
        public KeyStrokes()
        { 
            KeyInput();
        }

        public ConsoleKey Keystrokes = Console.ReadKey(true).Key;
        

        public int KeyInput()
        {
            switch (Keystrokes)
            {
                case ConsoleKey.UpArrow:
                    return ((int) Movement.UserInput.Forward);
                case ConsoleKey.RightArrow:
                    return ((int)Movement.UserInput.Right);
                case ConsoleKey.LeftArrow:
                    return ((int)Movement.UserInput.Left);
                case ConsoleKey.DownArrow:
                    return ((int)Movement.UserInput.Backward);
                default:
                    return Movement.CurrentState;
            }
        }
    }
}



