using HtmlAgilityPack;

namespace ParseMusicSite
{
    class ParseEngText : IGetData
    {
        private HtmlDocument doc { get; set; }
        public ParseEngText(HtmlDocument doc) { 
         this.doc = doc;
        }
        public HtmlNodeCollection ParseText() => doc.DocumentNode.SelectNodes("//*[@class='original']");
    }
}
