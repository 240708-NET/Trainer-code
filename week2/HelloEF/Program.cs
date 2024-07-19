using System;
using Microsoft.EntityFrameworkCore;

namespace HelloEF
{
    class Program
    {
        public static void Main( string[] args )
        {
            Console.WriteLine( "Hello Again!" );
            // Pet MyPet = new Pet{ Id = 3, Name = "Claude", Cuteness = 10, Chaos = 1000, Species = "Hedgehog" };
            // MyPet.Speak();

            // Pet MyPet = CreatePet( MyPet );
            // List<Pet> petList = GetAllPets();
            // Pet returnedPet = GetPet( MyPet );
            // Pet returnedPet = GetPetById( 3 );
            // bool confirm = UpdatePet( MyPet );
            // bool confirm = DeletePet( MyPet );
            // bool confirm = DeletePetById( 2 );
            // bool confirm = DeletePetByName( "Claude" );
            // bool confirm = DeleteAllPets();

            // Console.WriteLine( MyPet.Speak() );
            // Console.WriteLine( returnedPet.Speak() );
            // Console.WriteLine( confirm );
            // foreach( var p in petList )
            //     Console.WriteLine( p.Speak() );

        // I struggled to get this bit working, but we found a way around it!
            //string ConnectionString = File.ReadAllText("./connectionstring");

            // DbContextOptionsBuilder<DataContext> ContextOptions = new DbContextOptionsBuilder<DataContext>().UseSqlServer(ConnectionString);
            // DataContext Context = new DataContext( ContextOptions.Options );
            // - Either Or - 
            // DbContextOptions<DataContext> ContextOptions = new DbContextOptionsBuilder<DataContext>().UseSqlServer(ConnectionString).Options;
            // DataContext Context = new DataContext( ContextOptions );
        }

        public static Pet GetPet( Pet MyPet )
        {
            using ( var context = new DataContext() )
            {
                //List<Pet> petList = context.Pets.ToList();
                // LINQ
                // Language Integrated Query
                // we need an enumarable of things/objects to search through, and we can query against that enumerable.

                var found = // could be a single thing, could be a collection...
                    from p in context.Pets.ToList()
                    where p.Name == MyPet.Name
                        && p.Cuteness == MyPet.Cuteness
                        && p.Chaos == MyPet.Chaos
                        && p.Species == MyPet.Species
                    select p;

                return found.FirstOrDefault();
            }
        }

        public static Pet GetPetById( int id )
        {
            using ( var context = new DataContext() )
            {
                Pet pet = context.Pets.Find(id);
                return pet;
            }
        }

        public static Pet CreatePet( Pet newPet )
        {
            using ( var context = new DataContext() )
            {
                context.Add(newPet); // we introduce the object to the context (local class)
                var returned = context.SaveChanges(); // we send/communicate to the db

                Console.WriteLine( returned );

                return GetPet(newPet);
            }
        }

        public static bool UpdatePet( Pet modifiedPet )
        {
            /*
            Return a boolean true/false to confirm if the modified pet was saved to the database correctly. 
            Accept the pet to be modified in the database, without changing the id of the existing entry in the database.

            Cursor Parking Lot:_____
            */


            return false;
        }

        public static bool DeletePet( Pet removePet )
        {
            /*
            Return a boolean true/false to confirm if the target pet was removed from the database correctly. 
            Accept the pet to be removed from the database.

            Cursor Parking Lot:_____
            */


            return false;
        }

        public static bool DeletePetById ( int id )
        {
            /*
            Return a boolean true/false to confirm if the target pet was removed from the database correctly. 
            Accept the id of the pet to be removed from the database.

            Cursor Parking Lot:_____
            */


            return false;
        }

        public static bool DeletePetByName ( string petName )
        {
            /*
            Return a boolean true/false to confirm if the target pet was removed from the database correctly. 
            Accept the name of the pet to be removed from the database.

            Cursor Parking Lot:_____
            */


            return false;
        }

        public static bool DeleteAllPets()
        {
            /*
            Return a boolean true/false to confirm if all pets were removed from the database correctly.

            Cursor Parking Lot:_____
            */


            return false;
        }

        public static List<Pet> GetAllPets()
        {
            /*
            Return a list of all pets in the database. 

            Cursor Parking Lot:_____
            */


            return new List<Pet>();
        }
    }

    class Pet
    {
        // POCO
        // Plain old c# object
        // Fields
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Cuteness { get; set; }
        public long? Chaos { get; set; }
        public string? Species { get; set; }

        // Constructors

        // Methods
        public string Speak()
        {
            return $"Hello, I'm {this.Name}! I have Id #{this.Id}, I'm {this.Cuteness} cute, {this.Chaos} chaotic, and a {this.Species}.";
        }
    }

    class DataContext : DbContext
    {
        // Fields
        public DbSet<Pet> Pets => Set<Pet>();

        // Constructors            
        //public DataContext( DbContextOptions<DataContext> options) : base( options ) {}

        //From Learn Entityr Framework Core
        string ConnectionString = File.ReadAllText("./connectionstring");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        
    }

}