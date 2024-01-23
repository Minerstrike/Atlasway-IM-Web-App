using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AtlaswayInternalAPI.Authentication;


public class ApiKeyAuthFilter : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        if (context.HttpContext.Request.Headers.TryGetValue(AuthConstants.ApiKeyHeaderName, out var extractedApiKey) is not true)
        {
            context.Result = new UnauthorizedObjectResult("API key missing.");
            return;
        }

        var configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
        var apiKey              = configuration.GetValue<string>(AuthConstants.ApiKeySectionName);

        if (apiKey?.Equals(extractedApiKey) is not true)
        {
            context.Result = new UnauthorizedObjectResult("Invalid API key.");
            return;
        }
    }
}
