// Известны два расстояния: одно в километрах, другое – в футах (1 фут 0,305 м). Какое из расстояний меньше?

double km = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
double foot = GetNumberFromUser("Введите число: ", "Ошибка ввода!");

if(km*3278.69 > foot)
Console.WriteLine($"{foot} футов меньше");
else
Console.WriteLine($"{km} км меньше");
///////////////////////////////////////////////////////////////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        else
            Console.WriteLine(errorMessage);
    }
}