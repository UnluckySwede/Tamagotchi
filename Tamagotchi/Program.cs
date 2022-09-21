// See https://aka.ms/new-console-template for more information
System.Console.CursorVisible = true;
Console.WriteLine("Greetings! What would you like your Tamagotchi to be called?");

Tamagotchi character = new Tamagotchi();
character.name = Console.ReadLine();

System.Console.WriteLine($"You've named your Tamagotchi to {character.name}, make sure you take care of it!");

while (character.GetAlive())
{
    Console.Clear();
    character.PrintStats();
    System.Console.WriteLine($"What would you like to do with {character.name} today?");
    System.Console.WriteLine("1) Teach");
    System.Console.WriteLine("2) Feed");
    System.Console.WriteLine($"3) Say hello to {character.name}");
    System.Console.WriteLine("4) Nothing");

    string activity = Console.ReadLine().ToLower();

    if (activity == "1")
    {
        System.Console.WriteLine("What word");
        string word = Console.ReadLine();
        character.Teach(word);
    }
    if (activity == "2")
    {
        character.Feed();
    }
    if (activity == "3")
    {
        character.Hi();
    }

    character.Tick();

}

System.Console.WriteLine($"Oh no {character.name} died. Bruh...");

Console.ReadLine();