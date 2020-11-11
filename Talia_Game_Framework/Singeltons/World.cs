using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Talia_Game_Framework.Abstractions;
using Talia_Game_Framework;

namespace Talia_Game_Framework
{
    public class World
    {
        private Position _worldSize;
        private string _title; 
        private Hero _hero;
        public List<IEquiptment> _worldItems = new List<IEquiptment>();
        public List<Opponent> _opponents = new List<Opponent>();
        public List<Position> obs = new List<Position>();
       
        private static World _instance;

       private World(Position worldSize, string title, Hero hero)
        {
            WorldSize = worldSize;
            Title = title;
            Hero = hero;
        }
        
        private static readonly object _lock = new object();

        public static World GetInstance()
        {
            if (_instance == null)
                {
                    lock (_lock)
                    {

                        if (_instance == null)
                        {
                            _instance = new World(new Position(20, 20), "Game",
                                new Hero("Heroic Hector", new Position(10, 3), 20, 20, Movement.State.North));
                            return _instance;
                        }
                    }
                }
                return _instance;
        }

        public static World GetInstance(World w)
        {
            if (_instance == null)
            {
                lock (_lock)
                {

                    if (_instance == null)
                    {
                        _instance = w;
                        return _instance;
                    }
                }
            }
            return _instance;
        }



        public void RegisterWorldItems(IEquiptment item)
        {
            _worldItems.Add(item);
            Console.WriteLine($"You have placed {item}");
        }
        
        public void DeregisterWorldItems(IEquiptment item)
        {
            _worldItems.Remove(item);

        }

        public void RegisterOpponents(Opponent op)
        {
            _opponents.Add(op);
        }

        public void KillOpponents(Opponent people)
        {
            _opponents.Remove(people);
        }
       

       public void ObstacleList()
        {
            var itemquery = GetInstance()._worldItems                                  // Linq query
                .Select(i => new List<Position>() { i.Placement })
                .SelectMany(Position => Position)
                .Distinct();

            var opponentquery = GetInstance()._opponents
                .Select(i => i.Position);

            obs.AddRange(itemquery);
            obs.AddRange(opponentquery);
            
        }



        public Position WorldSize
        {
            get => _worldSize;
            set =>_worldSize =value;
        } 
        
        public string Title
        {
            get => _title;
            set =>  _title =value;
        }

        public Hero Hero
        {
            get => _hero;
            set => _hero = value;
        }

      
    }
}
