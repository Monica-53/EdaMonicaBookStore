﻿using Microsoft.AspNetCore.Mvc;
using EdaMonicaBookStore.Models;
using EdaMonicaBookStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaMonicaBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id) //action method for Upsert
        {
            Category category = new Category();
            if (id == null)
            {
                //this is for create
                return View(category);
            }

            //use HTTP POST to define the post-action method
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Upsert(Category category)
            {
                if(ModelState.IsValid) //checks all validations in the model(e.g. Name Required) to increase security
                    if(category.Id ==0)
                    {
                        _unitOfWork.Category.Add(category);
                        _unitOfWork.Save();
                    }
                    else
                    {
                        _unitOfWork.Category.Update(category);
                    }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(category);

            //this is for edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }

            return View();
            //API calls here
        }
        //API calls here
        #region #region API CALLS
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion





    }

}

