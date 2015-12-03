using HomeService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeService.Web.Models;

namespace HomeService.Web.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address

        private UnitOfWork unitOfWork = null;

        public AddressController()
        {
            unitOfWork = new UnitOfWork();
        }
        public ActionResult Index()
        {
            if (!String.IsNullOrEmpty(User.Identity.Name))
            {
                var resultList = unitOfWork.GetProfileAddressByUsername(User.Identity.Name);

                if (resultList != null)
                {
                    var addressList = new List<AddressViewModel>();

                    foreach (var r in resultList)
                    {
                        var serviceLoc = new AddressViewModel()
                        {
                            Address1 = r.Address1,
                            Address2 = r.Address2,
                            Address3 = r.Address3,
                            AddressId = r.AddressId,
                            City = r.City,
                            State = r.State,
                            Country = r.Country,
                            PostalCode = r.PostalCode
                        };
                        addressList.Add(serviceLoc);
                    }

                    return View(addressList);
            }

            return View(new List<PointOfServiceViewModel>());
            }

            return RedirectToAction("Login", "Account");
        }

        // GET: Address/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            var addressCreateModel = new AddressCreateModel();
            var result = unitOfWork.CountryRepository.Get();
            addressCreateModel.Countries = new List<SelectListItem>();
           
           foreach(var res in result)
            {
                addressCreateModel.Countries.Add(new SelectListItem { Text = res.Name, Value = res.Code }); 
            }
            return View(addressCreateModel);
        }

        // POST: Address/Create
        [HttpPost]
        public ActionResult Create(AddressCreateModel addressCreateModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    //unitOfWork.InsertProfileAddress(addressCreateModel.Address1,
                    //                                addressCreateModel.Address2,
                    //                                addressCreateModel.Address3,
                    //                                addressCreateModel.City,
                    //                                addressCreateModel.PostalCode);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Address/Edit/5
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

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Address/Delete/5
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

        public JsonResult GetStates(string code)
        {
            List<SelectListItem> states = new List<SelectListItem>();

            var result = unitOfWork.GetStateByCountryCode(code);
            foreach(var res in result)
            {
                states.Add(new SelectListItem { Text = res.State, Value = res.State });
            }

            
            return Json(new SelectList(states, "Value", "Text"));
        }

        public JsonResult GetCities(string state)
        {
            List<SelectListItem> cities = new List<SelectListItem>();

            var result = unitOfWork.GetCityByState(state);
            foreach (var res in result)
            {
                cities.Add(new SelectListItem { Text = res.City, Value = res.CityId.ToString() });
            }

            return Json(new SelectList(cities, "Value", "Text"));
        }
    }
}
