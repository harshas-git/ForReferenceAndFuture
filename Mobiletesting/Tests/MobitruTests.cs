using Mobiletesting.APIClient;
using Mobiletesting.Models;
using Mobiletesting.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.Tests
{
    [TestFixture]
    public class MobitruTests : MobitruBaseTest
    {
        [Test]
        public void SampleMobitruTest()
        {
            MobitruClient mobitruClient = new MobitruClient();
            var availableDevices =mobitruClient.GetAvailableDevicesInMobitru("Android");
            var devices= JsonConvert.DeserializeObject<List<MobileDevicesAvailableCapabilitiesModel>>(availableDevices.Content);
            var androidRequirements = mobitruClient.GetAndroidDeviceRequirements();

            MobitruDevicePage mobitruDevicePage = new MobitruDevicePage(appiumDriver);
            mobitruDevicePage.ClickOnPlayStore();
        }
    }
}
