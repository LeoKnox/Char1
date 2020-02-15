using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcChar.Models;

namespace MvcChar.Data
{
    public class MvcCharContext : DbContext
    {
        public MvcCharContext (DbContextOptions<MvcCharContext> options)
            : base(options)
        {
        }

        public DbSet<MvcChar.Models.Character> Character { get; set; }
    }
}
