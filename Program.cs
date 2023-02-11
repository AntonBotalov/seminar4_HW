// 1. апишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Task_1()
{
    int firstNumber = ReadInt("First Number");
    int secondNumber = ReadInt("Second Number");

    inDegree(firstNumber, secondNumber);    
}

void Task_2()
{
    Console.WriteLine(sumNum(ReadInt("Введите число")));
}

void Task_3()
{
    int[] array = GetRandomArray(ReadInt("Введите длуину массива"));
    PrintArray(array);
}

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error! Try again.");
    }

    return number;
}

void inDegree(int num, int degree)
{
    int result = 1;

    for(int n = 1; n <= degree; n++)
    {
        result = result * num;
    }

    Console.WriteLine($"{num} в степени {degree} = {result}");
}

int sumNum(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }

    return sum;

    Console.WriteLine($"сумма цифр числа {number} = {sum}");
}
    
int[] GetRandomArray(int Length)
{
    int[] array = new int[Length];
    Random random = new Random();

    for (int i = 0; i < Length; i++)
    {
    array[i] = random.Next(0, 100);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }

    Console.WriteLine($"{array[array.Length - 1]}]");
}

bool inWork = true;

while (inWork)
{
    Console.Write("Выбери задачу ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1:
            {
                Task_1();

                break;
            }

			case 2:
            {
                Task_2();
                
                break;
            }

            case 3:
            {
                Task_3();
                
                break;
            }
            
            case -1: inWork = false; break;
        }
    }
}