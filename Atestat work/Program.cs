//Решение задачи № 64//

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
