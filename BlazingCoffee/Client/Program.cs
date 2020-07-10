using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Xml.Serialization;
using BlazingCoffee.Services;

namespace BlazingCoffee.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddTelerikBlazor();

            builder.Services.AddHttpClient<PublicClient>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            builder.Services.AddHttpClient("BlazingCoffee.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                            .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddTransient(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazingCoffee.ServerAPI"));

            builder.Services.AddApiAuthorization();
            builder.Services.AddLocalization(opts => { opts.ResourcesPath = "Resources"; });

            await builder.Build().RunAsync();
        }
    }
}
