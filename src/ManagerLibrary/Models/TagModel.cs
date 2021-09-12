namespace ManagerLibrary.Models
{
    public class TagModel
    {
        /// <summary>
        /// The identity ID of the tag.
        /// </summary>
        public int TagID { get; set; }

        /// <summary>
        /// The name of the tag.
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// The detail information of the tag.
        /// </summary>
        public string TagInfo { get; set; }

        public TagModel()
        {

        }

        public TagModel(int id, string name, string info)
        {
            TagID = id;
            TagName = name;
            TagInfo = info;
        }
    }
}
