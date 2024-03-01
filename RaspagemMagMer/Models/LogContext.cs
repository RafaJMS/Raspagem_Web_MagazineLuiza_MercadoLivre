﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspagemMagMer.Models
{
    public class LogContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RAFAELMECENAS\\DBPRACTICE;Database=ScrapingDb;User Id=sa;Password=senha123;");
        }
    }
}
