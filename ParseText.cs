using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ParseMusicSite
{
    public class ParseText : IParseLang
    {

        private HtmlNodeCollection engLang { get; set; }
        private HtmlNodeCollection ruLang { get; set; }

        public ParseText(HtmlDocument doc) { 
            engLang = new ParseEngText().ParseText(doc);
            ruLang = new ParseRuText().ParseText(doc);

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
