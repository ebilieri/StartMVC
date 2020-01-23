using Microsoft.EntityFrameworkCore;
using Start.UI.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Start.UI.Site.Data
{
    public class StartMVCDbContext :DbContext
    {
        public StartMVCDbContext(DbContextOptions<StartMVCDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
