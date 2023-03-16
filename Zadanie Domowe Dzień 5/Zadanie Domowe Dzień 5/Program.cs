///Przygotuj program, który policzy ile jakich cyfr
///występuje w podanej liczbie: 4566
///
///0=>0
///1=>0
///2=>0
///3=>0
///4=>1
///5=>1
///6=>2
///7=>0
///8=>0
///9=>0

int number = 4566;
string numberAsString = number.ToString();

//Tablica Char[]
char[] nr = numberAsString.ToArray();
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;
//--------------------------------------

foreach (char digit in nr)
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1') 
    {
        counter1++;
    }
    else if (digit == '2')
    {
        counter2++;
    }
    else if (digit == '3')
    {
        counter3++;
    }
    else if (digit == '4')
    {
        counter4++;
    }
    else if (digit == '5')
    {
        counter5++;
    }
    else if (digit == '6')
    {
        counter6++;
    }
    else if (digit == '7')
    {
        counter7++;
    }
    else if (digit == '8')
    {
        counter8++;
    }
    else if (digit == '9')
    {
        counter9++;
    }
}
Console.WriteLine("cyfra 0 jest w ilości " + counter0); 
Console.WriteLine("cyfra 1 jest w ilości " + counter1);
Console.WriteLine("cyfra 2 jest w ilości " + counter2);
Console.WriteLine("cyfra 3 jest w ilości " + counter3);
Console.WriteLine("cyfra 4 jest w ilości " + counter4);
Console.WriteLine("cyfra 5 jest w ilości " + counter5);
Console.WriteLine("cyfra 6 jest w ilości " + counter6);
Console.WriteLine("cyfra 7 jest w ilości " + counter7);
Console.WriteLine("cyfra 8 jest w ilości " + counter8);
Console.WriteLine("cyfra 9 jest w ilości " + counter9);
