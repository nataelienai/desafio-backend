using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DesafioBackend.Filters;

public class GenericExceptionFilter : ExceptionFilterAttribute
{
  public override void OnException(ExceptionContext context)
  {
    context.Result = new JsonResult(new 
    {
      message = "An error occurred while processing the request"
    });
    context.HttpContext.Response.StatusCode = 500;
    context.ExceptionHandled = true;
  }
}
