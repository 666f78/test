using HtmlAgilityPack;

namespace ParseMusicSite
{
    interface IParseLang
    {
        public HtmlNodeCollection ParseText(HtmlDocument doc);
    }
}
