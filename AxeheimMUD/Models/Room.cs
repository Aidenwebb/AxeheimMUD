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
        protected static int _roomCounter { get; private set; }
        public int RoomID { get; }
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

        public string DescribeExits()
        {
            string returnstring = string.Empty;
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

                foreach (Door door in _doors)
                {
                    returnstring += $"[{door.Direction}], ";
                }
            }


            return returnstring;
        }

        public string DescribeRoom()
        {
            string returnstring = string.Empty;

            returnstring = $@"{DescribeExits()}";

            return returnstring;
        }

        public Room()
        {
            _roomCounter++;
            RoomID = _roomCounter;
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
