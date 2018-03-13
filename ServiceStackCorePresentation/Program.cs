using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using ServiceStack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ServiceStack.Configuration;
using Funq;


namespace ServiceStackCorePresentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseStartup<Startup>()
                    .UseUrls(Environment.GetEnvironmentVariable("ASPNETCORE_URLS"))                    
                    .Build();
            
                    host.Run();


        }

        
    }
}
