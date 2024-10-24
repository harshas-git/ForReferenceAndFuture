using Mobiletesting.Constants.Endpoints;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.APIClient
{
    public abstract class BaseClient
    {
        public  RestClient restClient;
        RestClientOptions restClientOptions;
        RestRequest restRequest;
        public BaseClient() 
        {
            restClientOptions = new RestClientOptions();
            restClientOptions.Authenticator = new RestSharp.Authenticators.JwtAuthenticator(Tokens.AccessToken);
            restClient = new RestClient(restClientOptions);
        }

        public RestClient GetClient() 
        {
            return restClient;
        }

    }
}
