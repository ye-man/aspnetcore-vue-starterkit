using Microsoft.AspNetCore.Mvc;

namespace server.Helpers.Errors
{
    public class ErrorObjectResult : ObjectResult
    {
        public ErrorObjectResult(object o) : base(o) { }
    }
}