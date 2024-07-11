class Program
{
    public static void Main (string[] args)
        {
        // play FizzBuzz
        // As a user, i want to play Fizz Buzz from 1 to 20
        // Count from lower to upper numbers, printing each one to it's own line
        // When a multiple of 2 is being printed, replace it with Fizz
        // When a multiple of 5, replace it with Buzz
        // When a multiple of 3 and 5, replace it with "FizzBuzz"
        // When a multiple of 7, replace it with "Bang"
        // when a multiple of 3 and 7, replace with "FizzBang"
        // When               5 and 7, replace with "BuzzBang"
        // When             3, 5, and 7, replace with "FizzBuzzBang"
        // when                9, replace with "Crack"

        // Collections: an object in memory that holds/stores a group of similarly typed objects
        // Enumerable: object that contains other objects, and allows them to be iterated through

        // Array: fixed size in memory
        // List: dynamic (can be added to or removed from one element at a time)
        // Ditionary: made of Keys and Values, but have no "index" 


            // int fizzNum = 2;
            // int buzzNum = 5;
            // int bangNum = 7;
            // int crackNum = 9;

        Dictionary<int, string> wordVals = new Dictionary<int, string>();
        wordVals.Add(2, "Fizz");
        wordVals.Add(3, "Bug");
        wordVals.Add(5, "Buzz");
        wordVals.Add(7, "Bang");
        wordVals.Add(9, "Crack");
        // wordVals.Remove(5);
        // wordVals.Add(9, "Fizz");

        int startNum = 1;
        int endNum = 21;

        for ( int i = startNum; i <= endNum; i++ )
        {
            Console.WriteLine( FizzBuzzBuilder( wordVals, i ) );
            // // % divides, and returns the remainder of the division
            // counter = 0;

            // if ( i % fizzNum == 0 )
            // {
            //     Console.Write( "Fizz" );
            //     counter++;
            // }

            // if ( i % buzzNum == 0 )
            // {
            //     Console.Write( "Buzz" );
            //     counter++;
            // }

            // if ( i % bangNum == 0 )
            // {
            //     Console.Write( "Bang" );
            //     counter++;
            // }
            
            // if ( i % crackNum == 0 )
            // {
            //     Console.Write( "Crack" );
            //     counter++;
            // }
            
            // if ( counter == 0)
            // {
            //     Console.Write( i ); // Write ever number to its own line
            // }

            // Console.WriteLine();
        }
    }

    static string FizzBuzzBuilder( Dictionary<int, string> wordVals, int i )
    {
        string output = "";
        foreach ( KeyValuePair<int, string> val in wordVals ) // ( var val in wordVals )
        {
            // Console.Write(" - " + val.Key + " - "); //- neat question Nick!
            if ( i % val.Key == 0 )
            {
                output += val.Value ; 
            }
        }
        if ( String.IsNullOrEmpty( output ) )
        {
            output += i.ToString();
        }
        return output;
    }
}