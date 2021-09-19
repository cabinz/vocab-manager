using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ManagerLibrary.AutoFiller
{
    /// <summary>
    /// On Longman dictionary web page, a spelling of word has several dictionary entries, 
    /// each of which has one POS, one pronunciation and multiple definitions (senses).
    /// Usually, different entry has different POS.
    /// </summary>
    public class LongmanFiller : IAutoFiller
    {
        public static string BaseLink { get; set; } = "https://www.ldoceonline.com/dictionary";

        public string WordText { get; set; } = "";

        public string FullLink { 
            get { return $"{BaseLink}/{WordText}"; }
        }

        public HtmlWeb Web { get; set; } = new HtmlWeb();
        
        public HtmlDocument Doc { get; set; }

        public LongmanFiller()
        {
        }

        public LongmanFiller(string spelling)
        {
            WordText = spelling;
            Doc = Web.Load(FullLink);
        }

        public string Spelling()
        {
            return WordText;
        }

        /// <summary>
        /// Crawl details info from all entries on Longman dictionary web page
        /// for filling definition box, 
        /// including part-of-speech, pronunciation and definitions of each entry.
        /// There will be a skip line between each entry.
        /// </summary>
        /// <returns>the whole definition string with skip line at the end of it</returns>
        public string DefinitionText()
        {
            string fullInfo = "";

            var entries = Doc.DocumentNode.SelectNodes("//span[@class='dictentry']");

            if (entries != null)
            {
                foreach (var item in entries)
                {
                    string pos = PartOfSpeech(item);
                    string pron = Pronunciation(item);
                    string defs = Senses(item);

                    fullInfo += $"({pos})" + (String.IsNullOrEmpty(pos) ? "" : Environment.NewLine);
                    fullInfo += pron + (String.IsNullOrEmpty(pron) ? "" : Environment.NewLine);
                    fullInfo += defs;
                    fullInfo += Environment.NewLine;
                }
            }

            return fullInfo;
        }

        /// <summary>
        /// Get the POS of a sense of the word entry (the node).
        /// Return empty string if no record.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private string PartOfSpeech(HtmlNode node)
        {
            var pnode = node.SelectSingleNode(".//span[@class='POS']");
            return pnode == null ? "" : pnode.InnerText.Trim();
        }

        /// <summary>
        /// Get the phonic of a sense of the word entry (the node).
        /// Return empty string if no record.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private string Pronunciation(HtmlNode node)
        {
            var pnode = node.SelectSingleNode(".//span[@class='PronCodes']");
            return pnode == null ? "" : pnode.InnerText.Trim();
        }

        /// <summary>
        /// Get definitions of the word entry (the node).
        /// Return empty string if no records.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>String with all the definitions in the node (entry).</returns>
        private string Senses(HtmlNode node)
        {
            string ret = "";
            int cnt = 1;

            var defs = node.SelectNodes(".//span[@class='DEF']");

            if(defs != null)
            {
                foreach (var def in defs)
                {
                    ret += $"{cnt++}. {def.InnerText}" + Environment.NewLine;
                }
            }

            return ret;
        }

        /// <summary>
        /// Get the examples of the word.
        /// </summary>
        /// <returns>String with all the example.</returns>
        public string ContextText()
        {
            string ret = "";
            int cnt = 1;
            Regex reg = new Regex("[ ]{2,}", RegexOptions.None);

            var exmps = Doc.DocumentNode.SelectNodes("//span[@class = 'EXAMPLE']");
            if (exmps != null)
            {
                foreach (var exmp in exmps)
                {
                    ret += $"{cnt++}. {reg.Replace(exmp.InnerText, " ")}" + Environment.NewLine;
                }
            }
            
            return ret;
        }

        /// <summary>
        /// Get the Longman dict page link of the word.
        /// </summary>
        /// <returns>String of the link with "[Longman]:" prefix.</returns>
        public string SourceText()
        {
            return $"[Longman]: {FullLink}";
        }
    }
}
