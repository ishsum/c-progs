using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    class Building
    {
        public int area;
        public int occupants;
        public int floors;
        int areaPerPerson;
        public void Add(int area,int occupants,int floors)
        {
            this.area = area;
            this.occupants = occupants;
            this.floors = floors;
        }
        public int Calculator()
        {
            areaPerPerson = area / occupants;
            return areaPerPerson;
        }
    }
}
