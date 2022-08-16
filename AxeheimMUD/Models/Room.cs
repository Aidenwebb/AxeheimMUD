using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AxeheimMUD.Models
{
    internal class Room
    {
        private readonly Random random = new Random();
        private List<Door> _doors = new List<Door>();

        public List<Door>? Doors
        {
            get
            {
                return _doors;
            }
            protected set
            {
                _doors = value;
            }
        }

        public Room()
        {
            _generateDoors();
        }

        private void _generateDoors()
        {
            for (int i = 0; i < 10; i++)
            {
                if (random.Next(2) == 1)
                {
                    _doors.Add(new Door((Direction)i));
                }
            }

        }
    }
}
