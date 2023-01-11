//Урок 4. Функции

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine ("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int V=0;
while (b==0)
{
    V*=a;
    b-1;
}

________________________________________
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine ("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
int sum=0;
int Func ()
{
    while (num>0)
    {
       int temp=num%10; 
       sum+=temp;
       num=num/10;
    }
    return sum;
}
Console.WriteLine (Func ());


________________________________________
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] Print();

{
    int[] array=new int [];
    for (int i=0; 1<array.Length; i+1)
    {
        Console.WriteLine ("Введите элемент массива/n");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
       return sum;
}
    
Console.WriteLine (string.Join (",", Print));


