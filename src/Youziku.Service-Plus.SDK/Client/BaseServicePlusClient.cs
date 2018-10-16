using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Youziku.Service_Plus.SDK.Config;
using Youziku.Service_Plus.SDK.Core;

namespace Youziku.Service_Plus.SDK.Client
{
    public class BaseServicePlusClient
    {

        /// <summary>
        /// 发起Http请求类库
        /// </summary>
        public HttpRequestPlusClient HttpRequestPlusClient { get; set; }

        #region +CommonGetFontFace 通用请求GetFontFace
        /// <summary>
        /// 通用请求GetFontFace
        /// </summary>
        /// <param name="paramDic">请求参数</param>
        /// <param name="url">接口路径</param>
        /// <param name="config">config</param>
        /// <returns></returns>
        protected TResult CommonGetFontFace<TResult>(IDictionary<string, string> paramDic, string url, YouzikuPlusConfig config) where TResult : class, new()
        {
            try
            {

                var jsonResult = HttpRequestPlusClient.Request(url, TPlusHttpMethod.Post, paramDic, config.TimeOut);
                if (string.IsNullOrEmpty(jsonResult)) throw new ArgumentException("接口响应null或Empty!");
                return new JavaScriptSerializer().Deserialize<TResult>(jsonResult);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region +CommonGetFontFaceAsync 通用请求GetFontFace[Async]
        /// <summary>
        /// 通用请求CommonGetFontFaceAsync
        /// </summary>
        /// <param name="paramDic">请求参数</param>
        /// <param name="url">接口路径</param>
        /// <param name="config">config</param>
        /// <returns></returns>
        protected async Task<TResult> CommonGetFontFaceAsync<TResult>(IDictionary<string, string> paramDic, string url, YouzikuPlusConfig config) where TResult : class, new()
        {
            try
            {

                var jsonResult =await HttpRequestPlusClient.RequestAsync(url, TPlusHttpMethod.Post, paramDic, config.TimeOut);
                if (string.IsNullOrEmpty(jsonResult)) throw new ArgumentException("接口响应null或Empty!");
                return new JavaScriptSerializer().Deserialize<TResult>(jsonResult);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }
}
