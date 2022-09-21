using System;

public class Tamagotchi
{

    private int hunger = 0;
    private int boredom = 0;
    private List<string> words = new List<string>() { };
    private bool isAlive = true;
    private Random gen = new Random();

    public string name = "tamagotchi";

    public void Feed()
    {
        System.Console.WriteLine($"{name} ate some bread.");
        if (hunger >= 3)
        {
            hunger -= 3;
        }
        else
        {
            hunger = 0;
        }
    }
    public void Hi()
    {
        if (words.Count == 0)
        {
            Console.WriteLine("I don't know any words yet...");
        }
        else
        {
            int wordNum = gen.Next(words.Count);
            System.Console.WriteLine($"[{name}] says: {words[wordNum]}.");
            ReduceBoredom();
        }
    }
    public void Teach(string word)
    {
        System.Console.WriteLine($"[{name}] learned how to say {word}.");
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick()
    {
        hunger += gen.Next(1, 2);
        boredom += gen.Next(1, 2);

        if (hunger >= 10)
        {
            isAlive = false;
        }
        if (boredom >= 10)
        {
            isAlive = false;
        }
    }
    public void PrintStats()
    {
        System.Console.WriteLine($"Name : {name}");
        System.Console.WriteLine($"Boredom = {boredom}");
        System.Console.WriteLine($"Hunger = {hunger}");
        System.Console.WriteLine($"Knowledge = {words.Count}");
    }
    public bool GetAlive()
    {
        return isAlive;

    }
    private void ReduceBoredom()
    {
        if (boredom >= 3)
        {
            boredom -= 3;
        }
        else
        {
            boredom = 0;
        }
    }
}