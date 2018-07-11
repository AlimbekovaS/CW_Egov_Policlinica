using ConsoleApplication1.LIB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;

namespace ConsoleApplication1.LIB.Model
{
    class Pation : IPation
    {
        public DateTime DoB { get; set; }


        public string FullName { get; set; }

        public string IIN { get; set; }
        public int PationID { get; set; }

        public Gender Sex { get; set; }
        public int Age()
        {
            return (DateTime.Now.Year - DoB.Year);
        }
    }
}
