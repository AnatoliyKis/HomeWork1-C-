// Seminar 2.

//Theory
/*

13254/10=1325
13254/100=132
13254/1000=13

13254%10=4
13254%100=54
13254%1000=254

*/

int CutNumber(int num)
{
    int hundrads = num/100;
    int units = num%10;
    int result = hundrads * 10 + units;
    return result;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
