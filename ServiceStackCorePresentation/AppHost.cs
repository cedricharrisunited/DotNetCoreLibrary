using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ServiceStack;
using Funq;
using ServiceStackCorePresentation.Services;
using ServiceStack.Configuration;
using ServiceStack.Api.Swagger;



namespace ServiceStackCorePresentation
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base(nameof(ServiceStackCorePresentation), typeof(FlightShoppingPresentation).Assembly)
        {
            var appSettings = new EnvironmentVariableSettings();
            ServiceStack.Licensing.RegisterLicense(appSettings.Get<string>("ServiceStackLicenseKey", string.Empty));
        }

        public override void Configure(Container container)
        {           
            this.Plugins.Add(new SwaggerFeature());

        }

    }
}
