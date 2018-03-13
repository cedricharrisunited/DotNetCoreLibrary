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
using DOTNETCoreProxy = DotNetCore.United.Services.FlightShopping.Common;


namespace ServiceStackCorePresentation.Services
{

    [Route("/FlightShopping", Verbs = "POST")]
    public class ShopRequest : DOTNETCoreProxy.ShopRequest, IReturn<ShopResponse>
    {
        public string Name { get; set; }
    }

    public class ShopResponse
    {
        public string Result { get; set; }
    }


    public class FlightShoppingPresentation : Service
    {
        public object Post(ShopRequest request)
        {
            System.Random rnd = new System.Random();
            int rndValue = rnd.Next(0,10);

            return new ShopResponse { Result = $"Hello, {request.Name}  this your request number : {rndValue}!" };
        }
    }
}
