// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число A: ");
String inputnumberA = Console.ReadLine();
double numberA = double.Parse(inputnumberA);

Console.WriteLine("Введите число B: ");
String inputnumberB = Console.ReadLine();
int numberB = int.Parse(inputnumberB);

double Exponentiation(double numberA, int numberB)
{
    double result = 1;
    int i = 1;
    while(i <= numberB)
    {
        result = result*numberA;
        i++;
    }
    return result;
}

double ExponResult = Exponentiation(numberA, numberB);
Console.WriteLine(ExponResult);




