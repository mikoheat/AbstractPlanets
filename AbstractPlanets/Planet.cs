using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// The Author's name: Taeho Kim
/// Author’s  student number: 300914207
/// Date last Modified: 2017/07/24
/// Program description: Planet class.
/// Revision History: 2017/07/24 - Make fields, properties, and methods.
/// </summary>
namespace AbstractPlanets
{
    abstract class Planet
    {
        //Fields

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //Properties

        //This is readonly property.
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        //This is readonly property.
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        //This is readonly property.
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RoatationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //Methods

        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nDiameter: {1}\nMass: {2}", Name, Diameter, Mass);
        }
    }
}
