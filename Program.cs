
Que newQue = new Que();

bool moreNames = true;
string proceed = "";

while (moreNames == true)
{
    newQue.inQue(Prompt("Please enter a name on your guest list.   "));

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.White;

    proceed = Prompt("Would you like to add another name? (y/n)  ");

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.White;

    if (proceed == "y")
    {
        moreNames = true;
    }
    else
    {
        moreNames = false;
    }
}

newQue.PrintList();
Console.WriteLine();
Console.WriteLine(newQue.ToString());
Console.WriteLine();
Console.WriteLine("DeQue is: " + newQue.deQue());
Console.WriteLine();
Console.WriteLine("Head: " + newQue.Peek());
Console.WriteLine();
Console.WriteLine(newQue.ToString());
Console.WriteLine();


static string Prompt(string text)
{
    Console.Write(text);
    Console.ForegroundColor = ConsoleColor.Green;
    return Console.ReadLine();
    
}//end function