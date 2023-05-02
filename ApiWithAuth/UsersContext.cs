using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiWithAuth;

public class UsersContext : IdentityUserContext<IdentityUser>
{
    public UsersContext (DbContextOptions<UsersContext> options)
        : base(options)
    {
    }
        
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // It would be a good idea to move the connection string to user secrets
        options.UseNpgsql("Host=db;Database=appdb;Username=postgres;Password=password");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}