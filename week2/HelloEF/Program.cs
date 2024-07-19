using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelloEF
{
    class Program
    {
        // Fields

        // Methods
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Again!");
            // Example usage
            Pet MyPet = new Pet { Name = "Sil", Cuteness = 9, Chaos = 100, Species = "Cat" };

            // MyPet = CreatePet(MyPet);
            // List<Pet> petList = GetAllPets();
            // Pet returnedPet = GetPet(MyPet);
            // returnedPet = GetPetById(3);
            // bool confirm = UpdatePet(MyPet);
            // bool confirm = DeletePet(MyPet);
            // bool confirm = DeletePetById(2);
            // bool confirm = DeletePetByName("Claude");
            bool confirm = DeleteAllPets();

            // Console.WriteLine(returnedPet?.Speak());
            Console.WriteLine(confirm);
            // foreach (var p in petList)
            //     Console.WriteLine(p.Speak());
        }

        public static Pet GetPet(Pet MyPet)
        {
            using (var context = new DataContext())
            {
                var found = from p in context.Pets.ToList()
                            where p.Name == MyPet.Name
                               && p.Cuteness == MyPet.Cuteness
                               && p.Chaos == MyPet.Chaos
                               && p.Species == MyPet.Species
                            select p;

                return found.FirstOrDefault();
            }
        }

        public static Pet GetPetById(int id)
        {
            using (var context = new DataContext())
            {
                Pet pet = context.Pets.Find(id);
                return pet;
            }
        }

        public static Pet CreatePet(Pet newPet)
        {
            using (var context = new DataContext())
            {
                context.Add(newPet);
                context.SaveChanges();
                return GetPet(newPet);
            }
        }

        public static bool UpdatePet(Pet modifiedPet)
        {
            using (var context = new DataContext())
            {
                Pet savedPet = context.Pets.Find( modifiedPet.Id );


                // if (context.Pets.Find(modifiedPet.Id) != null)
                if ( savedPet != null)
                {
                    // context.Add(modifiedPet);
                    savedPet.Name = modifiedPet.Name;
                    savedPet.Cuteness = modifiedPet.Cuteness;
                    savedPet.Chaos = modifiedPet.Chaos;
                    savedPet.Species = modifiedPet.Species;                    
                    
                     // only happens to the context, not the db yet...
                    context.SaveChanges(); // until we save to the db
                    // Would retun context.SaveChanges() > 1 work?
                    return true;
                }
                return false;
            }
            
        }

        public static bool DeletePet(Pet removePet)
        {
            using (var context = new DataContext())
            {
                bool check = true;

                if(context.Pets.Contains(removePet))
                {   
                    Console.WriteLine("Pet was removed!");
                    context.Pets.Remove(removePet);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Pet was NOT removed!");
                    check = false;
                }
                
                return check;

                /* this should be just 1 loop
                var removedPet = context.Pets.Remove(removePet);
                context.Pets.SaveChanges();
                return removedPet == null; //this may or may not work
                */

                /*
                    But wouldn't this run through the list twice? Instead of just once if Pet
                    is not in the list?
                    
                    What you have though would work for sure.
                
                I think this will work as well -Jean-Luc
                context.Remove(removePet); //This will track regardless if the object exists or not
                context.SaveChanges(); // TThis will call and attempt to delete but will just not update any rows when called
                
                Pet pet = GetPet(removePet); // This will check if the pet exists
                return pet == null; // This will return null or a pet (true or false);

                context.Pet.Remove also could return null on non-exist entries

                so it should be like this then?
                int changes = context.SaveChanges();
                if (changes == 0)
                    return false;
                else
                    return true;
    
                */
            }
        }

        public static bool DeletePetById(int id)
        {
            using (var context = new DataContext())
            {
                var pet = context.Pets.Find(id);
                if (pet != null)
                {
                    context.Pets.Remove(pet);
                    context.SaveChanges();
                    return !context.Pets.Contains(pet);
                }
                return false;
            }
        }

        public static bool DeletePetByName(string petName)
        {
            using (var context = new DataContext())
            {
                var pets = from p in context.Pets.ToList()
                           where p.Name == petName
                           select p;
                bool deleted = false;
                 
                foreach (var pet in pets)
                {
                    context.Pets.Remove(pet);
                    deleted = true;
                }

                context.SaveChanges();
                return deleted;
            }
        }

        public static bool DeleteAllPets()
        {
            using (var context = new DataContext())
            {
                // alt: context.Pets.RemoveRange(context.Pets);
                foreach (var pet in context.Pets)
                {
                    context.Pets.Remove(pet);
                    // alt2: DeletePet(pet);
                }
                context.SaveChanges();
                return !context.Pets.Any();
                // alt3: context.Database.ExecuteSqlCommand("TRUNCATE TABLE Pets");
            }
        }

        public static List<Pet> GetAllPets()
        {
            using (var context = new DataContext())
            {
                Console.WriteLine( context.Pets.Local );
                Console.WriteLine( context.Pets.Count() );
                return context.Pets.ToList();
            }
        }
    }

    class Pet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Cuteness { get; set; }
        public long? Chaos { get; set; }
        public string? Species { get; set; }
        // public int OwnerID { get; set; }; // 1-1
        public List<Owner> Owners { get; set; } // 1-m

        public string Speak()
        {
            return $"Hello, I'm {this.Name}! I have Id #{this.Id}, I'm {this.Cuteness} cute, {this.Chaos} chaotic, and a {this.Species}.";
        }
    }

    class Owner
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Pet> Pets { get; set; } // m-m

        public string Speak()
        {
            return $"Hello, I'm {this.Name}.";
        }
    }

    class DataContext : DbContext
    {
        public DbSet<Pet> Pets => Set<Pet>();
        public DbSet<Owner> Owners => Set<Owner>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = File.ReadAllText("./connectionstring");
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}