using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using restauranter.Models;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace restauranter.Controllers
{
        public class HomeController : Controller
    {

         private RestaurantContext _context;
 
        public HomeController(RestaurantContext context)
        {
            _context = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("reviews")]
        public IActionResult Landing()
        {
            List<Review> allReviews = _context.reviews.OrderByDescending(review => review.id).ToList();
            @ViewBag.reviews = allReviews;
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateReview(ReviewViewModel myReview)
        {
            if(ModelState.IsValid){
                if(myReview.visit_date >DateTime.Today){
                    // ModelState.AddModelError("date", "Date cannot set to future date!");
                    return View("Index");
                }
                // Review newReview = new Review{
                //     reviewer = myReview.reviewer,
                //     restaurant = myReview.restaurant,
                //     review = myReview.review,
                //     stars = myReview.stars,
                //     visit_date = myReview.visit_date
                // };
            _context.Add(myReview);
            _context.SaveChanges();
            return RedirectToAction("Landing");
            }else{
                ViewBag.errors = ModelState.Values;
                return View("Index");
            }

        }
    }
}
//
