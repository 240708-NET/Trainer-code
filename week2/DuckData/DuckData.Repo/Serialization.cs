using DuckData.Models;
using System.Text.Json;

namespace DuckData.Repo
{
    public class Serialization : IRepository
    {
        // Fields
        private readonly string _path = "";

        // Constructors
        public Serialization (string path)
        {
            this._path = path;
            string text = "";
            if( !File.Exists( _path ) )
            {
                File.WriteAllText( _path, text );
            }
        }

        // Methods
        public void SaveDuck( Duck myDuck )
        {
            List<Duck> duckList = LoadAllDucks();
            duckList.Add( myDuck );
            string serDucks = JsonSerializer.Serialize( duckList );
            File.WriteAllText( _path, serDucks );
        }
        
        public void SaveAllDucks( List<Duck> duckList )
        {
            string serDucks = JsonSerializer.Serialize( duckList );
            File.WriteAllText( _path, serDucks );
        }

        public List<Duck> LoadAllDucks()
        {
            string json = File.ReadAllText( _path );
            List<Duck> duckList = JsonSerializer.Deserialize<List<Duck>>( json );
            return duckList;
        }

        public Duck GetDuckById( int id )
        {
            List<Duck> duckList = LoadAllDucks();
            var foundDuck = 
                from d in duckList
                where d.ID == id
                select d;
            if( foundDuck == null )
            {
                throw new Exception("ID not found");
            }
            return foundDuck.First();
        }

        public void DeleteDuckById( int id )
        {
            List<Duck> duckList = LoadAllDucks();
            duckList.Remove(duckList.Find( d => d.ID == id ));
            SaveAllDucks( duckList );
        }
    }
}