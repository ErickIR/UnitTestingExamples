using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Todo> Todos { get; set; }

    }
}
