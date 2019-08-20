using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoCheckpoint
{
    class ToDosContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new
                DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase =
                ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(
                ProjectBase.FullName, "ToDos.db");

            optionsBuilder.UseSqlite("Data Source="
                + DatabaseFile);
        }
    }
}