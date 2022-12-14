namespace Aboriginal_Art_Gallery_of_Australia.Models.Database_Models
{
    public class Media
    {
        public int MediaId { get; set; }
        public string MediaType { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime CreatedAt { get; set; }

        public Media(int mediaId, string mediaType, string description, DateTime modifiedAt, DateTime createdAt)
        {
            MediaId = mediaId;
            MediaType = mediaType;
            Description = description;
            ModifiedAt = modifiedAt;
            CreatedAt = createdAt;
        }
    }
}