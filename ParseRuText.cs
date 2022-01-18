using HtmlAgilityPack;

namespace ParseMusicSite
{
    class ParseRuText : IGetData
    { 
        public HtmlNodeCollection ParseText(HtmlDocument doc) => doc.DocumentNode.SelectNodes("//*[contains(@class, 'translate few') or contains(@class, 'translate')]");
    }
}
