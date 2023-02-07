using System;

namespace CanHazFunny;

public class Jester
{
    private IJokeService JokeService
    {
        get { return _JokeService!; }
        set { _JokeService = value; }
    }
    private IJokeService? _JokeService;

    private IFunnyOut JokeWriter
    {
        get { return _JokeWriter!; }
        set { _JokeWriter = value; }
    }
    private IFunnyOut? _JokeWriter;

    public Jester(IJokeService jokeService, IFunnyOut jokeWriter)
    {
        if(jokeService is null)
        {
            throw new ArgumentNullException(nameof(jokeService));
        }
        this.JokeService = jokeService;
        if(jokeWriter is null)
        {
            throw new ArgumentNullException(nameof(jokeService));
        }
        this.JokeWriter = jokeWriter;
    }

    public Jester() { }

    public void TellJoke()
    {
        string joke;
        do
        {
            joke = JokeService.GetJoke();
        } while (CheckForChuckNorris(joke) is true);

        JokeWriter.PrintJokeToConsole(joke);
    }
    public bool CheckForChuckNorris(string joke)
    {
        return (joke.Contains("Chuck") || joke.Contains("Norris") || joke.Contains("Walker"));
    }
}
