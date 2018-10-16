using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youziku.Service_Plus.Client;
using Youziku.Service_Plus.SDK.Client;

namespace V45Test.Sample.lmpl
{
    public class BaseTestImpl
    {
        protected static readonly IYouzikuServicePlusClient YouzikuPlusClient =
            new YouzikuServicePlusClient(
                apiKey: "xxx"
            );
    }
}
