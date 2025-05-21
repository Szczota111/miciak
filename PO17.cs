using System;

public class Procesor
{
    public string Model { get; set; }
    public double Taktowanie { get; set; }
}

public class PamiecRAM
{
    public int Pojemnosc { get; set; }
}

public class DyskTwardy
{
    public int Pojemnosc { get; set; }
    public string Typ { get; set; }
}

public class Komputer
{
    public Procesor Procesor { get; set; }
    public PamiecRAM PamiecRAM { get; set; }
    public DyskTwardy DyskTwardy { get; set; }

    public Komputer(Procesor procesor, PamiecRAM pamiecRAM, DyskTwardy dyskTwardy)
    {
        Procesor = procesor;
        PamiecRAM = pamiecRAM;
        DyskTwardy = dyskTwardy;
    }

    public void PokazSpecyfikacje()
    {
        Console.WriteLine($"Procesor: {Procesor.Model}, {Procesor.Taktowanie} GHz");
        Console.WriteLine($"Pamięć RAM: {PamiecRAM.Pojemnosc} GB");
        Console.WriteLine($"Dysk: {DyskTwardy.Pojemnosc} GB, Typ: {DyskTwardy.Typ}");
    }
}

class Program
{
    static void Main()
    {
        Komputer komputer = new Komputer(
            new Procesor { Model = "Intel i7", Taktowanie = 3.4 },
            new PamiecRAM { Pojemnosc = 16 },
            new DyskTwardy { Pojemnosc = 512, Typ = "SSD" }
        );

        komputer.PokazSpecyfikacje();
    }
}
