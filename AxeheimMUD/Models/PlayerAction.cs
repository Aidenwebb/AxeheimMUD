using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxeheimMUD.Models
{
    internal class PlayerAction
    {
        public EntityAction EntityAction { get; set; }
        public char KeyBinding { get; set; }

        public PlayerAction(EntityAction entityAction, char keyBinding)
        {
            EntityAction = entityAction;
            KeyBinding = keyBinding;
        }
    }

    internal enum EntityAction
    {
        MoveNorth,
        MoveEast,
        MoveSouth,
        MoveWest,
        MoveUp,
        MoveDown,
    }
}
