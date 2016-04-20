using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vnvbnvnvbnvbn
{
    class getinfo
    {

        public String url;
        public String text;

        public getinfo(string url,string text)
        {
            this.url = url;
            this.text = text;
        }


        public string GetPageHtml()
        {
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var html = System.Net.WebUtility.HtmlDecode(wc.DownloadString(url));
                return html;
            }
        }


        public string PrintPageNodes()
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            var pageHtml = GetPageHtml();
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");    

            foreach (var node in nodes)
            {
                string link = node.GetAttributeValue("src", "").ToString();
                string opis = node.GetAttributeValue("alt", "");

                bool contains = Regex.IsMatch(opis, text);
                if (contains)
                {
                    return link;
                }            
            }
            return ":(";
        }

    }
}
