using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftWorksStaffApi.Data
{
    public class SoftWorksStaffApiDbContext : DbContext 
    {
        public SoftWorksStaffApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Model.Staff> Staffs { get; set; }


    }
}
