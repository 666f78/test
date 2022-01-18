using HtmlAgilityPack;

namespace ParseMusicSite
{
    interface IGetData
    {
        HtmlNodeCollection ParseText(HtmlDocument doc);
    }
}
