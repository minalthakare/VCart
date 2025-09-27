using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
public class CategoryRepository : ICategoryRepository
{
    VCartDbContext _context;

    public CategoryRepository(VCartDbContext context)
    {
        _context = context;
    }

    public void Create(Category category)
    {
       _context.Categories.Add(category);  
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
       Category category = _context.Categories.Find(id);
        _context.Categories.Remove(category);
        _context.SaveChanges();
    }

    public List<Category> GetAll()
    {
        return _context.Categories.ToList();
    }

    public Category GetById(int id)
    {
       return _context.Categories.Find(id); 
    }

    public void Update(Category category)
    {
        _context.Categories.Attach(category);
        _context.Entry(category).State= EntityState.Modified;
        _context.SaveChanges();
    }
}
