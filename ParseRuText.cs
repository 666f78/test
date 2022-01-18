using HtmlAgilityPack;

namespace ParseMusicSite
{
    class ParseRuText : IParseLang 
    { 
        public HtmlNodeCollection ParseText(HtmlDocument doc) => doc.DocumentNode.SelectNodes("//*[contains(@class, 'translate few') or contains(@class, 'translate')]");
    }
}
