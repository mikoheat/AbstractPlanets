using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// The Author's name: Taeho Kim
/// Author’s  student number: 300914207
/// Date last Modified: 2017/07/24
/// Program description: TerrestrialPlanet class (_oxygen, Habitable(), HasMoons(), TerrestrialPlanet).
/// Revision History: 2017/07/24 - Make a field and methods.
/// </summary>
namespace AbstractPlanets
{
    class TerrestrialPlanet : Planet, IHabitable, IHasMoons
    {
        //Fields

        private bool _oxygen;

        //Methods

        public bool Habitable()
        {
            if(_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasMoons()
        {
            if(MoonCount>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
    }
}
