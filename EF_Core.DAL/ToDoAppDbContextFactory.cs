using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.DAL
{
    public class ToDoAppDbContextFactory : IDesignTimeDbContextFactory<TodoDBContext>
    {
        public ToDoAppDbContextFactory()
        {

        }

        public TodoDBContext CreateDbContext(string[] arg)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TodoDBContext>();
            var connectionString = @"Data Source=DESKTOP-J6DGDP2;Initial Catalog=ToDoListDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connectionString);
            return new TodoDBContext(optionsBuilder.Options);
        }
        public int Id { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
