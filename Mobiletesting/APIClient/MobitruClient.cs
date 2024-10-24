using Mobiletesting.Constants.Endpoints;
using Mobiletesting.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.APIClient
{
    public class MobitruClient : BaseClient
    {
        public RestResponse GetAvailableDevicesInMobitru(string typeOfOS)
        {
            var endpoint = typeOfOS =="Android" ? MobitruDevicesEndpoints.AvailableAndroidDevicesDesiredCapabilitiesEndpoint : MobitruDevicesEndpoints.AvailableIOSDevicesDesiredCapabilitiesEndpoint;
            RestRequest request = new RestRequest(endpoint,Method.Get);
            RestClient client = GetClient();
            var response = client.Execute(request);
            return response;   
        }

        public MobileDevicesAvailableCapabilitiesModel GetAndroidDeviceRequirements()
        {
            var filePath = "C:\\Users\\Harshavardhan_Mitai\\Source\\Repos\\dot-net-training\\MobileCalculatorTesting\\Mobiletesting\\Mobiletesting\\Configurations\\RequiredAndroidDeviceConfigurationFile.json";
            var jsonString = File.ReadAllText(filePath);
            var androidRequirements = JsonConvert.DeserializeObject<MobileDevicesAvailableCapabilitiesModel>(jsonString);
            return androidRequirements;
        }
    }
}
