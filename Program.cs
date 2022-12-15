// Задача 25.

int MathPow(int num, int pow)
{
    int num1 = num;
    for(int step = 2; step <= pow; step++)
        num = num * num1;
    return num;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a pow: ");
int pow = Convert.ToInt32(Console.ReadLine());

int result = MathPow(num, pow);
Console.Write(result);

// Задача 27.

int SumNum(int num2)
{
    int sum = 0;
    int a = 0;
    while(num2 > 0)
    {
        a = num2 % 10;
        num2 /= 10;
        sum += a;
    }
    return sum;
}

Console.Write("Input a number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result1 = SumNum(num2);
Console.Write(result1);

// Задача 29.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input a number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int  i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray); 