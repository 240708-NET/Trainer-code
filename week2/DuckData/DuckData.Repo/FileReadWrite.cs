using DuckData.Models;

namespace DuckData.Repo
{
    public class FileReadWrite : IRepository
    {   
        // Fields
        private readonly string _path = "";

        // Constructors
        public FileReadWrite( string path )
        {
            this._path = path;
            string text = "";
            if( !File.Exists( _path ) )
            {
                File.WriteAllText( _path, text );
            }
        }

        // Methods
        public void ReadAndWriteWithFile()
        {
            string text = "some content for the file";

            // read, write (overwrite content, or create the file), append (add to the end of the file)
            if( !File.Exists( _path ) )
            {
                File.WriteAllText( _path, text );
                //File.WriteAllLines( _path, string[] );
            }
            else
            {
                Console.WriteLine( "Reading from file with File.ReadAllText: " );
                text = File.ReadAllText( _path );
                Console.WriteLine(text);
            }
        }

        public void StreamReaderReadLine()
        {            
            /*
            streamreader doesn't load the file, it provides a route to the file. 
            rather than retrieving the entire file to memory, we can read each line one at a time, reducing the memory requred.
            */
            Console.WriteLine( "Reading from file with StreamReader (line by line): " );
            StreamReader sr = new StreamReader( _path ); 
            string text = "";
            while( (text = sr.ReadLine()) != null )
            {
                Console.Write(text);
                Console.WriteLine( " -- ");
            }
            sr.Close();
        }

        public void StreamReaderReadToEnd()
        {
            Console.WriteLine( "Reading from file with StreamReader (EOF): " );
            StreamReader sr = new StreamReader( _path );
            string text = "";
            while ( (text = sr.ReadToEnd()) != "" )
            {
                Console.Write(text);
                Console.WriteLine( " -- ");
            }
            // text = sr.ReadToEnd();
            // Console.Write(text);
            sr.Close();
        }

        public List<Duck> ReadDucksFromFile()
        {            
            StreamReader sr = new StreamReader( _path );
            List<Duck> duckList = new List<Duck>();
            string text = "";

            while( (text = sr.ReadLine()) != null )
            {
                string[] duckVals = text.Split(' ');
                Duck mySavedDuck = new Duck( int.Parse(duckVals[0]), duckVals[1], int.Parse(duckVals[2]) );
                duckList.Add( mySavedDuck );
            }
            sr.Close();
            return duckList;
        }

        public void SaveDuck( Duck myDuck )
        {
            List<Duck> duckList = LoadAllDucks();
            duckList.Add( myDuck );
            SaveAllDucks( duckList );
        }
        
        public void SaveAllDucks( List<Duck> duckList )
        {
            string duckString = "";
            foreach (var d in duckList)
            {
                duckString += d.ToString() + "\n";
            }
            File.WriteAllText( _path, duckString );
        }

        public List<Duck> LoadAllDucks ()
        {      
            StreamReader sr = new StreamReader( _path );
            List<Duck> duckList = new List<Duck>();
            string text = "";

            while( (text = sr.ReadLine()) != null )
            {
                string[] duckVals = text.Split(' ');
                Duck mySavedDuck = new Duck( int.Parse(duckVals[0]), duckVals[1], int.Parse(duckVals[2]) );
                duckList.Add( mySavedDuck );
            }
            sr.Close();
            return duckList;
        }

        public Duck GetDuckById ( int id )
        {
            List<Duck> duckList = LoadAllDucks();
            foreach( Duck d in duckList )
            {
                if( d.ID == id )
                {
                    return d;
                }
            }
            throw new Exception("ID not found");
        }

        public void DeleteDuckById (int id )
        {
            List<Duck> duckList = LoadAllDucks();
            Duck? target = null;
            foreach( Duck d in duckList )
            {
                if( d.ID == id )
                {
                    target = d;
                }
            }

            if ( target == null )
            {
                throw new Exception("ID not found");
            }

            duckList.Remove( target );
            SaveAllDucks( duckList );
        }
    }
}