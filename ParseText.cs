using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ParseMusicSite
{
    class ParseText
    {
        public HtmlNodeCollection engLang { get; set; }
        public HtmlNodeCollection ruLang { get; set; }

        public void ShowText() {

            for (int i = 0; i < engLang.Count; i++)
            {
                string text = $"{engLang[i].InnerText.Replace("\n", "").Replace("\t", "")}\n{ruLang[i].InnerText.Replace("\n", "").Replace("\t", "")}\n";
                Console.WriteLine(text);
            }

        }
    }
}
