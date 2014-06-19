using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{
    public class Car
    {
        private List<string> _passengers;

        public Car(string pModel, int pDoors)
        {
            Model = pModel;
            Doors = pDoors;
            _passengers = new List<string>();
        }

        public string Model { get; set; }
        public int Doors { get; set; }

        public int Wheels
        {
            get { return 4; }
        }


        public List<string> Passengers
        {
            get
            {
                return _passengers;
            }
        }
    }
}
