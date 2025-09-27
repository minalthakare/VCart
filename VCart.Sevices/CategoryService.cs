using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class CategoryService : ICategoryService
{
    ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void Create(CategoryModel category)
    {
        Category cat = new Category()
        {
            Id = category.Id,
            Name = category.Name , 
            Merchantname = category.Merchantname
       
        };

        _categoryRepository.Create(cat);
    }

    public void Delete(int id)
    {
       _categoryRepository.Delete(id);
    }

    public List<CategoryModel> GetAll()
    {
        var dbCategories = _categoryRepository.GetAll();
        var categories = dbCategories.Select(c =>
        new CategoryModel() { Id = c.Id, Name = c.Name, Merchantname = c.Merchantname }).ToList();

        return categories;  
    }

    public CategoryModel GetById(int id)
    {
      Category category= _categoryRepository.GetById(id);

        return new CategoryModel()
        { Id = category.Id, 
          Name = category.Name, 
          Merchantname = category.Merchantname
        };
    }

    public void Update(CategoryModel category)
    {
       Category cat = new Category()
        {
          Id = category.Id, 
          Name = category.Name, 
          Merchantname = category.Merchantname
        };

        _categoryRepository.Update(cat);
    }
}
