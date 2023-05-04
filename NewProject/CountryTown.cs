using System;
using NewOneHomeWork;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewProject
{
   public class CountryTown : FirstNameAdress
   {
        public string Country { get; set; }
        public string Town { get; set; }
        public void GetGountry(string country, string town)
        {
            Country = country;
            country = "Georgia";
            Town = town;
            town = "Tbilisi";
        }
   }
}
