using EdaMonicaBookStore.DataAccess.Repository.IRepository;
using EdaMonicaBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using EdaMonicaBookStore.Utility;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaMonicaBookStore.Areas.Admin.Controllers
{


    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id) //action method for Upsert
        {
            CoverType coverType = new CoverType();
            if (id == null)
            {
                //this is for create
                return View(coverType);
            }

            //this is for edit
            var parameter = new DynamicParameters();
            parameter.Add("@Id", id);
            coverType = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            if (coverType == null)
            {
                return NotFound();
            }
            return View(coverType);
        }
        //use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType coverType)
        {
            if (ModelState.IsValid) //checks all validations in the model(e.g. Name Required) to increase security

            {
                var parameter = new DynamicParameters();
                parameter.Add("@Name", coverType.Name);
                if (coverType.Id == 0)


                {
                    _unitOfWork.CoverType.Add(coverType);
                }

                else
                {
                    _unitOfWork.CoverType.Update(coverType);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(coverType);
        }



        //API calls here

        //API calls here
        #region #region API CALLS
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.CoverType.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });

            }
            _unitOfWork.CoverType.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion





    }

}
