using System.Net.Http;

namespace CanHazFunny;

public class JokeService : IJokeService
{
    private HttpClient HttpClient { get; } = new();

    public string GetJoke()
    {
        string joke = HttpClient.GetStringAsync("https://geek-jokes.sameerkumar.website/api").Result;

        do
        {
            joke = HttpClient.GetStringAsync("https://geek-jokes.sameerkumar.website/api").Result;
        } while (((IJokeService)this).CheckForChuckNorris(joke) is true);
        
        return joke;
    }
}
