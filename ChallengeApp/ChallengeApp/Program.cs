string imie = "Ewa";
string plec = "kobieta";
var wiek = 3;
if (plec == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (plec != "kobieta" && wiek < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Pełnoletnia kobieta");
}