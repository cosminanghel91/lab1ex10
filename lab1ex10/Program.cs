/*
* Scrieti un program care va afisa suma cifrelor unui numar intreg citit de la tastatura
*/

Console.WriteLine("Introduceti numarul pentru care doriti sa calculam suma cifrelor:");
int numar = int.Parse(Console.ReadLine());

int sum = 0, reminder;

if
    (numar < 100)
{
    while (numar > 0)
    {
        reminder = numar % 10;
        sum = sum + reminder;
        numar = numar / 10;

    }
    Console.WriteLine("Suma cifrelor este:" + sum);
}
else
{
    Console.WriteLine("Numarul are mai mult de 2 cifre");
}