using DuckData.Models;
using System.Text.Json;

namespace DuckData.Repo
{
    public class Serialization : IRepository
    {
        public void ReadAndWriteWithFile(string path)
        {
        }

        public void StreamReaderReadLine(string path)
        {
        }

        public void StreamReaderReadToEnd(string path)
        {
        }

        public List<Duck> ReadDucksFromFile(string path)
        {
            return new List<Duck>();
        }

        public void SaveDuck( Duck myDuck, string path )
        {

            string serDuck = JsonSerializer.Serialize( myDuck );
            File.WriteAllText( path, serDuck );

        }
        
        public void SaveAllDucks(List<Duck> duckList, string path)
        {
            string serDucks = JsonSerializer.Serialize( duckList );
            File.AppendAllText( path, serDucks );
        }

        public List<Duck> LoadAllDucks ( string path )
        {
            string json = File.ReadAllText( path );
            List<Duck> duckList = JsonSerializer.Deserialize<List<Duck>>( json );
            return duckList;
        }
    }
}