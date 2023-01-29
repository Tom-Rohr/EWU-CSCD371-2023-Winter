using System;

namespace CanHazFunny;

class Program
{
    static void Main(string[] args)
    {
        //Feel free to use your own setup here - this is just provided as an example
        //new Jester(new SomeReallyCoolOutputClass(), new SomeJokeServiceClass()).TellJoke();
        Jester joker = new(new JokeService(), new FunnyOut());

        for (int i=0; i<5; i++)
        {
            joker.TellJoke();
        }

    }
}
