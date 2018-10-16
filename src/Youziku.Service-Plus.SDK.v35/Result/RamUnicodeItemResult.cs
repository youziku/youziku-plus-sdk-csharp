using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Youziku.Service_Plus.SDK.SDK.Result
{
   public class RamUnicodeItemResult
    {
        /// <summary>
        /// FontFamily
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// FontFace
        /// </summary>
        public string FontFace { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        public string Tag { get; set; }


        /// <summary>
        /// ErrorMessage
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// NewContent
        /// </summary>
        public string NewContent { get; set; }
    }
}
