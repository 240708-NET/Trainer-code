namespace DuckData.Models
{
    public class Duck
    {
        // Fields
        public int ID { get; set; }
        public string color { get; set; }
        public int numFeathers { get; set; } 
        private static int IDCounter = 0;

        // Constructors
        public Duck (int ID, string color, int Feathers)
        {
            this.ID = ID;
            this.color = color;
            this.numFeathers = Feathers;
        }

        public Duck (string Color, int Feathers)
        {
            this.color = Color;
            this.numFeathers = Feathers;
            this.ID = IDCounter;
            IDCounter++;
        }

        public Duck(){}

        // Methods
        public void Quack()
        {
            Console.WriteLine( "Quack! I'm {0}!", this.color );
        }

        public string ToString()
        {
            string result = "";
            result = this.ID + " " + this.color + " " + this.numFeathers;
            return result;
        }

    }
}