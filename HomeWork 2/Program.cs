// Task 10. Напишите программу, которая на вход принимает трехзначное число, 
//а на выходе показывает вторую цифру этого числа.

/* int CutNumber(int num)
{
    int hundrads = num/10;
    return hundrads%10;
}
Console.Write("Input three-digit number ");
int num = Convert.ToInt32(Console.ReadLine());
int NewNumber = CutNumber(num);
Console.WriteLine($"New version of {num} is {NewNumber}");
*/

// Task 13. Напишите программу, которая выводит третью цифру заданного числа 
//(или -1, если третьей цифры нет).
/*
int GetThirdRank (int num)
{
    while (num>999)
    {
        num/=10;
    }
    return num%10;
}
bool CorrectNum (int num)
{
    if (num<100)
    {
        Console.WriteLine("This number hase not a third digit");
        return false;
    }
    return true;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int NewNum = GetThirdRank(num);
if(CorrectNum(num))
{
    Console.WriteLine($"Third digit of {num} is {NewNum}");
}
*/

// Task 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
/*
bool HolidayCheck (int num)
{
    if(num==6||num==7)
    return true;
    else
    {
        return false;
    }
}
Console.Write("Input number of day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res =HolidayCheck (num);
if(res) Console.WriteLine ("This day is a holiday");
else Console.WriteLine ("This day is not a holiday");
*/