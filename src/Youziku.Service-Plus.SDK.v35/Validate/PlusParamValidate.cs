using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youziku.Service_Plus.SDK.Params;

namespace Youziku.Service_Plus.SDK.Validate
{
    public static class PlusParamValidate
    {

        #region  + static GetRamUnicodeFontface 
        /// <summary>
        /// 验证GetRamUnicodeFontface接口
        /// </summary>
        /// <param name="param">请求参数</param>
        public static void GetRamUnicodeFontface(RamUnicodeFontApiParam param)
        {
            if (param == null) throw new ArgumentException(nameof(RamUnicodeFontApiParam) + " instance is null!");
            if (string.IsNullOrEmpty(param.AccessKey)) throw new ArgumentException(nameof(RamUnicodeFontApiParam) + " field AccessKey is null or Empty!");
            if (string.IsNullOrEmpty(param.Content)) throw new ArgumentException(nameof(RamUnicodeFontApiParam) + " field Content is null or Empty!");
        }
        #endregion

        #region  + static GetRamUnicodeScopeFontface 
        /// <summary>
        /// 验证GetRamUnicodeScopeFontface接口
        /// </summary>
        /// <param name="param">请求参数</param>
        public static void GetRamUnicodeScopeFontface(RamUnicodeScopeFontApiParam param)
        {
            if (param == null) throw new ArgumentException(nameof(RamUnicodeScopeFontApiParam) + " instance is null!");
            if (string.IsNullOrEmpty(param.AccessKey)) throw new ArgumentException(nameof(RamUnicodeScopeFontApiParam) + " field AccessKey is null or Empty!");
            if (string.IsNullOrEmpty(param.Content)) throw new ArgumentException(nameof(RamUnicodeScopeFontApiParam) + " field Content is null or Empty!");
        }
        #endregion

    }
}
