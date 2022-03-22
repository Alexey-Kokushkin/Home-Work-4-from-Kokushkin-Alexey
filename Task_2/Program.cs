// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
String inputnumber = Console.ReadLine();
int size = inputnumber.Length;
int number = int.Parse(inputnumber);

int[] array = new int[size];
int currentindex = 0;
while (currentindex < size)
{
    array[currentindex] = number%10;
    number = number/10;
    currentindex++;
}

currentindex = 0;
int Sum = 0;
while (currentindex<size)
{
    Sum = Sum + array[currentindex];
    currentindex++;
}
Console.WriteLine("Сумма цифр в числе равна " + Sum);


