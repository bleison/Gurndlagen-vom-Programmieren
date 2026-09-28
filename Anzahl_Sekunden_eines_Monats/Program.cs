Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage");
Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
string tagesanzahl = Console.ReadLine();
List<int> gueltigeTage = new List<int>() { 28, 29, 30, 31 };
if (int.TryParse(tagesanzahl, out int tage) && gueltigeTage.Contains(tage))
{
    int sekunden = tage * 86400;
    Console.WriteLine($"Ihre Eingabe {tage} ist gültig.");
    Console.WriteLine($"Ein Monat mit {tage} Tagen hat {sekunden} Sekunden.");
}
else
{
    Console.WriteLine("Eingabefehler oder ungültige Tagesanzahl. Bitte geben Sie 28, 29, 30 oder 31 ein.");
}
