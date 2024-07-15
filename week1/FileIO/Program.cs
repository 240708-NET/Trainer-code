using System;

namespace FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Again!");
            string path = @"./TestText.txt";

            string text = "some content for the file";

            // read, write (overwrite content, or create the file), append (add to the end of the file)
            if( !File.Exists( path ) )
            {
                File.WriteAllText( path, text );
            }
            else
            {
               text = File.ReadAllText( path );
            }

            Console.WriteLine( text );
        }
    }
}