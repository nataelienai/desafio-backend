using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace DesafioBackend.Filters;

public class ExecutionDurationActionFilter : ActionFilterAttribute
{
  private Stopwatch? _stopwatch;

  public override void OnActionExecuting(ActionExecutingContext context)
  {
    _stopwatch = Stopwatch.StartNew();
  }

  public override void OnActionExecuted(ActionExecutedContext context)
  {
    _stopwatch!.Stop();

    var executionDuration = _stopwatch.ElapsedMilliseconds;

    Console.WriteLine($"Execution duration: {executionDuration}ms");
  }
}
