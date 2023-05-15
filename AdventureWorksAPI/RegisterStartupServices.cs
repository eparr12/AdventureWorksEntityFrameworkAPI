
using Microsoft.AspNetCore.Http.Json;
using System.Text.Json.Serialization;

namespace AdventureWorksAPI
{
    public static class RegisterStartupServices
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddHttpClient();
            builder.Services.Configure<JsonOptions>(options =>
            {
                options.SerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            });

            return builder;
        }
    }
}
