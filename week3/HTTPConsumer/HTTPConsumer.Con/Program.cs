using System;
using System.Net.Http;
using System.Text.Json;

using HTTPConsumer.Models;

namespace HTTPConsumer.Con
{
    class Program
    {
        public static async Task Main( string[] args )
        {
            Console.WriteLine( "Http Client is starting..." );

            string uri = "https://jsonplaceholder.typicode.com/posts/";

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(uri);

            // Console.WriteLine( response );

            List<Post> postList = JsonSerializer.Deserialize<List<Post>>(response);

            foreach ( var i in postList )
                Console.WriteLine( i.id + ": " + i.title );

        }
    }
}