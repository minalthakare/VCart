using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VCart.Web.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Category
        public ActionResult Index()
        {
            var categories = _categoryService.GetAll();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            CategoryModel category = _categoryService.GetById(id ?? 0);

            return View(category);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Create(category);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            CategoryModel category = _categoryService.GetById(id ?? 0);

            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]

        public ActionResult Delete(int? id)
        {
            CategoryModel category = _categoryService.GetById(id ?? 0);
            return View(category);
        }

        [HttpPost]
        [ActionName("Delete")]

        public ActionResult DeleteConfirmed(int? id)
        {
            _categoryService.Delete(id ?? 0);
            return RedirectToAction("Index");
        }
        
    }
}