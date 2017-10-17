using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Tests
{
    public class TestDbContext : ToDoListContext
    {
        public override DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;database=todolist_test;uid=root;pwd=root;");
        }
    }
}
