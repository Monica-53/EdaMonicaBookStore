using Microsoft.AspNetCore.Mvc;
using EdaMonicaBookStore.Models;
using EdaMonicaBookStore.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaMonicaBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)  //get action method for Upsert
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };  //using MonicaBookStore.Models;
            if (id == null)
            {
                // this is for create
                return View(productVM);
            }
            // this is for edit
            productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (productVM.Product == null)
            {
                return NotFound();
            }
            return View(productVM);
            //return View(product);
            //}

            //API calls here
            #region API CALLS

            [HttpGet]
            public IActionResult GetAll()
            {
                var allObj = _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");
                return Json(new { data = allObj });
            }

            [HttpDelete]
            public IActionResult Delete(int id)
            {
                var objFromDb = _unitOfWork.Product.Get(id);
                if (objFromDb == null)
                {
                    return Json(new { success = true, message = "Delete Successful" });

                    _unitOfWork.Product.Remove(objFromDb);
                    _unitOfWork.Save();
                    return Json(new { success = true, message = "Delete Successful" });
                }

                #endregion
            }
        }
    }
}


