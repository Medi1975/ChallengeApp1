// Zadanie Dzień 4
string name = "Ewa";
bool kobieta = true;
int Age = 33;


if (name == "Ewa" && Age > 30)
{
    Console.WriteLine("Ewa, lat 33.");
}

else if (kobieta == true && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}


else if (kobieta == false && Age < 18) 
{
    ; Console.WriteLine("Niepełnoletni mężczyzna.");
}
