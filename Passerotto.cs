﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale
    {
        public override void mangia() => Console.WriteLine("Frutta");

        public override void verso() => Console.WriteLine("Cinguettare");
    }
}