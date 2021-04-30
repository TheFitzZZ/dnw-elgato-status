using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                GetPlayerCount();
            }
            
        }

        static void GetPlayerCount()
        {
            //get the page
            var web = new HtmlWeb();
            var document = web.Load("https://www.dieneuewelt.de/status/");
            var page = document.DocumentNode;

            string html = page.InnerHtml.ToString().ToLower();

            var a = html.IndexOf("anzahl eingeloggter clients:</td>\r\n            <td class=\"data\">");
            html = html.Substring(a + 64);
            var astr = html.Substring(0, html.IndexOf("</td>\r\n          </tr>\r\n          <tr>\r\n                <td class=\"label\">peak eingeloggter")); //Latest stable version is

            int playerOnline = Convert.ToInt32(astr);

            int konventOnline = Regex.Matches(html, Regex.Escape("[k]")).Count;

            var dfs = "lol";

        }
    }
}
