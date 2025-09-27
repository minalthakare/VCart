using System.Collections.Generic;

public interface ICategoryService
{
    List<CategoryModel> GetAll();

    CategoryModel GetById(int id);

    void Create(CategoryModel category);

    void Update(CategoryModel category);

    void Delete(int id);
}