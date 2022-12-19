using Microsoft.AspNetCore;
using web_api;

WebHost.CreateDefaultBuilder(args)
    .UseStartup<Startup>()
    .Build()
    .Run();