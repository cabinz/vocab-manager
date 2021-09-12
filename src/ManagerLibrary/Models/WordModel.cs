using System.Collections.Generic;

namespace ManagerLibrary.Models
{
    public class WordModel
    {
        /// <summary>
        /// The identity ID of the word.
        /// </summary>
        public int WordID { get; set; }

        /// <summary>
        /// The plain text of the word.
        /// </summary>
        public string WordText { get; set; }

        /// <summary>
        /// The definition string for the word.
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// The context where the word occurs, i.e. an example.
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// The source of the context or the word, may be a link.
        /// </summary>
        public string ContextSource { get; set; }

        /// <summary>
        /// The note for the word.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// The list of tags for the word.
        /// </summary>
        public List<TagModel> Tags { get; set; } = new List<TagModel>();

        public WordModel()
        {

        }

        public WordModel(
            string txtWordText, string txtDefinition, string txtContext,
            string txtContextSource, string txtNote, List<TagModel> lstTags)
        {
            WordText = txtWordText;
            Definition = txtDefinition;
            Context = txtContext;
            ContextSource = txtContextSource;
            Note = txtNote;
            Tags = lstTags;
        }
    }
}
