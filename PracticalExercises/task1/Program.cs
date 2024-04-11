void CheckIfDevides(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        System.Console.WriteLine("Number multiple 7 and 23");
    }
    else 
    {
        System.Console.WriteLine("Number not multiple 7 and 23");
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

CheckIfDevides(num);