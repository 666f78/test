using HtmlAgilityPack;
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
