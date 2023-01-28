using System;

namespace CanHazFunny;

class Program
{
    static void Main(string[] args)
    {
        //Feel free to use your own setup here - this is just provided as an example
        //new Jester(new SomeReallyCoolOutputClass(), new SomeJokeServiceClass()).TellJoke();
        JokeService jokeService = new JokeService();
        FunnyOut jokeWriter = new FunnyOut();
        Jester joker = new(jokeService, jokeWriter);
        
        for(int i=0; i<10; i++)
        {
            joker.TellJoke();
        }

    }
}
