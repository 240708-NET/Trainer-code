class Game
{
    // Fields
    Random rand = new Random();
    int targetNumber;
    int guessNumber = -1;
    int roundCount = 0;
    public string guessString { get; set; } = ""; // auto-property
/*
    ==
    private string guessString;
    public string get_guessString()
    {
        return this.guessString;
    }

    public void set_guessString(string guessString)
    {
        this.guessString = guessString;
    }

    // Methods 
    // getters and setters - short methods that allow you to "get" (retrieve), or "set" (assign) a value to a field.

/*
    public int get_guessNumber()
    {
        return this.guessNumber;
    }

    public void set_guessNumber(int _guessNumber)
    {
        if (_guessNumber > 0)
            this.guessNumber = _guessNumber;
    }
*/

    // Method signature structure
    // [Access Mod] [Modifier] [Return Type] [Method Name] ([Method Parameters])
    // Class : Object :: Blueprint : Building

    // Access Modifiers: public (anything can access this method/object), private (default in C#) (only accessible from the same object/instance), protected (only accessible from the class/object or its child/sub/inherited class), internal (can only be accessed from within the same compiled assembly)

    // (non-access)Modifier: the modifier will limit or restrict how a target can be utilized
    // Non-access modifiers in programming, specifically in languages like Java and C#, are keywords that provide additional information about the characteristics of a class, method, or variable, without affecting their accessibility.
    // readonly: this thing can only be modified in the constructor of the class
    // static: this thing (method or field) belongs to the Class, not to the Object (it is shared among all instances of the class)

    // Constructor - the method that instantiates an instance of an object (it's the instruction on how to create an instance of the method)
    public Game(  )
    {
        targetNumber = rand.Next(11);
    } 

    public int PlayGame (  )
    {
        roundCount = 0;
        do 
        {
            //roundCount = roundCount + 1;
            //roundCount += 1;
            roundCount++;

            Console.Write( "Please enter a guess between -1 and 11: " );
            guessString = Console.ReadLine();

            guessNumber = Int32.Parse( guessString );

            if( guessNumber == targetNumber )
            {
                Console.WriteLine( "Hey, Nice Job!" );
            }

            else if( guessNumber > targetNumber )
            {
                Console.WriteLine( "Oops, too high!" );
            }

            else 
            {
                Console.WriteLine( "Oops, too low!" );
            }
        } while ( guessNumber != targetNumber );

        return roundCount;
    }
}