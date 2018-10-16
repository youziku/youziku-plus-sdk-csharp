using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youziku.Service_Plus.SDK.Params;

namespace Youziku.Service_Plus.SDK.Params
{
    public class RamUnicodeScopeFontApiParam : RamUnicodeFontApiParam
    {
        /// <summary>
        /// 用户指定的范围文本
        /// </summary>
        public string Text { get; set; }
    }
}
