// See https://aka.ms/new-console-template for more information
//nsole.WriteLine("Hello, World!");

Console.WriteLine("Enter the number of checks");
string numberofchecks = Console.ReadLine();

bool check;
int numberofiterations;
check = int.TryParse(numberofchecks, out numberofiterations);

if (check)
{
    Console.WriteLine($"number of iterations {numberofiterations}");
    Console.WriteLine();

    for (int count = 0; count < numberofiterations; count++)
    {


        Console.WriteLine("Enter the word palindrome");
        string inputPalidrome = Console.ReadLine();
        char[] arraypalidrome = inputPalidrome.ToArray();
        string paledromefromtheends = "";
        string paledromefromthebeginning = "";
        //ароза упала на лапу азора
        int LengthPalendrome = arraypalidrome.Length;

        for (int i = LengthPalendrome - 1; i >= 0; i--)
        {
            if (arraypalidrome[i].ToString() != " ")
            {
                paledromefromtheends += arraypalidrome[i].ToString().ToLower();
            }
            else
            {
                continue;
            }

        }
        Console.WriteLine($"paledrome from the end {paledromefromtheends}");


        for (int j = 0; j < LengthPalendrome; j++)
        {
            if (arraypalidrome[j].ToString() != " ")
            {
                paledromefromthebeginning += arraypalidrome[j].ToString().ToLower();
            }
            else
            {
                continue;
            }

        }

        Console.WriteLine($"paledrome from the beginning {paledromefromthebeginning}");

        if (paledromefromthebeginning == paledromefromtheends)
        {
            Console.WriteLine("ntered word palindrome");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("the entered word is not a palindrome");
            Console.WriteLine();
        }

    }
}
else
{
    Console.WriteLine("Enter a number not a string");
}