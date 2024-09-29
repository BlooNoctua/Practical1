AgePlusFive();
AgeChecker();
PosNegZeroChecker();
LeapYearChecker();
EvenOddChecker();
void AgePlusFive()
{
    Console.WriteLine("Please enter your name:");
    string name = Console.ReadLine();

    Console.WriteLine("Please enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());
    int newage = age + 5;

    Console.WriteLine("Hello {0}, you will be {1} in 5 years", name, newage);
    Console.ReadKey();
}

//Task 2 (child, teen or adult checker)

void AgeChecker()
{
    Console.WriteLine("Please enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());

    //If statement to determine age bracket
    if (age < 1 || age > 110)
    {
        Console.WriteLine("Invalid age, Please enter an age between 1-110");
    }
    else if (age <= 13)
    {
        Console.WriteLine("At the age {0} you are a child", age);
    }
    else if (age <= 19 && age >= 13)
    {
        Console.WriteLine("At the age {0} you are a teenager", age);
    }
    else if (age > 19)
    {
        Console.WriteLine("At the age {0} you are an adult", age);
    }
}

//Task 3 (pos,neg or zero checker)

void PosNegZeroChecker()
{
    Console.WriteLine("Please enter a number:");
    int number = Convert.ToInt32(Console.ReadLine());

    //If statement to determine zero
    if (number == 0)
    {
        Console.WriteLine("This is zero");
    }
    else if (number < 0)
    {
        Console.WriteLine("This is a negative number");
    }
    else if (number > 0)
    {
        Console.WriteLine("This is a positive number");
    }
}
//Task 4 (leap year checker)

void LeapYearChecker()
{
    Console.WriteLine("Please enter a year:");
    int year = Convert.ToInt32(Console.ReadLine());

    if (year < 0)
    {
        Console.WriteLine("Invalid Year. Try again");
    }
    else
    {
        if ((year % 4 == 0 && 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("{0} is a leap year.", year));
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}

//Task 5 (Even or odd)

void EvenOddChecker()
{
    Console.WriteLine("Please enter a number:");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {
        Console.WriteLine("{0} is an even number.", number);
    }
    else
    {
        Console.WriteLine("{0} is an odd number.", number);
    }
}