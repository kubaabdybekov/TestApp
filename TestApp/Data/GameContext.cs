using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Data
{
    public class GameContext: DbContext
    
       {
            public GameContext(DbContextOptions<GameContext> options)
                : base(options)
            {
            }

            public DbSet<Game> Game { get; set; }
        }
}
