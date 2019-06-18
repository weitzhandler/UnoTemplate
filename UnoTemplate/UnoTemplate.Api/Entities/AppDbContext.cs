using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UnoTemplate.Entities
{
  public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      var user = new User
      {
        Id = 1,
        Email = "john@doe.com",
        UserName = "john",
        PasswordHash = new PasswordHasher<User>().HashPassword(null, "yxR5KKVD")
      };                                                                        

      builder.Entity<User>().HasData(user);
    }

    public DbSet<Todo> Todos { get; set; }
  }
}
