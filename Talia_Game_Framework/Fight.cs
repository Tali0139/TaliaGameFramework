using System;
using System.Collections.Generic;
using System.Text;
using Talia_Game_Framework.Abstractions;
using Talia_Game_Framework.Interfaces;

namespace Talia_Game_Framework
{
    public class Fight
    {
        private Hero hero = null;
        private Opponent opponent = null;

        public Fight()
        {
            InitiateFight(opponent);
        }

       
        public void InitiateFight(Opponent opponent)
        {
            while (!hero.Dead() && !opponent.Dead())
            {
                hero.DealDamage();
                opponent.ReceiveDamage(hero.DealDamage());
                while (!opponent.Dead())
                {
                    opponent.DealDamage();
                    hero.ReceiveDamage(opponent.DealDamage());
                }
            }

        }
    }
}
