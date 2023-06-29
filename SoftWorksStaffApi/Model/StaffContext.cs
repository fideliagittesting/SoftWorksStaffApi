﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftWorksStaffApi.Model
{
    public class StaffContext : DbContext 
    {
        public StaffContext(DbContextOptions<StaffContext> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }
        public DbSet<Staff> Staffs { get; set; }
    }
}
