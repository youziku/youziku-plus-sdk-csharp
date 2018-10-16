using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youziku.Service_Plus.SDK.Params;

namespace Youziku.Service_Plus.SDK.Params
{
  public  class RamUnicodeFontApiParam
    {
        /// <summary>
        /// UserId+FontId对应的GUID
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// 要生成的字体的内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 是否使用随机生成的FontFamily
        /// </summary>
        public bool UseRanFontFamily { get; set; }


        public RamSortUnicodeApiOption Option { get; set; }
    }
}
