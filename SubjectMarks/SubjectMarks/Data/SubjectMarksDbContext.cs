using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectMarks.Models;

namespace SubjectMarks.Data
{
    public class SubjectMarksDbContext : DbContext
    {
        public SubjectMarksDbContext (DbContextOptions<SubjectMarksDbContext> options)
            : base(options)
        {
        }

        public DbSet<SubjectMarks.Models.RainbowSchool> RainbowSchool { get; set; } = default!;
    }
}
