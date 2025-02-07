using GreenChillyShop.DataAccess;
using GreenChillyShop.DataAccess.Repository.IRepository;
using GreenChillyShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenChillyShop.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork    = unitOfWork;
        }
        public   IActionResult Index()
        {
            List<Category>categories= _unitOfWork.Category.GetAll().ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
