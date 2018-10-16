using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Youziku.Service_Plus.SDK.Params
{
    public class RamSortUnicodeApiOption
    {
        /// <summary>
        /// 数字乱序
        /// </summary>
        public bool RanNumber { get; set; }

        /// <summary>
        ///英文乱序
        /// </summary>
        public bool RanEnglish { get; set; }

        /// <summary>
        /// 中文乱序
        /// </summary>
        public bool RanChinese { get; set; }

    }
}
