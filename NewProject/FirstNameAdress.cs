using NewOneHomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    public class FirstNameAdress
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public void GetAdress(string name, string adress)
        {
            Name = name;
            name = "Nata";
            Adress = adress;
            adress = "Libani tyrn 1 , Fl.60";
        }
    }    
}
