using System.Net;

namespace Youziku.Service_Plus.SDK.Config
{
    public class YouzikuPlusGlobal
    {
        private YouzikuPlusGlobal()
        {

        }
        public static readonly YouzikuPlusGlobal Config = new YouzikuPlusGlobal();

        #region+UseHttps  启动Https
        /// <summary>
        /// 启动Https
        /// </summary>
        public YouzikuPlusGlobal UseHttps()
        {
            //https配置
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback =
                (sender, certificate, chain, errors) => true;
            return this;
        }
        #endregion
    }
}
