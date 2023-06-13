namespace Data.Databases.CMS_EMBERPLUS;

public partial class ProductLayerDetailImage : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public long? ProductLayerDetailId { get; set; }

    public long? ProductLayerBaseId { get; set; }

    public int? Index { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageThumbUrl { get; set; }
}

