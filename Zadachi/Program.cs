
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

void Dlinna(int N)
{
    int l = 1;
    while (Math.Abs(N / 10) > 1)
    {
        N = N / 10;
        l++;
    }
    Console.WriteLine("Количество цифр в веденном числе " + l);
}

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
Dlinna(number);


//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

void bitArray()
{
    int[] a = new int[8];

    for(int i = 0; i < 8; i++)  
    {
        a[i] = new Random().Next(0,2);
        Console.Write(a[i] + " ");
    }
}

bitArray();


