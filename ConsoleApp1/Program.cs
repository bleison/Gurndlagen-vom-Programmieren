Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahelen!");
Console.WriteLine("Zahl 1:");
string eingabe1 = Console.ReadLine(); 
Console.WriteLine("Zahl 2:");
string eingabe2 = Console.ReadLine();
int zahl1 = Convert.ToInt32(eingabe1);
int zahl2 = Convert.ToInt32(eingabe2);

Console.Write(zahl1 + zahl2);
