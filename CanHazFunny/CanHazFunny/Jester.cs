using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny;

public class Jester
{
    public IJokeService JokeService
    {
        get { return _JokeService!; }
        set { _JokeService = value; }
    }
    private IJokeService? _JokeService;
    public IFunnyOut JokeWriter
    {
        get { return _JokeWriter!; }
        set { _JokeWriter = value; }
    }
    private IFunnyOut? _JokeWriter;

    public Jester(IJokeService jokeService, IFunnyOut jokeWriter)
    {
        if(jokeService is null)
        {
            throw new ArgumentNullException("IJokeService passed to Jester contructor cannot be null.");
        }
        this.JokeService = jokeService;
        if(jokeWriter is null)
        {
            throw new ArgumentNullException("IFunnyOut passed to Jester constructor cannot be null.");
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
