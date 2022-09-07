// See https://aka.ms/new-console-template for more information

Console.WriteLine("Greetings! What would you like your character to be called?");

Tamagotchi character = new Tamagotchi();
character.name = Console.ReadLine();

character.Hi();

while (character.GetAlive())
{
    System.Console.WriteLine("What would you like to do today? Teach or eat?");

    string activity = Console.ReadLine().ToLower();

    if (activity == "teach")
    {
        character.Teach();
    }
    if (activity == "eat")
    {
        character.Feed();
    }

    character.Tick();
    character.PrintStats();

}



Console.ReadLine();



