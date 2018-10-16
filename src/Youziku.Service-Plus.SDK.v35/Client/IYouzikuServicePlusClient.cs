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

        #region +GetWoffFontFace 请求GetWoffFontFace接口
        /// <summary>
        /// 请求GetWoffFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        RamUnicodeItemResult GetWoffFontFace(RamUnicodeFontApiParam param);
        #endregion

        #endregion

        #region *指定内容混淆

        #region + GetScopeFontFace
        /// <summary>
        /// 请求GetFontFace接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        RamUnicodeItemResult GetScopeFontFace(RamUnicodeScopeFontApiParam param);
        #endregion

        #region + GetScopeWoffFontFace
        /// <summary>
        /// 请求GetWoffFontFace接口
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        RamUnicodeItemResult GetScopeWoffFontFace(RamUnicodeScopeFontApiParam param);
        #endregion 

        #endregion

    }
}
