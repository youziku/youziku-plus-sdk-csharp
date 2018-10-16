using Youziku.Service_Plus.SDK.Client;

namespace V35Test.Sample.lmpl
{
    public class BaseTestImpl
    {
        protected static readonly IYouzikuServicePlusClient YouzikuPlusClient =
            new YouzikuServicePlusClient(
                apiKey: "xxx"
               
            );
    }
}
