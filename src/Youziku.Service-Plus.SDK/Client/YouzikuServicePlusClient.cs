using System;
using System.Threading.Tasks;
using Youziku.Service_Plus.SDK.Builder;
using Youziku.Service_Plus.SDK.Client;
using Youziku.Service_Plus.SDK.Common;
using Youziku.Service_Plus.SDK.Config;
using Youziku.Service_Plus.SDK.Core;
using Youziku.Service_Plus.SDK.Params;
using Youziku.Service_Plus.SDK.SDK.Result;

namespace Youziku.Service_Plus.Client
{
    public class YouzikuServicePlusClient : BaseServicePlusClient, IYouzikuServicePlusClient
    {
        #region YouzikuPlusConfig

        /// <summary>
        /// YouzikuPlusConfig
        /// </summary>
        private YouzikuPlusConfig _config;
        #endregion

        #region 初始化请求类库实例
        /// <summary>
        /// 初始化请求类库实例
        /// </summary>
        /// <param name="config">config</param>
        private void InitRequestInstance(YouzikuPlusConfig config)
        {
            switch (config.RequestBehavior)
            {
                case RequestBehaviorEnum.HttpClient:
                    HttpRequestPlusClient = new TPlusHttpClient();
                    break;
                case RequestBehaviorEnum.HttpWebRequest:
                    HttpRequestPlusClient = new TPlusWebRequest();
                    break;

            }
        }
        #endregion

        #region 构造一个YouzikuServicePlusClient
        /// <summary>
        /// 构造一个YouzikuServicePlusClient
        /// </summary>
        /// <param name="config">config</param>
        public YouzikuServicePlusClient(YouzikuPlusConfig config)
        {
            if (config == null) throw new ArgumentException(nameof(YouzikuPlusConfig) + " instance is null!");
            if (string.IsNullOrWhiteSpace(config.Host)) throw new ArgumentException(nameof(YouzikuPlusConfig) + " field Url is null or Empty!");
            if (string.IsNullOrWhiteSpace(config.ApiKey)) throw new ArgumentException(nameof(YouzikuPlusConfig) + " field ApiKey is null or Empty!");
            this._config = config;
            InitRequestInstance(config);
            if (config.UseHttps)
            {
                YouzikuPlusGlobal.Config.UseHttps();
            }
        }
        #endregion

        #region 构造一个YouzikuServicePlusClient
        /// <summary>
        /// 构造一个YouzikuClient
        /// </summary>
        /// <param name="apiKey">apiKey</param>
        /// <param name="useHttps">host</param>
        public YouzikuServicePlusClient(string apiKey, bool useHttps)
        {

            if (string.IsNullOrEmpty(apiKey)) throw new ArgumentException(nameof(YouzikuPlusConfig) + " field ApiKey is null or Empty!");
            this._config = new YouzikuPlusConfig { Host = useHttps ? YouzikuServiceClientPlusHostString.Https : YouzikuServiceClientPlusHostString.Http, ApiKey = apiKey.Trim(), UseHttps = useHttps };
            InitRequestInstance(this._config);

            if (useHttps)
            {
                YouzikuPlusGlobal.Config.UseHttps();
            }
        }
        #endregion

        #region 构造一个YouzikuServicePlusClient
        /// <summary>
        /// 构造一个YouzikuClient
        /// </summary>
        /// <param name="apiKey">apiKey</param>
        /// <param name="host">host</param>
        public YouzikuServicePlusClient(string apiKey, string host = YouzikuServiceClientPlusHostString.Http)
        {
            if (string.IsNullOrWhiteSpace(host)) throw new ArgumentException(nameof(YouzikuPlusConfig) + " field host is null or Empty!");
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentException(nameof(YouzikuPlusConfig) + " field ApiKey is null or Empty!");
            this._config = new YouzikuPlusConfig { Host = host.Trim(), ApiKey = apiKey.Trim() };
            InitRequestInstance(this._config);
        }
        #endregion

        #region +GetFontFace 请求GetFontFace接口
        /// <summary>
        /// 请求GetFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        public RamUnicodeItemResult GetFontFace(RamUnicodeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeFontface(param, _config);
            return CommonGetFontFace<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.WebFont.GetFontface, _config);
        }
        #endregion

        #region +GetFontFaceAsync 请求GetFontFaceAsync接口[Async]
        /// <summary>
        /// 请求GetFontFaceAsync接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        public Task<RamUnicodeItemResult> GetFontFaceAsync(RamUnicodeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeFontface(param, _config);
            return CommonGetFontFaceAsync<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.WebFont.GetFontface, _config);
        }
        #endregion

        #region +GetWoffFontFace 请求GetWoffFontFace接口
        /// <summary>
        /// 请求GetWoffFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        public RamUnicodeItemResult GetWoffFontFace(RamUnicodeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeFontface(param, _config);
            return CommonGetFontFace<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.WebFont.GetWoffFontFace, _config);
        }
        #endregion

        #region +GetWoffFontFaceAsync 请求GetWoffFontFaceAsync接口[Async]
        /// <summary>
        /// 请求GetWoffFontFaceAsync接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        public Task<RamUnicodeItemResult> GetWoffFontFaceAsync(RamUnicodeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeFontface(param, _config);
            return CommonGetFontFaceAsync<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.WebFont.GetWoffFontFace, _config);
        }
        #endregion

        #region + GetScopeFontFace 请求GetScopeFontFace接口
        /// <summary>
        /// 请求GetScopeFontFace接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public RamUnicodeItemResult GetScopeFontFace(RamUnicodeScopeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeScopeFontface(param, _config);
            return CommonGetFontFace<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.ScopeWebFont.GetFontface, _config);
        }
        #endregion

        #region + GetScopeFontFaceAsync 请求GetScopeFontFaceAsync接口[Async]
        /// <summary>
        /// 请求GetScopeFontFaceAsync接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public Task<RamUnicodeItemResult> GetScopeFontFaceAsync(RamUnicodeScopeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeScopeFontface(param, _config);
            return CommonGetFontFaceAsync<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.ScopeWebFont.GetFontface, _config);
        }
        #endregion

        #region + GetScopeWoffFontFace 请求GetScopeWoffFontFace接口
        /// <summary>
        /// 请求GetScopeWoffFontFace接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public RamUnicodeItemResult GetScopeWoffFontFace(RamUnicodeScopeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeScopeFontface(param, _config);
            return CommonGetFontFace<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.ScopeWebFont.GetWoffFontFace, _config);
        }
        #endregion

        #region + GetScopeWoffFontFaceAsync 请求GetScopeWoffFontFaceAsync接口
        /// <summary>
        /// 请求GetScopeWoffFontFaceAsync接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public Task<RamUnicodeItemResult> GetScopeWoffFontFaceAsync(RamUnicodeScopeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeScopeFontface(param, _config);
            return CommonGetFontFaceAsync<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.ScopeWebFont.GetWoffFontFace, _config);
        }
        #endregion
    }
}
