using System;
using System.Net.NetworkInformation;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AngleSharp;
using System.Threading;
using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;
using System.Windows.Forms;


namespace ConsoleCSHARP
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите незвание сайта, например 'google' >>> ");
            string PageName = Console.ReadLine();

            MyClass mc = new MyClass();
            mc.GetDomanExtensions(PageName);

            Console.ReadLine();
        }
    }



    class MyClass
    {

        public async void GetDomanExtensions(string PageName)
        {
            List<string> DomainList = new List<string>();

            Console.WriteLine("Domain subnames import (from wikipedia.org)...");

            var config = Configuration.Default.WithDefaultLoader();
            var address = "https://ru.wikipedia.org/wiki/Список_доменов_верхнего_уровня";
            var document = await BrowsingContext.New(config).OpenAsync(address);


            var cells = document.QuerySelectorAll("a").Where(item => item.ParentElement.TagName.Contains("TD"));

            int counter = 0;
            foreach (var item in cells)
            {

                if (item.TextContent.StartsWith("."))
                {
                    bool isValid = true;
                    string resultDomain = "";
                    foreach (char ch in item.TextContent)
                    {
                        if ((int)ch < 1800)
                            resultDomain += ch;
                        else
                            isValid = false;

                    }
                    if (isValid)
                    {
                        counter++;
                        DomainList.Add(item.TextContent);
                    }
                }
            }

            string protocol = "http";
            int SuccesfullCounter = 0;

            List<string> ResponseList = new List<string>();
            for (int j = 0; j < DomainList.Count; j++)
            {
                try
                {
                    Uri url = new Uri("http://" + PageName + DomainList[j]);
                    Console.SetCursorPosition(1, 3);
                    Console.WriteLine(j + " pages from " + DomainList.Count + " checked ( " + ResponseList.Count + " aviable... )");
                    Console.Title = j + " from " + DomainList.Count + "  ( " + (int)((float)j / (float)DomainList.Count * 100) + " % )";
                    string pingurl = string.Format("{0}", url.Host);
                    Ping p = new Ping();

                    PingReply reply = p.Send(pingurl, 3000);
                    if (reply.Status == IPStatus.Success)
                    {
                        ResponseList.Add(url.AbsoluteUri);
                        Console.SetCursorPosition(1, ResponseList.Count + 3);
                        Console.WriteLine((++SuccesfullCounter) + "   " + url.AbsoluteUri + "                 ответил");
                        
                    }

                }
                catch
                {

                }
            }

                foreach (var item in ResponseList)
                {
                    System.Diagnostics.Process.Start(item);
                }
            Console.WriteLine("do u wnt to open anyone? (-1 = open ALL)   index >>>");
            try
            {
                Console.SetCursorPosition(1, ResponseList.Count + 4);
                int indx = Int32.Parse(Console.ReadLine()) - 1;
                System.Diagnostics.Process.Start(ResponseList[indx]);

            }
            catch
            {

            }

            Console.ReadLine();
        }
    }
}
