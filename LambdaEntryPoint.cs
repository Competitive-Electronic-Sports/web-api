using Amazon.Lambda.AspNetCoreServer;
using Microsoft.AspNetCore;
using web_api;

namespace web_api;

public class LambdaEntryPoint : APIGatewayHttpApiV2ProxyFunction
{
    public void Main(string[] args)
    {
        CreateHostBuilder().Build().Run();
    }
    
    protected override void Init(IWebHostBuilder builder)
    {
        builder
            .UseStartup<Startup>();
    }
}

