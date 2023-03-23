using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale, INuotante
    {
        public override void mangia() => Console.WriteLine("Crocchette");

        public override void verso() => Console.WriteLine("Abbaiare");

        public void Nuota() => Console.WriteLine("Sto nuotando!!!");
    }
}