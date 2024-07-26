using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

using HTTPConsumer.Models;

namespace HTTPConsumer.Con
{
    class Program
    {
        public static async Task Main( string[] args )
        {
            Console.WriteLine( "Http Client is starting..." );

            string uri = "https://jsonplaceholder.typicode.com/posts/";
            string baseurl = "http://localhost:5250/";

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(baseurl + "Duck");

            // Console.WriteLine( response );

            // List<Post> postList = JsonSerializer.Deserialize<List<Post>>(response);
            // List<Forecast> forecastList = JsonSerializer.Deserialize<List<Forecast>>(response);
            List<Duck> duckList = JsonSerializer.Deserialize<List<Duck>>(response);

            // foreach ( var i in postList )
            //     Console.WriteLine( i.id + ": " + i.title );

            // foreach (var f in forecastList )
            //     Console.WriteLine(f.temperatureF);

            // foreach ( var d in duckList )
            //     Console.WriteLine(d.color);

            
            // this is our duck DTO, the values before they get an ID number.
            DuckDTO myDuck = new DuckDTO{color="blue", numFeathers=44};

            // this is for debugging only, so that we can see the json of the DuckDTO before it is sent.
            // Console.WriteLine(JsonSerializer.Serialize(myDuck)); 

            // the JsonContent object is part of System.Net.Http.Json, and lets us build a content object
            // that will contain a json representation of an object.
            var content = JsonContent.Create<DuckDTO>(myDuck);
            
            // with a http content object, like the json object above, we can shorten the post method to
            // include the url and the http content.
            var postResponse = await client.PostAsync( baseurl + "Duck", content );

            // this will read the post response object, and find the content of the response,
            // then read the content (body) of the response as a stream of data,
            // and pass that stream of data to the json deserailizer to turn it back into an object
            // we can use in out application.
            Duck responseDuck = JsonSerializer.Deserialize<Duck>(postResponse.Content.ReadAsStream());
            Console.WriteLine( responseDuck.id + " " + responseDuck.color);

        }
    }
}