using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale
    {
        public override void mangia() => Console.WriteLine("Mammiferi");

        public override void verso() => Console.WriteLine("Stridare");
    }
}