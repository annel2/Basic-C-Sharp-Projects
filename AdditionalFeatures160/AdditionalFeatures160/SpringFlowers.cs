using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures160
{
    class SpringFlowers
    {
        //public string Name { get; set; }
        //public string Height { get; set; }
        //public string SunlightNeeds { get; set; }
        //public int WaterAmount { get; set; }
        //public string Notes { get; set; }

        //Chain two constructors together.
        public SpringFlowers(string tulips, string daffodils)
        {
            string nameOfFlowers = tulips + daffodils;
        }

        public SpringFlowers(string tulips) : this(tulips, "")
        {
            string nameOfFlowers = tulips;
        }
       
    }
}
