using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youziku.Service_Plus.SDK.Builder;
using Youziku.Service_Plus.SDK.Common;
using Youziku.Service_Plus.SDK.Core;
using Youziku.Service_Plus.SDK.Params;
using Youziku.Service_Plus.SDK.SDK.Result;


namespace Youziku.Service_Plus.SDK.Client
{
    public class YouzikuServicePlusClient : BaseServicePlusClient, IYouzikuServicePlusClient
    {
        #region YouzikuPlusConfig

        /// <summary>
        /// YouzikuPlusConfig
        /// </summary>
        private YouzikuPlusConfig _config;
        #endregion

        /// <summary>
        /// 初始化请求类库实例
        /// </summary>
        private void InitRequestInstance()
        {
            HttpRequestPlusClient = new TPlusWebRequest();
        }

        #region 构造一个YouzikuServicePlusClient
        /// <summary>
        /// 构造一个YouzikuServicePlusClient
        /// </summary>
        /// <param name="config">config</param>
        public YouzikuServicePlusClient(YouzikuPlusConfig config)
        {
            if (config == null) throw new ArgumentException(nameof(YouzikuPlusConfig) + " instance is null!");
            if (string.IsNullOrEmpty(config.Host)) throw new ArgumentException(nameof(YouzikuPlusConfig) + " field Url is null or Empty!");
            if (string.IsNullOrEmpty(config.ApiKey)) throw new ArgumentException(nameof(YouzikuPlusConfig) + " field ApiKey is null or Empty!");
            this._config = config;
            InitRequestInstance();
        }
        #endregion

        #region 构造一个YouzikuServicePlusClient
        /// <summary>
        /// 构造一个YouzikuServicePlusClient
        /// </summary>
        /// <param name="apiKey">apiKey</param>
        /// <param name="host">host</param>
        public YouzikuServicePlusClient(string apiKey, string host = YouzikuServiceClientPlusHostString.Http)
        {
            if (string.IsNullOrEmpty(host)) throw new ArgumentException(nameof(YouzikuPlusConfig) + " field host is null or Empty!");
            if (string.IsNullOrEmpty(apiKey)) throw new ArgumentException(nameof(YouzikuPlusConfig) + " field ApiKey is null or Empty!");
            this._config = new YouzikuPlusConfig { Host = host.Trim(), ApiKey = apiKey.Trim() };
            InitRequestInstance();
        }
        #endregion


        #region *混淆全部内容

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

        #endregion


        #region *混淆指定内容

        #region + GetScopeFontFace
        /// <summary>
        /// 请求GetFontFace接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public RamUnicodeItemResult GetScopeFontFace(RamUnicodeScopeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeScopeFontface(param, _config);
            return CommonGetFontFace<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.ScopeWebFont.GetFontface, _config);

        }
        #endregion

        #region + GetScopeWoffFontFace
        /// <summary>
        /// 请求GetWoffFontFace接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public RamUnicodeItemResult GetScopeWoffFontFace(RamUnicodeScopeFontApiParam param)
        {
            var paramDic = PlusParamBuilder.GetRamUnicodeScopeFontface(param, _config);
            return CommonGetFontFace<RamUnicodeItemResult>(paramDic, _config.Host + ServicePlusMethod.ScopeWebFont.GetWoffFontFace, _config);
        }
        #endregion 
      
        #endregion

    }
}
