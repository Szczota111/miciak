using System;

public class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }

    public void PrzedstawSie()
    {
        Console.WriteLine($"Jestem {Imie} {Nazwisko}.");
    }
}

public class Student : Osoba
{
    public string NrIndeksu { get; set; }

    public void PrzedstawStudenta()
    {
        Console.WriteLine($"Jestem studentem. Mój numer indeksu to {NrIndeksu}.");
    }
}

public class Wykladowca : Osoba
{
    public string TytulNaukowy { get; set; }

    public void PrzedstawWykladowce()
    {
        Console.WriteLine($"Jestem wykładowcą. Mój tytuł naukowy to {TytulNaukowy}.");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student { Imie = "Jan", Nazwisko = "Kowalski", NrIndeksu = "12345" };
        Wykladowca wykladowca = new Wykladowca { Imie = "Anna", Nazwisko = "Nowak", TytulNaukowy = "dr hab." };

        student.PrzedstawSie();
        student.PrzedstawStudenta();

        wykladowca.PrzedstawSie();
        wykladowca.PrzedstawWykladowce();
    }
}
