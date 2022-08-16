using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxeheimMUD.Models
{
    internal class Door
    {
        public Door(Direction direction)
        {
            Direction = direction;
        }

        public Direction Direction { get; }
    }
}
