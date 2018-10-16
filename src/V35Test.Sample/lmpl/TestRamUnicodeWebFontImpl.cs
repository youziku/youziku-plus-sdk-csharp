using Youziku.Service_Plus.SDK.Params;

namespace V35Test.Sample.lmpl
{
    public  class TestRamUnicodeWebFontImpl: BaseTestImpl,IInterfaceTest
    {
        public object Run()
        {
            var option = new RamSortUnicodeApiOption()
            {
                RanChinese = true,
                RanEnglish = true,
                RanNumber = true
            };

            var respone = YouzikuPlusClient.GetFontFace(new RamUnicodeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库,让中文跃上云端！ ",
              Option = option,
            });
          

            var woffRespone = YouzikuPlusClient.GetWoffFontFace(new RamUnicodeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库,让中文跃上云端！ ",
                Option = option,
            });
   
            return null;
        }
    }
}
