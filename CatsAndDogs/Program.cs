// See https://aka.ms/new-console-template for more information
{
    Console.WriteLine("Are you more like a cat or a dog?");
    string userChoice = Console.ReadLine().ToLower();
    if (userChoice == "CAT")
    Console.WriteLine("You are a home-lover.");
    else if (userChoice == "Dog")
    Console.WriteLine("You are a partygoer.");
    else
    Console.WriteLine($"You are a {userChoice} friend.");
    
}
