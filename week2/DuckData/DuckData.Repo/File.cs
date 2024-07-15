using DuckData.Models;

namespace DuckData.Repo
{
    public class FileReadWrite : IRepository
    {
        public void ReadAndWriteWithFile(string path)
        {
            string text = "some content for the file";

            // read, write (overwrite content, or create the file), append (add to the end of the file)
            if( !File.Exists( path ) )
            {
                File.WriteAllText( path, text );
                //File.WriteAllLines( path, string[] );
            }
            else
            {
                Console.WriteLine( "Reading from file with File.ReadAllText: " );
                text = File.ReadAllText( path );
                Console.WriteLine(text);
            }
        }

        public void StreamReaderReadLine(string path)
        {            
            /*
            streamreader doesn't load the file, it provides a route to the file. 
            rather than retrieving the entire file to memory, we can read each line one at a time, reducing the memory requred.
            */
            Console.WriteLine( "Reading from file with StreamReader (line by line): " );
            StreamReader sr = new StreamReader( path ); 
            string text = "";
            while( (text = sr.ReadLine()) != null )
            {
                Console.Write(text);
                Console.WriteLine( " -- ");
            }
            sr.Close();
        }

        public void StreamReaderReadToEnd(string path)
        {
            Console.WriteLine( "Reading from file with StreamReader (EOF): " );
            StreamReader sr = new StreamReader( path );
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

        public List<Duck> ReadDucksFromFile(string path)
        {            
            StreamReader sr = new StreamReader( path );
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

        public void SaveDuck(Duck myDuck, string path)
        {
        }

        
        public void SaveAllDucks(List<Duck> duckList, string path)
        {
        }

        public List<Duck> LoadAllDucks (string path)
        {
            return new List<Duck>();
        }
    }
}