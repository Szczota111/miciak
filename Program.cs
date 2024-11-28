class Program
{
    // program konwertujący temperature z Celsujasza na Fahrenheit, oraz z Fahrenheit na Celsujasza
    static void Main()
    {
        // wybór działania
        Console.WriteLine("Wybierz kierunek konwersji: 1 Celsjusz na Fahrenheit, 2-Fahrenheit na Celsjusz");
        int wybor = int.Parse(Console.ReadLine());

        // wprowadzanie temperatury
        Console.WriteLine("Podaj temperature:");
        double temperatura = double.Parse(Console.ReadLine());

        // wyświetlenie wyniku
        switch (wybor)
        {
            case 1: Console.WriteLine($"Temperatura w Fahrenheit: {CelsiusNaFahrenheit(temperatura)}");
                break;
            case 2: Console.WriteLine($"Temperatura w Celsius: {FahrenheitNaCelsius(temperatura)}");
                break;
            case 3: Console.WriteLine($"Nieprawidłowy wybór");
                break;
        }
    }

    // przeliczanie z Celsius na Fahrenheita
    static double CelsiusNaFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // przeliczanie z Fahrenheita na Celsius
    static double FahrenheitNaCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}