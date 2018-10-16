using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youziku.Service_Plus.SDK.Params;

namespace V35Test.Sample.lmpl
{
  public  class TestRamUnicodeScopeWebFontImpl : BaseTestImpl, IInterfaceTest
    {
        public object Run()
        {
            var option = new RamSortUnicodeApiOption()
            {
                RanChinese = true,
                RanEnglish = true,
                RanNumber = true
            };

            var respone = YouzikuPlusClient.GetScopeFontFace(new RamUnicodeScopeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端 ",
                Option = option,
                Text = "有字库",
                Tag = "#yzk"
            });


            var woffRespone = YouzikuPlusClient.GetScopeWoffFontFace(new RamUnicodeScopeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端",
                Option = option,
                Text = "有字库",
                Tag = "#yzk"
            });

            return null;
        }
    }
}
