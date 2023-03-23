using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale, INuotante
    {
        public override void mangia() => Console.WriteLine("pesci");

        public override void verso() => Console.WriteLine("fischiare");

        public void Nuota() => Console.WriteLine("Sto nuotando!!!");
    }
}