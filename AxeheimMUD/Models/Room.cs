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

        public string DescribeRoom()
        {
            string returnstring = "";
            if (_doors.Count == 1)
            {
                returnstring = $"There is 1 door. Its direction is {_doors[0].Direction}";
            }
            else if (_doors.Count == 0)
            {
                returnstring = $"There are no doors. How did you get in here?";
            }
            else
            {
                returnstring = $"There are {_doors.Count} doors. Their directions are: ";
            }

            foreach (Door door in _doors)
            {
                returnstring += $"[{door.Direction}], ";
            }

            return returnstring;
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
