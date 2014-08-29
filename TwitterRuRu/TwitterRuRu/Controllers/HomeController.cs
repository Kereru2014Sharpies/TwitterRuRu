using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TwitterRuRu.Models;

namespace TwitterRuRu.Controllers
{
    public class HomeController : Controller
    {   
        // Application DB context
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        // User manager - attached to application DB context
        protected UserManager<ApplicationUser> UserManager { get; set; }
        protected String CurrentUserId { get { return User.Identity.GetUserId(); } }
        //protected ApplicationUser CurrentUser { get { return UserManager.FindById(User.Identity.GetUserId()); } }


        public HomeController()
        {
                this.ApplicationDbContext = new ApplicationDbContext();
                this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.ApplicationDbContext));
        }

        //DL- could put the instantiations here and make them private and lazy loading so they only run when needed rather than every time the calss is called.
        public ActionResult Index()
        {
            HomeModel HomeModel = new HomeModel();
            HomeViewModel ViewModel = new HomeViewModel();
            ViewModel.Tweets = HomeModel.getTweetsUser(CurrentUserId);
            ViewModel.UserId = CurrentUserId;
            return View(ViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CreateTweet(HomeViewModel viewModel)
        {
            HomeModel HomeModel = new HomeModel();
            HomeModel.AddTweet(viewModel.Tweet, CurrentUserId);
            HomeViewModel ViewModel = new HomeViewModel();
            ViewModel.Tweets = HomeModel.getTweetsUser(CurrentUserId);
            ViewModel.UserId = CurrentUserId;
            return View("Index", ViewModel);
        }
    }
}