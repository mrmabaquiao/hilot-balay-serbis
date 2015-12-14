using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeService.Domain;
using HomeService.Web.Models;

namespace HomeService.Web.Controllers
{
    public class ProfileController : Controller
    {
        private UnitOfWork unitOfWork = null;

        public ProfileController()
        {
            unitOfWork = new UnitOfWork();
        }
        // GET: Profile
        public ActionResult Index()
        {
            var pList = new List<ProfileDetailsViewModel>();
            var profileList = unitOfWork.ProfileDetailsRepository.Get();

            foreach (var p in profileList)
            {   
                pList.Add(new ProfileDetailsViewModel()
                {
                    ProfileId = p.ProfileId,
                    Name = p.ProfileName,
                    ContactNumber = p.ContactNumber,
                    Profession = p.Profession,
                    Username = p.Username
                });
            }
            return View(pList);
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Profile/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Profile/Create
        [HttpPost]
        public ActionResult Create(ProfileDetailsCreateModel profileCreateModel)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {   
                    unitOfWork.InsertProfileDetails(profileCreateModel.Name, profileCreateModel.ContactNumber, profileCreateModel.Profession);
                   
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Profile/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
