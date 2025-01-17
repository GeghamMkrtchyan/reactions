using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace GhostNetwork.Reactions.Api
{
    public class OperationIdFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (context.ApiDescription.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            {
                operation.OperationId =
                    $"{controllerActionDescriptor.ControllerName}_{controllerActionDescriptor.ActionName.Replace("Async", string.Empty)}";
            }
        }
    }
}