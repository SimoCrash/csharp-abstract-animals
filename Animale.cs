using csharp_abstract_animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animale
{
    public void dormi() => Console.WriteLine("Zzz");
    public abstract void verso();
    public abstract void mangia();
}


