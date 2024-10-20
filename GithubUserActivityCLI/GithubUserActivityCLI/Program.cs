using System.Text.Json;
using static System.Net.WebRequestMethods;

class Program
{
    static async Task Main(string[] args)
    {
        if (args.Length != 1)
        {
            ShowUsage();
            return;
        }
        Console.WriteLine($"Hello {args[0]}");

        await FetchUserActivity(args[0]);
    }

    static void ShowUsage()
    {
        Console.WriteLine("Show Usage");
    }

    static async Task FetchUserActivity(string username)
    {
        string url = $"https://api.github.com/users/{username}/events";
        try
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", @"Mozilla/5.0 (Windows NT 10; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0");
                using (HttpResponseMessage res = await client.GetAsync(url))
                {
                    using (HttpContent content = res.Content)
                    {
                        var data = await content.ReadAsStringAsync();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}