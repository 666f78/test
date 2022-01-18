using HtmlAgilityPack;

namespace ParseMusicSite
{
    class ParseEngText : IGetData
    {
        public HtmlNodeCollection ParseText(HtmlDocument doc) => doc.DocumentNode.SelectNodes("//*[@class='original']");
    }
}
