using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace MVCApplication.Components
{
   //any viewcomponent derived from viewcomponent class.
    public class CommentsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)

        {
            //TO DO

            List<string> comments = new List<string> { "good" , "keep it up" };
            return View("~/views/components/_comments.cshtml", comments);

        }
    }
}
