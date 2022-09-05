
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num1 = Convert.ToInt32(Console.ReadLine());

void Num(){
    int result = 1;
    for (int i = 1; i <= num1; i++)
    {
        result *= num;
    }
Console.WriteLine($"Число {num} в степени {num1} равно {result}");
}

Num();

/*
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Num(int n){
    int a = 1;
    int result = 0;
    for (int i = n; i > 0; i++){
        a = n % 10;
        n = n / 10;
        result += a;
    }

Console.WriteLine($"Сумма цифр в числе равна {result}");
}
Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
Num(num);


// Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
int[] RandomArray(int size){
    Console.Write("Введите максимальное значение элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(0,num);
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(RandomArray(size));
*/