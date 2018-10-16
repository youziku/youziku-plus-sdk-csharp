# 一、介绍

## 1．SDK适用语言<br/>
SDK适用于在C#(或其他.NET框架下语言)中调用<a  target="_blank"  href="http://service.youziku.com">service.youziku.com</a>中的反爬虫api<br/>

## 2.工作流程<br/>　　
   ①用户用后端程序调用SDK，提交动态内容到有字库的反爬虫服务器<br/>
   ②服务器接收到所提交内容后，根据内容生成反爬虫策略文件<br/>
   ③服务器将所有文件上传至阿里云CDN，并返回@font-face语句和混淆后的内容<br/>
   ④内容显示时，只需要显示混淆后的内容即可，@font-face语句会让内容还原成可阅读状态<br/>

## 3.@font-face语句<br/>
SDK的返回值主要内容是@font-face语句，@font-face语句是CSS3中的一个功能模块，是所有浏览器天然支持的CSS语句。它的作用是将一个远程字体文件加载到当前页面，并且定义成一个字体，前端页面能够像使用本地字体一样使用该字体。@font-face语句是实现在线字体效果的核心代码。<br/>

## 4. 显示字体效果
用户<a href="#user-content-4自定义路径生成模式">自定义字体存放路径</a>，当需要显示字体效果时，可以根据自己所定义的路径<a href="http://service.youziku.com/index.html#format" target="_blank" style="color: #ff7e00;">拼组出@font-face语句</a>，然后将语句输出到前端页面，即可使内容显示字体效果。

# 二、环境
1. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk下载/v3.5.zip">下载SDK</a>(兼容.NET Framework version 3.5及以上所有版本；) <br />
2. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk下载/v4.5.zip">下载SDK</a>(兼容.NET Framework version 4.5及以上所有版本；增加对异步调用[使用async和await]的支持)

# 三、引用
## 1.添加引用（Youziku.Service-Plus.SDK.dll）

# 四、Sample
## 1.初始化YouzikuServicePlusClient实例,在全局配置一遍即可
```csharp 
public static readonly IYouzikuServicePlusClient youzikuClient = new YouzikuServicePlusClient("xxxxxx");//apiKey
```
## 2.调用接口
### 2.1.处理全部文本-所有格式
同步调用
``` csharp 
          var option = new RamSortUnicodeApiOption()
            {
                //处理汉字
                RanChinese = true,
                //处理字母
                RanEnglish = true,
                //处理数字
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

```
异步调用
``` csharp 

      var option = new RamSortUnicodeApiOption()
            {
                //处理汉字
                RanChinese = true,
                //处理字母
                RanEnglish = true,
                //处理数字
                RanNumber = true
            };
     var responeAsync = await YouzikuPlusClient.GetFontFaceAsync(new RamUnicodeFontApiParam
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Tag = "#yzk"
            });

```
### 2.2.处理全部文本-WOFF

同步调用
``` csharp 
          var option = new RamSortUnicodeApiOption()
            {
                //处理汉字
                RanChinese = true,
                //处理字母
                RanEnglish = true,
                //处理数字
                RanNumber = true
            };

            var respone = YouzikuPlusClient.GetWoffFontFace(new RamUnicodeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Tag = "#yzk"
            });

```
异步调用
``` csharp 

      var option = new RamSortUnicodeApiOption()
            {
                //处理汉字
                RanChinese = true,
                //处理字母
                RanEnglish = true,
                //处理数字
                RanNumber = true
            };
     var responeAsync = await YouzikuPlusClient.GetWoffFontFaceAsync(new RamUnicodeFontApiParam
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Tag = "#yzk"
            });

```

### 2.3.处理指定文本-所有格式
同步调用
``` csharp

          var option = new RamSortUnicodeApiOption()
            {
                //处理汉字
                RanChinese = true,
                //处理字母
                RanEnglish = true,
                //处理数字
                RanNumber = true
            };

            var respone = YouzikuPlusClient.GetScopeFontFace(new RamUnicodeScopeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Text = "有字库",
                Tag = "#yzk"
            });

```
异步调用
``` csharp
          var option = new RamSortUnicodeApiOption()
            {
                //处理汉字
                RanChinese = true,
                //处理字母
                RanEnglish = true,
                //处理数字
                RanNumber = true
            };
           var responeAsync= await YouzikuPlusClient.GetScopeFontFaceAsync(new RamUnicodeScopeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Text = "有字库",
                Tag = "#yzk"
            });
            
```

### 2.3.处理指定文本-WOFF
同步调用
``` csharp

          var option = new RamSortUnicodeApiOption()
            {
                //处理汉字
                RanChinese = true,
                //处理字母
                RanEnglish = true,
                //处理数字
                RanNumber = true
            };

            var respone = YouzikuPlusClient.GetScopeWoffFontFace(new RamUnicodeScopeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Text = "有字库",
                Tag = "#yzk"
            });

```
异步调用
``` csharp
          var option = new RamSortUnicodeApiOption()
            {
                //处理汉字
                RanChinese = true,
                //处理字母
                RanEnglish = true,
                //处理数字
                RanNumber = true
            };
           var responeAsync= await YouzikuPlusClient.GetScopeWoffFontFaceAsync(new RamUnicodeScopeFontApiParam()
            {
                AccessKey = "xxx",
                UseRanFontFamily = true,
                Content =
                    "有字库，让中文跃上云端！",
                Option = option,
                Text = "有字库",
                Tag = "#yzk"
            });
            
```
