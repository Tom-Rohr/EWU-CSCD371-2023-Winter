using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny;

public class Jester : IJokeService, IFunnyOut
{
    private JokeService jokeService = new();
    private string? _Joke { get; set; }

    public void TellJoke()
    {
        this._Joke = jokeService.GetJoke();
        ((IFunnyOut)this).PrintJokeToConsole(this._Joke); 
    }
}
