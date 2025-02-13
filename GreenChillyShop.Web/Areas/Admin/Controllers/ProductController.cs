using GreenChillyShop.DataAccess;
using GreenChillyShop.DataAccess.Repository.IRepository;
using GreenChillyShop.Models;
using GreenChillyShop.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GreenChillyShop.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Product> lstProducts = _unitOfWork.Product.GetAll().ToList();
            return View(lstProducts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ProductVM productVM = new()
            {
                CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Product = new Product()
            };
          /*  if (id == null || id == 0)
            {
                //create
                return View(productVM);
            }
            else
            {
                //update
                productVM.Product = _unitOfWork.Product.Get(u => u.Id == id);
                return View(productVM);
            }*/

            return View(productVM);
        }
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            /* if (ModelState.IsValid)
             {
                 string wwwRootPath = _webHostEnvironment.WebRootPath;
                 if (file != null)
                 {
                     string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                     string productPath = Path.Combine(wwwRootPath, @"images\product");

                     if (!string.IsNullOrEmpty(productVM.Product.ImageUrl))
                     {
                         //delete the old image
                         var oldImagePath =
                             Path.Combine(wwwRootPath, productVM.Product.ImageUrl.TrimStart('\\'));

                         if (System.IO.File.Exists(oldImagePath))
                         {
                             System.IO.File.Delete(oldImagePath);
                         }
                     }

                     using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                     {
                         file.CopyTo(fileStream);
                     }

                     productVM.Product.ImageUrl = @"\images\product\" + fileName;
                 }

                 if (productVM.Product.Id == 0)
                 {
                     _unitOfWork.Product.Add(productVM.Product);
                 }
                 else
                 {
                     _unitOfWork.Product.Update(productVM.Product);
                 }

                 _unitOfWork.Save();
                 TempData["success"] = "Product created successfully";
                 return RedirectToAction("Index");
             }
             else
             {
                 productVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                 {
                     Text = u.Name,
                     Value = u.Id.ToString()
                 });
                 return View(productVM);
             }*/

            return View();
        }
    }
}
