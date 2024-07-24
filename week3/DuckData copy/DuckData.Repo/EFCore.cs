using System;
using DuckData.Models;
using Microsoft.EntityFrameworkCore;

namespace DuckData.Repo
{
    public class EFCore : IRepository
    {
        static readonly string connectionstring = "";
        static DuckContext context;

        public EFCore( string SC )
        {
            DbContextOptions<DuckContext> options;
            options = new DbContextOptionsBuilder<DuckContext>()
                .UseSqlServer(connectionstring)
                .Options;
            context = new DuckContext(options);
        }

        public void SaveDuck(Duck myDuck)
        {
            context.Ducks.Add(myDuck);
            context.SaveChanges();
        }

        public void SaveAllDucks(List<Duck> duckList)
        {
            foreach (Duck d in duckList)
            {
                context.Ducks.Add(d);
            }
            context.SaveChanges();
        }

        public List<Duck> LoadAllDucks ()
        {
            return context.Ducks.ToList();;
        }

        public Duck GetDuckById ( int id )
        {
            Duck foundDuck = context.Ducks.Find(id);
            return foundDuck;
        }

        public void DeleteDuckById ( int id )
        {
            Duck foundDuck = context.Ducks.Find(id);
            context.Ducks.Remove(foundDuck);
        }
    }
}


