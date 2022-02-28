using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OnlineExamProject.Web.Models
{
    public class BlogTitle
    {
        public static string Send(string uri, string node)
        {
            try
            {
                if (!string.IsNullOrEmpty(uri))
                {
                    WebClient webClient = new WebClient();
                    webClient.Encoding = System.Text.Encoding.UTF8;
                    string html = webClient.DownloadString(uri);
                    if (!string.IsNullOrEmpty(html))
                    {
                        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                        htmlDocument.LoadHtml(html);
                        if (htmlDocument != null)
                        {
                            HtmlAgilityPack.HtmlNode htmlNode = htmlDocument.DocumentNode.SelectSingleNode(node);
                            if (htmlNode != null)
                            {

                                string innerText = htmlNode.InnerHtml;
                                if (!string.IsNullOrEmpty(innerText))
                                {
                                    return innerText;
                                }

                            }
                        }

                    }
                }
                return null;
            }
            catch
            {

                return null;
            }
        }
        public static List<string> SendList(string uri, string node)
        {
            try
            {
                if (!string.IsNullOrEmpty(uri) && !string.IsNullOrEmpty(node))
                {
                    WebClient webClient = new WebClient();
                    webClient.Encoding = System.Text.Encoding.UTF8;
                    string html = webClient.DownloadString(uri);
                    if (!string.IsNullOrEmpty(html))
                    {
                        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                        htmlDocument.LoadHtml(html);
                        if (htmlDocument != null)
                        {
                            HtmlAgilityPack.HtmlNodeCollection htmlNodes = htmlDocument.DocumentNode.SelectNodes(node);
                            if (htmlNodes != null && htmlNodes.Count > 0)
                            {
                                List<string> lists = new List<string>();
                                foreach (var item in htmlNodes)
                                {
                                    string innerText = item.InnerText;
                                    if (!string.IsNullOrEmpty(innerText))
                                    {
                                        lists.Add(innerText);
                                    }
                                }
                                return lists;
                            }
                        }

                    }
                }
                return null;
            }
            catch
            {

                return null;
            }
        }

        public static List<string> SendLists(string uri, string node)
        {
            try
            {
                if (!string.IsNullOrEmpty(uri) && !string.IsNullOrEmpty(node))
                {
                    WebClient webClient = new WebClient();
                    webClient.Encoding = System.Text.Encoding.UTF8;
                    string html = webClient.DownloadString(uri);
                    if (!string.IsNullOrEmpty(html))
                    {
                        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                        htmlDocument.LoadHtml(html);
                        if (htmlDocument != null)
                        {
                            HtmlAgilityPack.HtmlNodeCollection htmlNodes = htmlDocument.DocumentNode.SelectNodes(node);
                            if (htmlNodes != null && htmlNodes.Count > 0)
                            {
                                List<string> lists = new List<string>();
                                foreach (var item in htmlNodes)
                                {
                                    string innerText = item.InnerText;
                                    if (!string.IsNullOrEmpty(innerText))
                                    {
                                        lists.Add(innerText);
                                    }
                                }
                                return lists;
                            }
                        }

                    }
                }
                return null;
            }
            catch
            {

                return null;
            }
        }
        public static List<string> SendListLink(string uri, string node)
        {
            try
            {
                if (!string.IsNullOrEmpty(uri) && !string.IsNullOrEmpty(node))
                {
                    WebClient webClient = new WebClient();
                    webClient.Encoding = System.Text.Encoding.UTF8;
                    string html = webClient.DownloadString(uri);
                    if (!string.IsNullOrEmpty(html))
                    {
                        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                        htmlDocument.LoadHtml(html);
                        if (htmlDocument != null)
                        {
                            HtmlAgilityPack.HtmlNodeCollection htmlNodes = htmlDocument.DocumentNode.SelectNodes(node);
                            if (htmlNodes != null && htmlNodes.Count > 0)
                            {
                                List<string> lists = new List<string>();
                                foreach (var item in htmlNodes)
                                {
                                    string hrefValue = item.Attributes["href"].Value;
                                    string innerText = item.InnerText;
                                    string uris = innerText + "~https://www.wired.com" + hrefValue;
                                    if (!string.IsNullOrEmpty(hrefValue))
                                    {
                                        lists.Add(uris);
                                    }
                                }
                                return lists;
                            }
                        }

                    }
                }
                return null;
            }
            catch
            {

                return null;
            }
        }
    }
}

