using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeService.Domain;
using HomeService.Web.Models;
using System.Web.Mvc;

namespace HomeService.Web.Controllers
{
    public class PromotionController : Controller
    {
        // GET: Promotion
        public ActionResult Index()
        {
           var promotion = new PromotionViewModel();
            using (var unitOfWork = new UnitOfWork())
            {
               
               var result = unitOfWork.GetPromotionDetailByUsername(User.Identity.Name);

                if (result != null)
                {
                    promotion = new PromotionViewModel()
                    {
                        PromotionId = result.PromotionId,
                        Description = result.Description,
                        EndDate = result.EndDate,
                        Expertise = result.Expertise,
                        Price = result.Price,
                        StartDate = result.StartDate

                    };
                    var resultTags = unitOfWork.GetPromotionTagsByPromotionId(promotion.PromotionId).Select(x => new TagViewModel()
                    {
                        Tag = x.Tag,
                        TagId = x.TagId

                    }
                    );

                    promotion.Tags = resultTags.ToList();
                }
                else
                {
                    return RedirectToAction("Create");
                }             
            }
                return View(promotion);
        }

        // GET: Promotion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Promotion/Create
        public ActionResult Create()
        {
            var promotion = new PromotionCreateModel();
           
            return View(promotion);
        }

        // POST: Promotion/Create
        [HttpPost]
        public ActionResult Create(PromotionCreateModel promotion)
        {
            String[] stringList = new String[50];
            try
            {
                if (ModelState.IsValid)
                {
                    if (!String.IsNullOrEmpty(promotion.Tags))
                    {
                         stringList = promotion.Tags.Split(',');

                    }

                    using (var unitOfWork = new UnitOfWork())
                    {
                        var promId = unitOfWork.InsertPromotionDetailsByUsername(promotion.Price,promotion.Description,promotion.StartDate,promotion.EndDate,User.Identity.Name);
                        if (promId.HasValue)
                        {
                            foreach (var s in stringList.ToList())
                            {
                                if (!String.IsNullOrEmpty(s))
                                {
                                    var tag = s.Trim();
                                    unitOfWork.InsertPromotionTag(promId, tag);
                                }

                            }
                        }


                    }

                }

                    return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Promotion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Promotion/Edit/5
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

        // GET: Promotion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Promotion/Delete/5
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
