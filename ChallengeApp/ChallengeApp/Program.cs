string Imie = "Ewa";
bool Kobieta = true;
var Wiek = 33;

{
    if (Kobieta = true && Wiek < 33)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }

    else if (Kobieta = true && Imie == "Ewa" && Wiek == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }

    else if (Kobieta == false && Wiek < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }

    else
    {
        Console.WriteLine("Inni");
    }
}
