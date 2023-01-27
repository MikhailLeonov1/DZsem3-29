// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.


int N = 8; // размер массива  
int[] myArray = new int[N]; // создание массива
Console.WriteLine("Введите массив из 8 целых чисел");
for (int i=0; i<N; i++) // ввод массива с кл.
{
myArray[i] = Convert.ToInt32(Console.ReadLine());
} 
Console.WriteLine( "Массив:" );
for (int i = 0; i < N; i++) //ыывод на экран
{
Console.Write("{0} ", myArray[i]);
}
