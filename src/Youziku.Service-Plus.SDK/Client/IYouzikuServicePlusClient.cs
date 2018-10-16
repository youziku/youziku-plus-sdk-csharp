
using System.Threading.Tasks;
using Youziku.Service_Plus.SDK.Params;
using Youziku.Service_Plus.SDK.SDK.Result;

namespace Youziku.Service_Plus.SDK.Client
{
    public interface IYouzikuServicePlusClient
    {

        #region *全部内容混淆

        #region +GetFontFace 请求GetFontFace接口
        /// <summary>
        /// 请求GetFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        RamUnicodeItemResult GetFontFace(RamUnicodeFontApiParam param);
        #endregion

        #region +GetFontFaceAsync 请求GetFontFaceAsync接口[Async]
        /// <summary>
        /// 请求GetFontFaceAsync接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        Task<RamUnicodeItemResult> GetFontFaceAsync(RamUnicodeFontApiParam param);
        #endregion

        #region +GetWoffFontFace 请求GetWoffFontFace接口
        /// <summary>
        /// 请求GetWoffFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        RamUnicodeItemResult GetWoffFontFace(RamUnicodeFontApiParam param);
        #endregion

        #region +GetWoffFontFaceAsync 请求GetWoffFontFaceAsync接口[Async]
        /// <summary>
        /// 请求GetWoffFontFaceAsync接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        Task<RamUnicodeItemResult> GetWoffFontFaceAsync(RamUnicodeFontApiParam param);
        #endregion

        #endregion

        #region *指定内容混淆

        #region + GetScopeFontFace 请求GetFontFace接口
        /// <summary>
        /// 请求GetFontFace接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        RamUnicodeItemResult GetScopeFontFace(RamUnicodeScopeFontApiParam param);
        #endregion

        #region + GetScopeFontFaceAsync请求GetScopeFontFaceAsync接口[Async]
        /// <summary>
        /// 请求GetScopeFontFaceAsync接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        Task<RamUnicodeItemResult> GetScopeFontFaceAsync(RamUnicodeScopeFontApiParam param);
        #endregion

        #region + GetScopeWoffFontFace 请求GetScopeWoffFontFace接口
        /// <summary>
        /// 请求GetScopeWoffFontFace接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        RamUnicodeItemResult GetScopeWoffFontFace(RamUnicodeScopeFontApiParam param);
        #endregion 

        #region + GetScopeWoffFontFaceAsync请求GetScopeWoffFontFaceAsync接口[Async]
        /// <summary>
        /// 请求GetScopeWoffFontFaceAsync接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        Task<RamUnicodeItemResult> GetScopeWoffFontFaceAsync(RamUnicodeScopeFontApiParam param);
        #endregion 

        #endregion

    }
}
