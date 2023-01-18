string imie = "Ewa";
string plec = "kobieta";
var wiek = 18;
if (plec == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (imie == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
if (plec != "kobieta" && wiek < 18)
{
     Console.WriteLine("Niepełnoletni mężczyzna");
}
if (imie != "Ewa" && plec != "kobieta" && wiek != 33)
{
    Console.WriteLine("Żaden warunek nie jest spełniony");
}