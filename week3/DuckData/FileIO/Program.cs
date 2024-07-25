using System;
using System.IO;
using DuckData.Repo;
using DuckData.Models;

namespace FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string connectionstring = File.ReadAllText(@".\..\connectionstring");
            Console.WriteLine("Hello Again!");

            // IRepository file = new FileReadWrite( "./Ducks.txt" );
            // IRepository file = new Serialization( "./SerializedDucks.txt" );
            IRepository file = new EFCore();

            List<Duck> duckList = new List<Duck>();
            Duck myDuck = new Duck( "red" , 20 );
            duckList.Add(myDuck);
            duckList.Add(new Duck( "green", 50));
            duckList.Add(new Duck( "black", 120));

            // file.ReadAndWriteWithFile();          
            // file.StreamReaderReadLine();
            // file.StreamReaderReadToEnd();

            // List<Duck> duckList = file.ReadDucksFromFile(); 
            // file.SaveDuck(myDuck);
            
            try
            {
                file.SaveAllDucks(duckList);
            }
            catch( Exception e )
            {
                Console.WriteLine( e.Message );
            }

            try
            {
                myDuck = file.GetDuckById( 2 );
            }
            catch( Exception e )
            {
                Console.WriteLine( e.Message );
            }

            duckList = file.LoadAllDucks();

            foreach(Duck d in duckList)
            {
                d.Quack();
            }

            try 
            {
                file.DeleteDuckById( 2 );
            }
            catch( Exception e )
            {
                Console.WriteLine( e.Message );
            }

            duckList = file.LoadAllDucks();
            
            foreach(Duck d in duckList)
            {
                d.Quack();
            }
        }
    }
}
