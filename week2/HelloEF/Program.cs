using System;
using Microsoft.EntityFrameworkCore;

namespace HelloEF
{
    class Program
    {
        public static void Main( string[] args )
        {
            Console.WriteLine( "Hello Again!" );

            Pet MyPet = new Pet{ Name = "Sil", Cuteness = 9, Chaos = 100, Species = "Cat" };
            Console.WriteLine( MyPet.Speak() );

            //string ConnectionString = File.ReadAllText("./connectionstring");

            // DbContextOptionsBuilder<DataContext> ContextOptions = new DbContextOptionsBuilder<DataContext>().UseSqlServer(ConnectionString);
            // DataContext Context = new DataContext( ContextOptions.Options );
            // - Either Or - 
            // DbContextOptions<DataContext> ContextOptions = new DbContextOptionsBuilder<DataContext>().UseSqlServer(ConnectionString).Options;
            // DataContext Context = new DataContext( ContextOptions );
           
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
            return $"Hello, I'm {this.Name}!";
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