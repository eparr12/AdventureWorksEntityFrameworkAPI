using AdventureWorksAPI;

var builder = WebApplication.CreateBuilder(args)
              .RegisterServices();

var app = builder.Build()
          .SetupMiddleware();

app.ConfigureApi();

app.Run();