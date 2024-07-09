
public class Program
{

	static void Main( string[] args ) // ENTRYPOINT - Main Method - the place that the application starts running!
	{ 
		// <- c# commenting can be done using double forward-slash
		/* 
			Blocks of text (for longer descriptions) can be completed with "multi-line" commenting syntax
		*/
		// Method - a block of code/group of code with a labled functionality
		// Methods make code readable for developers, and reusable - instead of writing the same line over and over, just "call" the method

		Console.WriteLine("Hello, World!"); // Console is an object, WriteLine is a behavior
	


		// Object Oriented Language/Programming - a paradigm of programming that bundles of data/values and behavior to create an object/thing.
		//	 The functionality of an application is based on the relationships between those objects.


		/*
		Variables - Data Types
			C# is Strongly typed - we need to declare the compiler what type of data is going to be in each variable
			"Type-Safe"/ Type-Safety
		Compiling - taking the code we've written (in C#) and transforming/parsing that code into something the computer can understand.
		Interpreted - "reads" the code line-by-line as it is running, and executes the application "on the fly"
			A compiled application will be faster than an equivelent interpreted application
		
		*/

		Console.WriteLine("Please enter your name for a personalized greeting: ");

		// string type hold Text
		// declaring a variable 
		// <variable type> <name> 

		// instantiate a variable
		// <variable> = <value>

		string userName = "Richard"; // delclaration and instantiation
		userName = "Bilal"; // assignment (re-assignment)

		userName = Console.ReadLine(); // Console is the object, ReadLine is the behavior
		
		// Console.Write("Welcome to Revature: ");
		// Console.WriteLine( userName );		// Separate Write/WriteLine
		
		// Console.WriteLine( "Welcome to Revature: " + userName ); // String contatination

		// Console.WriteLine( "Welcome to Revature: {0}", userName ); // String interpolation

		Console.WriteLine( $"Welcome to Revature: {userName}");	// String formatting

		/* 
		Built-In Data Types

			1 0 - binary 
			decimal - 5  ==> binary - 0101

			Int32 - 32 bit value (32 1's and 0's)

			Numeric Data Types
			double, float, long, short, decimal
			Intigers - Whole numbers 
		
			Boolean (true or false) - 1 or 0
			
			char -> character (just one character!)
			string -> strings of text (like words)
			
			byte and bit (not as common, but they're still around!)
		*/

		/*
		Conditional statement and control flow

			if, else if, else
			switch, case
			try, catch, finally - exception handling
		looping
			for (specified number of loops)
			do-while (executes before checking the condition)
			while (checks the condition before executing)
			foreach (iterate through a collection)
		*/


		bool runChoice = true; 

		if( runChoice == true )
		{
			Console.WriteLine( "runChoice is true" );
		}

		else if( runChoice == false )
		{
			Console.WriteLine( "runChoice is false" );
		}

		else
		{
			Console.WriteLine( "runChoice is undefined/null" );
		}

		// Comparison operators ==, > , < , >=, <=, !=  (the ! - not - operator is very versatile!)

		if ( 5 > 4 )
		{
			Console.WriteLine("five is greater than four");
		}

		if ( 4 < 5 )
			Console.WriteLine( "four is less than five" );
		
	}
}
