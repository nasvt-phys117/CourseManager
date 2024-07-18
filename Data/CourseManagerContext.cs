﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseManager.Models;

namespace CourseManager.Data
{
    public class CourseManagerContext : DbContext
    {
        public CourseManagerContext (DbContextOptions<CourseManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
