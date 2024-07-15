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
            Console.WriteLine("Hello Again!");
            string path = @"./Ducks.txt";

            //IRepository file = new FileReadWrite();
            IRepository file = new Serialization();

            // file.ReadAndWriteWithFile(path);          

            // Console.WriteLine();
            // file.StreamReaderReadLine(path);

            // Console.WriteLine();
            // file.StreamReaderReadToEnd(path);

            List<Duck> duckList = new List<Duck>();
            Duck myDuck = new Duck( "red" , 20 );

            // duckList.Add(myDuck);
            // duckList.Add(new Duck( "green", 50));
            // duckList.Add(new Duck( "black", 120));

            //file.SaveDuck(myDuck, path);
            //file.SaveAllDucks(duckList, path);


            Console.WriteLine("\n");
            //Duck myDuck = new Duck( "purple", 100 );
            //myDuck.Quack();
            //Console.WriteLine( myDuck.ToString() );

            path = @"./Ducks.txt";
            //File.WriteAllText( path, myDuck.ToString() );
            // string ducks = File.ReadAllText(path);
            // Console.WriteLine(ducks);
            //string[] duckVals = ducks.Split(' ');
            //Duck mySavedDuck = new Duck( duckVals[0], int.Parse(duckVals[1]) );
            //mySavedDuck.Quack();

            //List<Duck> duckList = file.ReadDucksFromFile(path) ; 

            duckList = file.LoadAllDucks(path);
            foreach(Duck d in duckList)
            {
                d.Quack();
            }
        }
    }
}