using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Youziku.Service_Plus.SDK.Common
{
    public static class ServicePlusMethod
    {
        /// <summary>
        /// WebFont,全部内容混淆生成方法名
        /// </summary>
        public class WebFont
        {
            /// <summary>
            /// 接口方法GetFontFace()
            /// </summary>
            public const string GetFontface = "/ramUnicodeWebFont/getFontFace";


            /// <summary>
            /// 接口方法GetWoffBase64StringFontFace()
            /// </summary>
            public const string GetWoffFontFace = "/ramUnicodeWebFont/getWoffFontFace";
        }

        /// <summary>
        /// ScopeWebFont,指定内容混淆生成方法名
        /// </summary>
        public class ScopeWebFont
        {
            /// <summary>
            /// 接口方法GetFontFace()
            /// </summary>
            public const string GetFontface = "/ramUnicodeScopeWebFont/getFontFace";


            /// <summary>
            /// 接口方法GetWoffFontFace()
            /// </summary>
            public const string GetWoffFontFace = "/ramUnicodeScopeWebFont/getWoffFontFace";
        }

    }
}
