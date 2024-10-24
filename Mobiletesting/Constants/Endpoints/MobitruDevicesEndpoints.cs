using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.Constants.Endpoints
{
    public class MobitruDevicesEndpoints
    {
        /// <summary>
        /// This gets the the available devices in Android In Mobitru
        /// </summary>
        public static string AvailableAndroidDevicesDesiredCapabilitiesEndpoint = "https://app.mobitru.com/billing/unit/personal/automation/api/device/android";

        /// <summary>
        ///  This gets the the available devices in IOS In Mobitru
        /// </summary>
        public static string AvailableIOSDevicesDesiredCapabilitiesEndpoint = "https://app.mobitru.com/billing/unit/personal/automation/api/device/ios";
    }
}
