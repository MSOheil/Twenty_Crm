namespace Twenty_Crm_Presentation.Attributes;
public class ApiKeyAuthorizationFilterAttribute : ActionFilterAttribute
{ 
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var serviceProvider = context.HttpContext.RequestServices;
        var configuration = serviceProvider.GetService<IConfiguration>();

        if (configuration == null)
        {
            throw new InvalidOperationException("IConfiguration is not available.");
        }

        //var serverApiKey = configuration.GetSection("ApiKey")["GateWayKey"];

        //var apiKey = context.HttpContext.Request.Headers["ApiKey"].ToString();

        //if (!serverApiKey.Equals(apiKey))
        //{
        //    context.Result = new UnauthorizedResult();
        //    return;
        //}

        base.OnActionExecuting(context);
    }
}
