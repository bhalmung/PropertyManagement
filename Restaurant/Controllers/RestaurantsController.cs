using DomainLogic.Serivce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModels;
namespace Restaurant.Controllers
{
    
 
    public class RestaurantsController: Controller           
        {
        IRestaurentService _RestaurentService;
        public RestaurantsController(IRestaurentService s)
        {
            _RestaurentService = s;
        }
        public ActionResult Index()
        {
            var s = _RestaurentService.GetAllRestaurent();
           

            return View(s);
        }

        public ActionResult Details(int id)
        {
            var s = _RestaurentService.GetByRestaurantId(id);


            return View(s);
        }

        public ActionResult Edit(int RestorantID=0)
        {
            var Resturant = RestorantID == 0 ?
                new DomainModels.Restaurant()
                : _RestaurentService.GetByRestaurantId(RestorantID);



            return View(Resturant);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DomainModels.Restaurant Restaurant)
        {
            if (ModelState.IsValid)
            {

                _RestaurentService.UpAdd(Restaurant);
                
                return RedirectToAction("Index");
            }else
            {
                return View(Restaurant);
            }
        }
        [HttpDelete]
        public ActionResult Delete(int RestaurantID)
        {
            _RestaurentService.Delete(RestaurantID);
                return RedirectToAction("Index");
        }
    }
}