using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using Talia_Game_Framework;


namespace Talia_Game_Framework
{
    public class Movement
    {
        //StateMachine Pattern...
        private static int _currentState = 1;
        private CollisionCheck _checkc = new CollisionCheck();
        

        public Movement() { }

        public enum State
        {
            North, South, East, West
        }

        public enum UserInput
        {
            Forward, Right, Left, Backward
        }

        public static int CurrentState
        {
            get => _currentState;
            set => _currentState = value;
        }

        private int[,] states = new int[4, 4]
        {
            {0,1,2,3}, //Når du skal fremad
            {2,3,1,0}, //Når du skal til højre
            {3,2,0,1}, //Når du skal til venstre
            {1,0,3,2} //Når du skal baglæns
        };


        public int Action(int input)
        {
            World.GetInstance().ObstacleList();
            foreach (var item in World.GetInstance().obs)   //List of position for both opponents, and Iequiptment (iWeapon, iDefense)
                while (!_checkc.Collision(World.GetInstance().Hero.Position, item))
            {
                CurrentState = states[CurrentState, input];
                return CurrentState; //opdateret currentstate efter bevægelse
            }

            {
                foreach (var item in World.GetInstance()._worldItems)
                {
                    if (_checkc.Collision(World.GetInstance().Hero.Position,item.Placement))
                    {
                        World.GetInstance().Hero.PickupItem(item); //Kalder en generic pickup metode.
                        World.GetInstance().DeregisterWorldItems(item);  //Fjerner item fra _world, så den ikke bliver på listen.
                     }
                }

                foreach (var opponent in World.GetInstance()._opponents)
                {
                    if (_checkc.Collision(World.GetInstance().Hero.Position, opponent.Position))
                    {
                        Fight f = new Fight();
                        Console.WriteLine("You have found an enemy! Fight to the death!");
                        f.InitiateFight(opponent);
                    }
                }

                Console.WriteLine("You have reached the end of the world and can go no further! Turn around!");
                return CurrentState; //currentstate før bevægelse.
            }

        }

        public override string ToString()
        {
            return $"{CurrentState}";
        }
    }
}
