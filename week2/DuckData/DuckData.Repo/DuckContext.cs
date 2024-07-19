using System;
using Microsoft.EntityFrameworkCore;
using DuckData.Models;

namespace DuckData.Repo
{
    public class DuckContext : DbContext
    {
        public DbSet<Duck> Ducks => Set<Duck>();

        public DuckContext( DbContextOptions<DuckContext> options) : base( options ){}

    }



}
