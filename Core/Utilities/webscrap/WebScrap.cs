using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.webscrap
{
    public class WebScrap
    {
        // 
        public static string test(string url)
        {
            string result = "";
            int count = 0;
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            foreach (var item in doc.DocumentNode.SelectNodes("//div[@class='chapter']"))
            {
                if (count < 2) {
                    result += item.InnerText;
                }
                count++;
            }

            return result;
        }


    }
}
