using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.Models
{
    public class DesiredCapabilities
    {
        public string platformName { get; set; }
        public string platformVersion { get; set; }
        public string deviceName { get; set; }
        public string udid { get; set; }
        public string dc { get; set; }
        public string automationName { get; set; }
    }

    public class MobileDevicesAvailableCapabilitiesModel
    {
        public DesiredCapabilities desiredCapabilities { get; set; }
    }

}
