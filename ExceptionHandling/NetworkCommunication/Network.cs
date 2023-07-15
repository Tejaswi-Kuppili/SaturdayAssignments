using System.Net;

class NetworkProcessor
{
    public void MakeNetworkRequest(string url)
    {
        try
        {
            WebClient client = new WebClient();
            string response = client.DownloadString(url);
            Console.WriteLine("Response: " + response);
        }
        catch (WebException ex)
        {
            if (ex.Status == WebExceptionStatus.Timeout)
            {
                // Handle timeout exception
                Console.WriteLine("Timeout error: " + ex.Message);
            }
            else
            {
                // Handle other web exceptions
                Console.WriteLine("Web error: " + ex.Message);
            }
        }
        catch (Exception ex)
        {
            // Handle general exceptions
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

class NewtworkCommunication
{
    static void Main()
    {
        string url = "https://example.com/api";
        //string url = "https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/exception-handling";
        NetworkProcessor networkProcessor = new NetworkProcessor();
        networkProcessor.MakeNetworkRequest(url);

        Console.ReadLine();
    }
}
