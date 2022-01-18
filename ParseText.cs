using System;
using HtmlAgilityPack;

namespace ParseMusicSite
{
    class ParseText : IParseLang
    {
        private HtmlNodeCollection engLang { get; set; }
        private HtmlNodeCollection ruLang { get; set; }

        public ParseText(IGetData en, IGetData ru) {
            engLang = en.ParseText();
            ruLang = ru.ParseText();
        }
        public void ShowText() {

            for (int i = 0; i < engLang.Count; i++)
            {
                string text = $"{engLang[i].InnerText.Replace("\n", "").Replace("\t", "")}\n{ruLang[i].InnerText.Replace("\n", "").Replace("\t", "")}\n";
                Console.WriteLine(text);
            }
        }
    }
}
