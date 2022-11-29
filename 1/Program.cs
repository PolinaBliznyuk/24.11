// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

Console.WriteLine ("Укажите число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Укажите число B");
int B = Convert.ToInt32(Console.ReadLine());

int Power(int num1, int num2)
{
    int result = 1;
    for (int i=0; i<=num2; i++)
    {
        result *= num1;
    }
return result;
}
int res = Power(A,B);
Console.WriteLine(res);
