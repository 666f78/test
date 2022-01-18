using HtmlAgilityPack;

namespace ParseMusicSite
{
    class ParseRuText : IGetData
    {
        private HtmlDocument doc { get; set; }

        public ParseRuText(HtmlDocument doc)
        {
            this.doc = doc;
        }
        public HtmlNodeCollection ParseText() => doc.DocumentNode.SelectNodes("//*[contains(@class, 'translate few') or contains(@class, 'translate')]");
    }
}
