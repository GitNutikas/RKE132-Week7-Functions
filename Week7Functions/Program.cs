Console.WriteLine("Are you coming or living? (in/out):");
string userChois = Console.ReadLine();

if (userChois == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}


static void PrintHello()    //function/method   
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()  //void - peale func end mälus mitte midagi ei jää
{
    Console.WriteLine("See you later, alligator.");
}