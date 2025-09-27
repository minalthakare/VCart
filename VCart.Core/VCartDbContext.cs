using System.Data.Entity;

public class VCartDbContext : DbContext
{
    public VCartDbContext() : base("name=VCartDbContext")
    {

    }
     public DbSet<Category> Categories { get; set; }    
}