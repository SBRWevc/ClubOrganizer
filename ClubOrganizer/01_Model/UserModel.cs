using Microsoft.EntityFrameworkCore;

using System;
using System.IO;

namespace ClubOrganizer._01_Model
{
    public class UserModel
    {
        public int ID { get; set; }

        public string Login { get; set; }
        public byte[] PassHash { get; set; }
        public byte[] Salt { get; set; }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }

        public string Position { get; set; }
        public bool Root { get; set; }

        public byte[]? Avatar { get; set; }
    }

    public class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo DirInfo = new(Environment.CurrentDirectory + @"\DB");
            if (DirInfo.Exists!)
            {
                DirInfo.Create();
            }

            optionsBuilder.UseSqlite("Data Source=user.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().ToTable("Users");
        }
    }
}
