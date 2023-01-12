// See https://aka.ms/new-console-template for more information

List<int> listaEnteros = new List<int>();

for (int i = 0; i < 100; i++)
{
    listaEnteros.Add(i);
}


 static void LinQueryForma2(List<int> Enteros)
{

    List<int> Impares = Enteros.Where(x => x%7 == 0).ToList();
    List<int> ImparesI = Impares.Where(x => x % 2 == 0).ToList();
    List<int> ImparesPares = Impares.Where(x => x % 2 != 0).ToList();
    foreach (var i in Impares)
    {
        Console.Write("- "+i+" -");
    }
    Console.WriteLine("next");
    foreach (var i in ImparesI)
    {
        Console.Write("- " + i + " -");

    }
    Console.WriteLine("next");
    foreach (var i in ImparesPares)
    {
        Console.Write("- " + i + " -");
    }
    Console.ReadLine();
}
LinQueryForma2(listaEnteros);
Console.ReadLine();