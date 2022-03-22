// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).
//1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

Console.WriteLine("ВЫВОД МАССИВА СЛУЧАЙНЫХ ЧИСЕЛ");
Console.WriteLine("Введите количество элементов массива: ");
String inputnumber = Console.ReadLine();
int number = int.Parse(inputnumber);

int [] NewArray = new int[number];
int currentindex = 0;
while (currentindex < number)
{
    NewArray[currentindex] = new Random().Next(0,100);
    currentindex++;
}

void OutputArray(int [] array)
{
    int size = array.Length;
    for(int currentindex = 0; currentindex < size; currentindex++)
    {
        Console.Write($"{array[currentindex]} ");
    }
    Console.WriteLine();
}

OutputArray(NewArray);