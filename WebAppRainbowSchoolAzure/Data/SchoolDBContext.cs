using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppRainbowSchoolAzure.Models;

namespace WebAppRainbowSchoolAzure.Data
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext (DbContextOptions<SchoolDBContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppRainbowSchoolAzure.Models.Students> Students { get; set; } = default!;
    }
}
