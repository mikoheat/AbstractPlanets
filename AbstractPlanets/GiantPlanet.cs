using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// The Author's name: Taeho Kim
/// Author’s  student number: 300914207
/// Date last Modified: 2017/07/27
/// Program description: GiantPlanet class (_type, GiantPlanet, HasMoons(), HasRings()).
/// Revision History: 2017/07/24 - Make a field and methods.
///                   2017/07/27 - Revise if condition ( case-insensitive )
/// </summary>
namespace AbstractPlanets
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //Fields

        private string _type;

        //Methods

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            //This condition makes any string you're going to input case-insensitive.
            if (type.ToUpper() == "GAS" || type.ToUpper() == "ICE")
            {
                this._type = type;
            }
            else
            {
                Console.WriteLine("Invalid type.");
                return;
            }
        }

        public bool HasMoons()
        {
            if (MoonCount >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if(RingCount>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
