﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxeheimMUD.Core.Models
{
    internal class PlayerCharacter : IFightable, ICharacter
    {
        private Random _random = new Random();
        public int MaxHealth { get; protected set; }

        public int CurrentHealth
        {
            get
            {
                return _currentHealth;
            }
        }
        private int _currentHealth;
        const int DEFAULT_DAMAGE = 5;
        public string ObjectType { get; protected set; }
        public int Level { get; protected set; }

        public string Name { get; protected set; }
        public int Position { get; protected set; }

        public PlayerCharacter(int level, string name, int position)
        {
            MaxHealth = 10 + (level * 3);
            _currentHealth = MaxHealth;
            Level = level;
            Name = name;
            Position = position;
            ObjectType = "Player Character";
        }

        public void Move(int roomNumber)
        {
            Position = roomNumber;
        }

        public void Attack(IFightable target)
        {
            int damage = _random.Next(Level + DEFAULT_DAMAGE);
            ICharacter character = (ICharacter)target;
            Console.WriteLine($"Attacking {character.Name} for {damage}");
            target.Defend(this, damage);
        }

        public int Defend(IFightable attacker, int damage)
        {
            if (_currentHealth < damage)
            {
                int returnValue = _currentHealth;
                _currentHealth = 0;
                return returnValue;
            }
            else
            {
                _currentHealth -= damage;
                return damage;
            }
        }
    }
}
