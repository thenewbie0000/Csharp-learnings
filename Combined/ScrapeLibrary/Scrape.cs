﻿using System.Net;
using System.IO;

namespace ScrapeLibrary
{
    public class Scrape
    {
            public string ScrapeWebPage(string url)
            {
                return GetWebPage(url);
            }

            public string ScrapeWebPage(string url, string filepath)
            {
                string reply = GetWebPage(url);
                File.WriteAllText(filepath, reply);
                return reply;
            }

            private string GetWebPage(string url)
            {
                WebClient client = new WebClient();
                string content = client.DownloadString(url);
                content += "THIS IS IT, GUYS";
                return content;
            }
        }
    }

