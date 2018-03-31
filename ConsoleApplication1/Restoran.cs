using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Restoran
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Human> Owners { get; set; }
        public Kitchen Kitchen { get; set; }
        public List<Halle> Halles { get; set; }
        public Bar Bar { get; set; }
    }
}
