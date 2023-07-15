using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using NuGet.DependencyResolver;
using System.Diagnostics;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //   return View("Privacy");//it will explicitly look for Privacy Page in Views folder in Home folder
            //in Privacy.cshtml

            // return View("~/views/article/index.cshtml");// if we want to render different views from the home folder it will look for 
            //like i want to render aricle folder having Index is going to render it will look for that file-like views folder having 
            //article folder in that index.cshtml
            return View( );//if nothing is mentioned that time it will look for in Views folder in Home folder then it will
            //look for index.cshtml as the action name is that.
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    //Types of Views
    //----------------------
    //1>standard view style-like aboutus page and contactus page
    //2>strongly typed views-like it is dependent on model class inside the model box we have property
    // (like username and password) login page,sign in page,product liting page (whenever we are taking i/p through it to model)

    //3>partial views-right side bar,footer aand header which views we can reuse that time only we can use the partial views
    //how we can use header and footer the container part we are controlling through the dynamic part based on the routing
    //"_" is used to represnt the partialview-example-_Header
    //4>layout-consistent look,its a masterview.
    //whenever something coming from database the dynamic section that can be reuse then we are using view component
    //partialview of for static,in new MVC for .net core we can't use partialview for dynamic view.
    // if a controller can have two types of method regular method and action method,
    //regular method can be private protected and internal but in case of action method we are having public modifier that is action method
    //actiion method can be acess by using request to the method.
    //for Actionresult we have different type result like content result,file result,json result or partialview result or redirect funtion for going one page to another page
    //this return type result depending on the Data. object can be there, IactionResut is interface and its implenemting ViewResult.
    //after rendering page we can see the ctrl+u to see the source code.
}