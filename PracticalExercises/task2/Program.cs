void DefinitionOfCoordinateQuarter (int x, int y)
{
    if(x != 0 && y != 0 )
    {
        if(x < 0)
        {
            if(y < 0)
            {
                System.Console.WriteLine("Number is in the Third quarter");
            }
            else
            {
                System.Console.WriteLine("Number is in the Second quarter");
            }
        }
        else 
        {
           if(y < 0)
            {
                System.Console.WriteLine("Number is in the Fourth quarter");
            }
            else
            {
                System.Console.WriteLine("Number is in the First quarter");
            } 
        }
    }
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

DefinitionOfCoordinateQuarter(x, y);