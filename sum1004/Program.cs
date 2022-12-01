// Даны три действительных числа. 
// Возвести в квадрат те из них, значения которых неотрицательны, и в четвертую степень – отрицательные.

int[] array = GetArray(3);
GetPow(array);

///////////////////////////////////////////////////////////////////////////////////////////
int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-99, 99);
    }
    return arr;
}

void GetPow(int[] arr)
{
    int res;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            res = (int)Math.Pow(arr[i], 2);
            Console.WriteLine($"{arr[i]} ^ 2 = {res}");
        }
        else
        {
            res = (int)Math.Pow(arr[i], 4);
            Console.WriteLine($"{arr[i]} ^ 4 = {res}");
        }
    }
}

