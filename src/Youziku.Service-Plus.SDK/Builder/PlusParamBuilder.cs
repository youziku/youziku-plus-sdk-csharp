using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youziku.Service_Plus.SDK.Config;
using Youziku.Service_Plus.SDK.Params;
using Youziku.Service_Plus.SDK.Validate;

namespace Youziku.Service_Plus.SDK.Builder
{
    public class PlusParamBuilder
    {
        #region + 混淆全部内容
        /// <summary>
        /// GetFontface接口
        /// </summary>
        /// <param name="param">param</param>
        /// <param name="config">config</param>
        /// <returns></returns>
        public static IDictionary<string, string> GetRamUnicodeFontface(RamUnicodeFontApiParam param, YouzikuPlusConfig config)
        {
            PlusParamValidate.GetRamUnicodeFontface(param);
            var paramDic = new Dictionary<string, string>
            {
                {"ApiKey", config.ApiKey},
                {"AccessKey", param.AccessKey},
                {"Content", param.Content.Replace("&",string.Empty)},
                {"Tag", param.Tag},
                {"UseRanFontFamily", param.UseRanFontFamily.ToString()},
                {"Option[RanNumber]",param.Option.RanNumber.ToString() },
                {"Option[RanEnglish]",param.Option.RanEnglish.ToString() },
                {"Option[RanChinese]",param.Option.RanChinese.ToString() }
            };
            return paramDic;
        }
        #endregion


        #region + 混淆指定内容
        /// <summary>
        /// GetScopeFontface接口
        /// </summary>
        /// <param name="param">param</param>
        /// <param name="config">config</param>
        /// <returns></returns>
        public static IDictionary<string, string> GetRamUnicodeScopeFontface(RamUnicodeScopeFontApiParam param, YouzikuPlusConfig config)
        {
            PlusParamValidate.GetRamUnicodeScopeFontface(param);
            var paramDic = new Dictionary<string, string>
            {
                {"ApiKey", config.ApiKey},
                {"AccessKey", param.AccessKey},
                {"Content", param.Content.Replace("&",string.Empty)},
                {"Text", param.Text},
                {"Tag", param.Tag},
                {"UseRanFontFamily", param.UseRanFontFamily.ToString()},
                {"Option[RanNumber]",param.Option.RanNumber.ToString() },
                {"Option[RanEnglish]",param.Option.RanEnglish.ToString() },
                {"Option[RanChinese]",param.Option.RanChinese.ToString() }
            };
            return paramDic;
        }
        #endregion

    }
}
