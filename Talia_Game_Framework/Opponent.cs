using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Talia_Game_Framework.Abstractions;
using Talia_Game_Framework.Interfaces;
using Talia_Game_Framework;

namespace Talia_Game_Framework
{
    public class Opponent :Characters, IHitpoints, IDamage
    {

      public Opponent(string name, Position position, int lifeforce, int hitpoints) 
            : base(name, position, lifeforce, hitpoints)
        {
        }

      public int MaxHitPoints()
        {
            Random rnd = new Random();
            return rnd.Next(Hitpoints, Hitpoints + 4);
        }

        public int MinHitPoints()
        {
            Random rnd = new Random();
            return rnd.Next(Hitpoints -6, Hitpoints);
        }

       
        public void ReceiveDamage(int damage)
        {
            Lifeforce -= damage;
            string message = $"({Name}) receives {damage} points of damage, and is down to {Lifeforce} points of remaining lifeForce";
        }

        public override bool Dead()  //override, som giver mulighed for at slette oppponent fra verden (listen), når han er besejret.
        {   
            World.GetInstance().KillOpponents(this);
            return base.Dead();
        }

        public int DealDamage()
        {
            Random rnd = new Random();
            int damage = rnd.Next(MinHitPoints(), MaxHitPoints() + 5);
            string message = $"({Name}) dealt {damage} in damage!";
            return damage;
        }

    }
}
