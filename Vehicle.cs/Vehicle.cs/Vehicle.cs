using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleQues
{
    class Vehicle
    {
        #region DataFields
        protected String _make;
        protected String _model;
        protected int _year;
        #endregion

        #region Constructors
        public Vehicle() { }

        public Vehicle(String Make, int Year, String Made) { }
        #endregion

        #region Properties
        public String Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public String Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        #endregion

        #region Methods

        public void Accelerate() { }

        public void Decelerate() { }

        public void Drive() { }

        public void Start() { }

        public void Stop() { }
        #endregion

    }
}
