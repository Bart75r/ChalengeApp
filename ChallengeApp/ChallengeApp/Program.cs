string imie = "Ewa";
string plec = "kobieta";
var wiek = 33;
if (plec == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}
if (imie == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("To nie jest Ewa w wieku 33 lat");
}
if (plec != "kobieta" && wiek < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Pełnoletnia kobieta");
}