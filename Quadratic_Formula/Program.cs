class Program
{
    /// <summary>
    /// Method solves quadratic equations and returns the possible values of x
    /// </summary>
    static void QuadraticFormula(double a, double b, double c)
    {
        double positiveB = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);   //first value of x
        double negativeB = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);   //second value of x

        if ((Math.Round(((a * positiveB * positiveB) + (b * positiveB)), 6) + c) != 0)                     //checking first val
        { Console.WriteLine("Solution doesn't exist"); }
        else if ((Math.Round(((a * negativeB * negativeB) + (b * negativeB)), 6) + c) != 0)                //checking second val (is it necessary?)
        { Console.WriteLine("Solution doesn't exist"); }
        else
        { Console.WriteLine($"X = {Math.Round(positiveB, 6)}\nAND\nX = {Math.Round(negativeB, 6)}"); }    //result
    }
    static void Main()
    {
        Console.WriteLine("This program solves quadratic equations and returns the possible values of x.");
        Console.WriteLine($"a(x^2) + bx + c = 0");

        while (true)
        {
            double a, b, c;                                                 //ввод переменных
            do { Console.Write("\nEnter a: "); }                            //переменная a
            while (!double.TryParse(Console.ReadLine(), out a));

            do { Console.Write("Enter b: "); }                              //переменная b
            while (!double.TryParse(Console.ReadLine(), out b));

            do { Console.Write("Enter c: "); }                              //переменная c
            while (!double.TryParse(Console.ReadLine(), out c));

            QuadraticFormula(a, b, c);                                      //расчет значений x

            Console.WriteLine("Press any key to continue or 'e' to exit");  //охраняющее условие
            var exitKey = Console.ReadKey().KeyChar;
            if (exitKey == 'e' || exitKey == 'E') break;
        }
    }
}

