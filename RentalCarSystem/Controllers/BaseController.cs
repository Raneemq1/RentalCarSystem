using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Shared;

namespace RentalCarSystem.Controllers
{
    public class BaseController:Controller
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(HttpContext.Session.GetString("User") is null)
            {
                context.Result = RedirectToPage("/Account/Login", new { area = "Identity" });
                return;
            }
            base.OnActionExecuted(context);
        }
    }
}
