using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[NonAction]//if we dont want in the controller it is to be action method that time we can  decorate as NONaction method
        public int  Add(int x, int y)
        {
            return x + y;
        }
    }
}
