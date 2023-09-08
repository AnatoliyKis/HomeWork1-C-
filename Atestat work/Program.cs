//Решение задачи № 64//
/*
string PrintNumber(int num, string res)
{
    if(num<=1)
    {
        res=res+'1';
        return res;
    } 
    else
    {
        res=res+num;
        return PrintNumber(num-1, res);
    }
}
string result= "";
Console.Write("Input the number:  ");
int number = Convert.ToInt32 (Console.ReadLine());
result=PrintNumber (number, result);
Console.WriteLine (result);
*/

//Решение задачи № 66//
/*
void SumNumbersFromMToN(int num1,int num2, int sum)
{
    if (num1>num2)
    {
        Console.WriteLine("Sum of numbers between first number and second number is: " + sum);
        return;
    }
    else
    {
      sum=sum+(num1++);
      SumNumbersFromMToN(num1, num2, sum);
    }
}

Console.WriteLine ("Input the first number ");
int M=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input the second number ");
int N=Convert.ToInt32(Console.ReadLine());
SumNumbersFromMToN(M, N, 0);
*/

//Решение задачи № 68//
/*
int Akkerman (int num1, int num2)
{
    if(num1==0) return num2+1;
    else if (num2==0) return Akkerman(num1-1, 1);
    else return Akkerman (num1-1, Akkerman(num1, num2-1));
}

Console.WriteLine ("Input the first number ");
int M=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input the second number ");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Akkerman function of first number and second number is {Akkerman(M, N)}");
*/
