using HtmlAgilityPack;

namespace ParseMusicSite
{
    interface IGetData
    {
        HtmlNodeCollection ParseText();
    }
}
