using ManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ManagerLibrary.Export
{
    public class MDExporter
    {
        /// <summary>
        /// A list of WordModel objects to export. All the objects
        /// should have WordID property for GetWordById() method.
        /// </summary>
        public List<WordModel> WordIds { get; set; }

        /// <summary>
        /// Represents the file path with new file name for exporting.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wordWithId"></param>
        public MDExporter(List<WordModel> wordWithId, string filePath)
        {
            WordIds = wordWithId;
            FilePath = filePath;
        }

        /// <summary>
        /// Export a markdown file to the PathFile.
        /// </summary>
        public void Export()
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                for (int i = 0; i < WordIds.Count; i++)
                {
                    WordModel word = GlobalConfig.Connection.GetWordById(WordIds[i].WordID);
                    string textForWord = GetTextForWord(word);
                    sw.WriteLine($"## {i + 1}. {textForWord}\n");
                }
            }
        }

        /// <summary>
        /// Generate a segement of markdown text with the information in input object.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private string GetTextForWord(WordModel word)
        {
            string ret = "";
            ret += $"{word.WordText}\n";

            if (word.Definition != "")
            {
                ret += $"**Definition**\n{word.Definition}\n";
            }

            if (word.Tags.Count != 0)
            {
                ret += "**Tag(s)**: ";
                List<string> tagNames = word.Tags.Select(x => x.TagName).ToList();
                ret += String.Join(", ", tagNames) + "\n";
            }

            if (word.Context != "")
            {
                ret += $"**Context**\n{word.Context}\n";
            }

            if (word.ContextSource != "")
            {
                if (word.ContextSource.StartsWith("http"))
                {
                    ret += $"([source]({word.ContextSource}))\n";
                }
                else
                {
                    ret += $"source: {word.ContextSource}\n";
                }
            }

            if (word.Note != "")
            {
                ret += $"**Note**\n{word.Note}\n";
            }

            return ret;
        }
    }
}
