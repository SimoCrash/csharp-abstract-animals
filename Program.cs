using csharp_abstract_animals;

//Animale cane = new Cane();
//Console.WriteLine(cane.dormi());
//Console.WriteLine(cane.mangia());
//Console.WriteLine(cane.verso());

Animale cane = new Cane();
Console.WriteLine("CANE");
Console.WriteLine("Verso del cane mentre dorme ");
cane.dormi();
Console.WriteLine("Il verso del cane è ");
cane.verso();
Console.WriteLine("Il cane mangia ");
cane.mangia();
Console.WriteLine("__________________________________________________");


Animale aquila = new Aquila();
Console.WriteLine("AQUILA");
Console.WriteLine("Verso dell'aquila mentre dorme ");
aquila.dormi();
Console.WriteLine("Il verso dell'aquila è ");
aquila.verso();
Console.WriteLine("L'aquila mangia ");
aquila.mangia();
Console.WriteLine("__________________________________________________");


Animale delfino = new Delfino();
Console.WriteLine("DELFINO");




