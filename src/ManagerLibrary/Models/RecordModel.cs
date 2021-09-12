using System;

namespace ManagerLibrary.Models
{
    public class RecordModel
    {
        /// <summary>
        /// The identity of the record.
        /// </summary>
        public int RecID { get; set; }

        /// <summary>
        /// The identity of the word.
        /// </summary>
        public int WordID { get; set; }

        /// <summary>
        /// The date and time when the record was generated.
        /// </summary>
        public DateTime RecTime { get; set; }

        /// <summary>
        /// The result of the word testing.
        /// </summary>
        public bool RecState { get; set; }

        public RecordModel()
        {

        }

        public RecordModel(int wordId, bool state)
        {
            WordID = wordId;
            RecTime = DateTime.Now;
            RecState = state;
        }
    }
}
