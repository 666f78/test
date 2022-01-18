using HtmlAgilityPack;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Text;

namespace ParseMusicSite
{
    internal class Program
    {
        static void Main()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            SiteParse("https://www.amalgama-lab.com/songs/s/slipknot/before_i_forget.html");
        }

        static void SiteParse(string url)
        {            
            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(url);

            var parse = new ParseText();

            parse.engLang = new ParseEngText().ParseText(doc);
            parse.ruLang = new ParseRuText().ParseText(doc);

            parse.ShowText();
        }

    }
}

































//static void AppParse()
//{
//    WindowsDriver<WindowsElement> notepad;
//    AppiumOptions des = new AppiumOptions();
//    des
//        .AddAdditionalCapability("app", @"C:\Windows\System32\notepad.exe");


//    Thread.Sleep(5);
//    notepad = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), des);

//    //\"]/Pane[@Name=\"Google Chrome\"]/Pane/Pane[position()=1]/Pane/Tab/Pane/TabItem[starts-with(@Name,\"5. WinAppDriver Tutorial | How To Set Up WinAppDriver in Windows\")]/Button[@Name=\"Close\"]"
//}