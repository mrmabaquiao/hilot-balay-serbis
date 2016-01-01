using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeService.Domain;
using HomeService.Web.Models;
namespace HomeService.Web.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork = null;

        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }


        public ActionResult Index()
        {
            var user = new ProfileDetailsViewModel();
            if (String.IsNullOrEmpty(User.Identity.Name))
            {
                RedirectToAction("Login", "Account");
            }

            using (var unitOfWork = new UnitOfWork())
            {
                var result = unitOfWork.GetProfileDetailsByUsername(User.Identity.Name);

                if (result != null)
                {
                    user = new ProfileDetailsViewModel()
                    {
                        Username = result.Username,
                        Name = result.Name,
                        ContactNumber = result.ContactNumber,
                        Profession = result.Profession,
                        ProfileId = result.ProfileId
                    };
                    return View(user);

                }
                else
                { 
                    return RedirectToAction("CreateProfile");
                }
            
            }   
         }

        public ActionResult CreateProfile()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateProfile(ProfileDetailsCreateModel profileCreateModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.InserProfileDetailsByUsername(profileCreateModel.Name, profileCreateModel.ContactNumber, profileCreateModel.Profession,User.Identity.Name);
                    unitOfWork.Save();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
          

        }       

        public ActionResult Search()
        {
            ViewBag.Message = "Search here.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Edit()
        {
            if (!String.IsNullOrEmpty(User.Identity.Name))
            {
                var result = unitOfWork.GetProfileDetailsByUsername(User.Identity.Name);

                if (result != null)
                {
                    var user = new ProfileDetailsViewModel()
                    {
                        Username = result.Username,
                        Name = result.Name,
                        ContactNumber = result.ContactNumber,
                        Profession = result.Profession
                    };

                    return View(user);
                }

                
            }

            return RedirectToAction("Login","Account");
        }

        [HttpPost]
        public ActionResult Edit(ProfileDetailsViewModel profile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.UpdateProfileDetailsByUsername(profile.Name, profile.ContactNumber, profile.Profession, User.Identity.Name);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}