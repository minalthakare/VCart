using System.Collections.Generic;

public interface ICategoryRepository
{
    List<Category> GetAll();

    Category GetById(int id);

    void Create(Category category);

    void Update(Category category);

    void Delete(int id);
}