using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxeheimMUD.Core.Models
{
    internal class PlayerCharacter : IFightable, ICharacter
    {
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
        public int Level { get; protected set; }

        public string Name { get; protected set; }
        public int Position { get; protected set; }

        public PlayerCharacter(int level, string name, int position)
        {
            MaxHealth = 10 + (level * 2);
            _currentHealth = MaxHealth;
            Level = level;
            Name = name;
            Position = position;
        }

        public void Move(int roomNumber)
        {
            Position = roomNumber;
        }

        public void Attack(IFightable target)
        {
            int damage = Level + DEFAULT_DAMAGE;
            target.Defend(this, damage);
        }

        public void Defend(IFightable attacker, int damage)
        {
            _currentHealth -= damage;
        }
    }
}
