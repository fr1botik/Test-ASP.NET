﻿using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}

