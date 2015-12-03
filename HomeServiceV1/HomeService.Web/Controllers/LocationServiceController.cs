using HomeService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeService.Web.Models;

namespace HomeService.Web.Controllers
{
    public class LocationServiceController : Controller
    {


        private UnitOfWork unitOfWork = null;

        public LocationServiceController()
        {
            unitOfWork = new UnitOfWork();
        }
        // GET: LocationService
        public ActionResult Index()
        {
            if (!String.IsNullOrEmpty(User.Identity.Name))
            {
                var resultList = unitOfWork.GetServiceLocationByUsername(User.Identity.Name);

                if (resultList != null)
                {
                    var serviceLocList = new List<PointOfServiceViewModel>();

                    foreach (var r in resultList)
                    {
                        var serviceLoc = new PointOfServiceViewModel()
                        {
                            City = r.City,
                            State = r.State
                        };
                        serviceLocList.Add(serviceLoc);
                    }

                    return View(serviceLocList);
                } 
                               
                return View(new List<PointOfServiceViewModel>());
            }

            return RedirectToAction("Login", "Account");

            
        }

        // GET: LocationService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LocationService/Create
        public ActionResult Create()
        {
            var model = new PointOfServiceViewModel();
            var resultState = unitOfWork.GetStateByCountryCode("PH").FirstOrDefault().State;
            var cityList = new List<SelectListItem>();
            var resultCity = unitOfWork.GetCityByState(resultState);
            foreach(var res in resultCity)
            {
                cityList.Add(new SelectListItem() { Text = res.City, Value = res.CityId.ToString() });
            }
            model.CityList = cityList;
            model.State = resultState;
            return View(model);
        }

        // POST: LocationService/Create
        [HttpPost]
        public ActionResult Create(PointOfServiceViewModel pos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.InsertServiceLocationByProfileUsername(int.Parse(pos.City), User.Identity.Name);
                    
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LocationService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocationService/Edit/5
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

        // GET: LocationService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocationService/Delete/5
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
