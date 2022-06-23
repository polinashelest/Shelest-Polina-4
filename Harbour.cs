using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab4.Program;

namespace Lab4
{
    class Harbour
    {
        private List<Ship> _listOfShips = new List<Ship>();

        public void AddShip(Ship ship)
        {
            _listOfShips.Add(ship);

        }
        public int GetActionsByTypeMilitary<T>() where T : MilitaryShip
        {
            return _listOfShips.OfType<T>().Sum(x => x.TimesOfMilitaryAction);
        }

        public int GetActionsByTypePassenger<T>() where T : PassengerShip
        {
            return _listOfShips.OfType<T>().Sum(x => x.TimesOfVoyages);
        }
    }
}
