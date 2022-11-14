// Даны два действительных числа x и у. Вычислить их сумму, разность, произведение и частное.

Console.Write("Введите число x и нажмите Enter:  ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число y и нажмите Enter:  ");
double y = Convert.ToDouble(Console.ReadLine());

double sum = x + y;
double odds = x - y;
double product = x * y;
double quotinent = x / y;

Console.WriteLine($"x = {x}, y = {y}");
Console.WriteLine($"sum = {sum}, odds = {odds}, product = {product}, quotinent = {quotinent}");
