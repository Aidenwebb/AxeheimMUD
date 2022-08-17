using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxeheimMUD.Models
{
    internal class Player
    {
        public int Health { get; protected set; }
        public int Strength { get; protected set; }
        public int Position { get; protected set; }
        public List<PlayerAction> ValidActions = new List<PlayerAction>();

        public Player()
        {
            Health = 100;
            Strength = 1;
            Position = 0;
            _initialiseActions();
        }
        
        public void _initialiseActions()
        {
            ValidActions.Add(new PlayerAction(EntityAction.MoveNorth, 'N'));
            ValidActions.Add(new PlayerAction(EntityAction.MoveEast, 'E'));
            ValidActions.Add(new PlayerAction(EntityAction.MoveSouth, 'S'));
            ValidActions.Add(new PlayerAction(EntityAction.MoveWest, 'W'));
            ValidActions.Add(new PlayerAction(EntityAction.MoveUp, 'U'));
            ValidActions.Add(new PlayerAction(EntityAction.MoveDown, 'D'));
        }

        public EntityAction PromptForAction()
        {
            while (true)
            {
                Console.Write("Choose an action: ");
                char keychar = Console.ReadKey(false).KeyChar;
                if (ValidActions.Any(x => x.KeyBinding.Equals(keychar)))
                {
                    EntityAction entityAction = ValidActions.First(x => x.KeyBinding.Equals(keychar)).EntityAction;
                    Console.WriteLine($" - {entityAction}");
                    return entityAction;
                }
                else
                {
                    Console.Error.WriteLine($" - {keychar.ToString()} is not a valid action");
                }
            }
        }
    }
}
