// Task 10. Напишите программу, которая на вход принимает трехзначное число, 
//а на выходе показывает вторую цифру этого числа.

int CutNumber(int num)
{
    int hundrads = num/10;
    return hundrads%10;
}
Console.Write("Input three-digit number ");
int num = Convert.ToInt32(Console.ReadLine());
int NewNumber = CutNumber(num);
Console.WriteLine($"New version of {num} is {NewNumber}");
