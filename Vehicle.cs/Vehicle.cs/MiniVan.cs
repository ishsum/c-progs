using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.cs
{
    class MiniVan
    {
       
            #region Fields
            bool _cargoNet;
            bool _dualSlidingDoor;
            #endregion

            #region Constructors

            public MiniVan() { }
            public MiniVan(bool dualSlidingDoor, bool CargoNet) : base()
            {
                _cargoNet = CargoNet;
                _dualSlidingDoor = dualSlidingDoor;
            }
            #endregion

            #region Properties

            public bool CargoNet
            {
                get { return _cargoNet; }
                set { _cargoNet = value; }
            }

            public bool DualSlidingDoors
            {
                get { return _dualSlidingDoor; }
                set { _dualSlidingDoor = value; }
            }
            #endregion

            #region Functions

            public bool HasCargoNet()
            {
                return _cargoNet;
            }

            public bool HasDualSlidingDoor()
            {
                return _dualSlidingDoor;
            }


            #endregion

 
    }
}
