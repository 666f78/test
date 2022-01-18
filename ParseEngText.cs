using HtmlAgilityPack;

namespace ParseMusicSite
{
    class ParseEngText : IParseLang 
    { 
        public HtmlNodeCollection ParseText(HtmlDocument doc) => doc.DocumentNode.SelectNodes("//*[@class='original']");
    }
}
