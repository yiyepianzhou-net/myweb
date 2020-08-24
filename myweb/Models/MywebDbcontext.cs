using Microsoft.EntityFrameworkCore;

namespace myweb.Models
{
    public class MywebDbcontext:DbContext
    {
        public MywebDbcontext(DbContextOptions<MywebDbcontext> options): base(options)
        { }

        public DbSet<User> users { get; set; }

        public DbSet<Room> rooms { get; set; }
    }
}
