class Program
{
	// Fields

	// Methods

	static void Main( string[] args )
	{
		Console.WriteLine( "High/Low Running" );

		// Singleton - you create a single instance of a thing that is referenced throughout the application to complete some functionality.
		// create an instance of the Game class
		Game newGame = new Game(); 


		int roundCount = newGame.PlayGame();


		
		// newGame.guessString = "4";
		// //newGame.set_guessString("4");
		// newGame.roundCount = 2;

/*

	// In Softwre Development Life Cycle (SDLC) a user story is a way to track a feature

	// computer should choose a random number (within reason)
	// user should be able to submit guesses to the computer
	// if the guess is higher than the target number the computer should say so
	// if the guess is lower than the targer number, the computer should say so
	// a user wins when they guess the target number
	// a user should keep guessing untill they guess the correct target number
		
		// Variables
		int targetNumber;
		int guessNumber;
		int roundCount = 0;
		string guessString;

		// Creating a random number
		Random rand = new Random();
		targetNumber = rand.Next(11);


		// a for loop may not know when to stop looping!
		// a foreach is right out! nothing to iterate!
		// a while loop would work... but...
		// becuase a do while loop will execute at least once, it'll work just right!

		do {
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
*/
		Console.WriteLine( "Thanks for playing!" );
		Console.WriteLine( "You took {0} rounds to guess the answer!", roundCount );
	}	
}
