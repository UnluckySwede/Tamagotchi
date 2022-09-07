using System;

public class Tamagotchi
{

    private int hunger = 0;
    private int boredom = 0;
    private List<string> words = new List<string>() { "arabic", "english", "french" };
    private bool isAlive = true;
    private Random gen = new Random();

    public string name = "tamagotchi";


    public void Feed()
    {
        System.Console.WriteLine("You eat some bread.");
        hunger = 0;
    }
    public void Hi()
    {
        System.Console.WriteLine($"Greetings {name}, hope you enjoy your stay!");
    }
    public void Teach()
    {
        System.Console.WriteLine($"You learned how to read {words}.");
        ReduceBoredom();
    }
    public void Tick()
    {
        hunger += gen.Next(1, 2);
        boredom += gen.Next(1, 2);
    }
    public void PrintStats()
    {
        System.Console.WriteLine($"Boredom = {boredom}");
        System.Console.WriteLine($"Hunger = {hunger}");
        System.Console.WriteLine($"Alive = {isAlive}");
    }
    public bool GetAlive()
    {
        return isAlive;

    }
    private void ReduceBoredom()
    {
        boredom = 0;
    }

}