using System.Threading.Tasks;
using V45Test.Sample;
using V45Test.Sample.lmpl;
using Youziku.Service_Plus.SDK.Params;

namespace V35Test.Sample.lmpl
{
    public class TestRamUnicodeWebFontImpl : BaseTestImpl, IInterfaceTestAsync
    {
        public async Task<object> Run()
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
                    "有字库，让中文跃上云端！",
                Option = option,
                Tag = "#yzk"
            });


            var woffRespone = YouzikuPlusClient.GetWoffFontFace(new RamUnicodeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Tag = "#yzk"
            });

            var responeAsync = await YouzikuPlusClient.GetFontFaceAsync(new RamUnicodeFontApiParam
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Tag = "#yzk"
            });


            var woffResponeAsync = await YouzikuPlusClient.GetWoffFontFaceAsync(new RamUnicodeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Tag = "#yzk"
            });

            return null;
        }
    }
}
