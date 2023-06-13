using Utilities.MPlusSyncOrderUtility;

namespace BusinessServices.Models.MPlusSyncOrderAPI
{
    [Serializable]
    public class EditorEntity
    {
        public EditorEntity()
        {
            Status = (int)RecordStatus.Active;
        }
        public string Title { get; set; }

        public string Description { get; set; }

        public int? Status { get; set; }

        public string CreateBy { get; set; }

        public string CreatebyName { get; set; }

        public DateTime? CreateDate { get; set; }

        public string LastUpdateBy { get; set; }

        public string LastUpdateByName { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        //public ActionType? ActionType { get; set; }
    }
}
