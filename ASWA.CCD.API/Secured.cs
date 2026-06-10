using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ASWA.CCD.API;

public class Secured(ILogger<Secured> logger)
{
    [Function("SecuredGet")]
    public IActionResult RunGet([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "secured")] HttpRequest req)
    {
        return new OkObjectResult(
            new
            {
                TheAnswerToTheUltimateQuestionOfLifeTheUniverseAndEverything = 42
            });
    }

    [Function("SecuredPost")]
    public IActionResult RunPost([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "secured")] HttpRequest req)
    {
        return new OkObjectResult(new { Message = "Sorry, you cannot post things here :)" });
    }
}