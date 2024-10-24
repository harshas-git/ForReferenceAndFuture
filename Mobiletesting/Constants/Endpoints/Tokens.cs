using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.Constants.Endpoints
{
    public static class Tokens
    {
        public static string AccessToken = "mobitru_ak_sIEHbTVtxZH2p01UpjLcVi_ai7awvMMNfph3Qw7gbHAXCCqf8bX7pSEB5BNIt1EuLDBOiFFazS9zWwQM3Ui";

        public static string MobitruServerURL = $"https://personal:{AccessToken}@app.mobitru.com/wd/hub";
    }
}
