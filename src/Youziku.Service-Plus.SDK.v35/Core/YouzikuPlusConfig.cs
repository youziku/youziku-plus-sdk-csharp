using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youziku.Service_Plus.SDK.Common;

namespace Youziku.Service_Plus.SDK.Core
{
    public class YouzikuPlusConfig : RequestBasePlusParam
    {
        /// <summary>
        /// 配置接口地址
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 配置发送请求超时时间[单位：分钟]，默认5分钟
        /// </summary>
        public int TimeOut { get; set; } = 5;

    }
}
