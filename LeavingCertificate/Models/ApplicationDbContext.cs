using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LeavingCertificate.Models
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Environment.CurrentDirectory + @"\DB\LeavingCert.db";
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        public DbSet<Stream> Streams { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<LeavingCertDetail> LeavingCertDetails { get; set; }
        public DbSet<SchoolDetail> SchoolDetails { get; set; }
    }
}
