using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;
using Talia_Game_Framework;
using Talia_Game_Framework.Abstractions;
using Talia_Game_Framework.Interfaces;

namespace Talia_Game_Framework
{
    public class Hero : Characters, IHitpoints, IDamage
    {
        private KeyStrokes input = new KeyStrokes();
        public Movement move = new Movement();
        
        public Hero(string name, Position position, int lifeforce, int hitpoints, Movement.State currentDirection) 
            : base(name, position, lifeforce, hitpoints)
        {
            
            this.MaxHitPoints();
            this.MinHitPoints();
            
        }

        public void walk()
        {
            move.Action(input.KeyInput());
        }

        public int MaxHitPoints()
        {
            int weaponHitpoints = 0;
            Random rnd = new Random();
            foreach (IWeapon weapon in BackPack)
            {
                if ((Wand)weapon ==weapon)
                {
                    weaponHitpoints += weapon.Attackpoints+1;
                }
                else
                {
                    weaponHitpoints += weapon.Attackpoints;
                }
            }
            int points = weaponHitpoints + Hitpoints;
            return rnd.Next(points, points + 5);
        }

        public int MinHitPoints()
        {
            Random rnd = new Random();
            return rnd.Next(MaxHitPoints() -20, MaxHitPoints()- 10);    //bruger maxhitpoints og er derfor også påvirket af, hvormange vågen man har
        }
        
      public int DealDamage()
        {
            Random rnd = new Random();
            int damage = rnd.Next(MinHitPoints(), MaxHitPoints() + 5);
            string message = $"The Hero: {Name} has dealt {damage} in damage!";
            return damage;
        }

        public void ReceiveDamage(int damage)
        {
            int armor = 0;
            foreach (IDefense protection in BackPack)
            {
                if ((Ward)protection==protection)
                {
                    armor += protection.Defensepoints + 1;
                }
                else
                {
                    armor += protection.Defensepoints;
                }
            }
            Lifeforce += armor;
            Lifeforce -= damage;
            Console.WriteLine($" The Hero: {Name} receives {damage} points of damage, and is down to {Lifeforce} points of remaining lifeForce");

        }

        public List<IEquiptment> BackPack = new List<IEquiptment>();          //Generic list of objects holding both weapons and defenses

        public void PickupItem(IEquiptment item)
        {
            BackPack.Add(item);
            Console.WriteLine($"You have found {item} You have placed it in your BackPack!");
        }

        public override string ToString()
        {
            return $"The Hero: {Name} has {Lifeforce} points of lifeforce! Which can be increased by picking up items! " +
                   $"\nThe hero has {Hitpoints} points of attackpower! This can also be increased by picking up items! " +
                   $"\nThe hero's current position is: {Position}, and the hero is moving {move}";
        }
    }
}


    