﻿namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsConfigurationUiScreen : BaseModel
{
    public string Id { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? CompanyId { get; set; }

    public int? Status { get; set; }

    public string? FontUpload { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? FontPersonalizeUpload { get; set; }

    public int Type { get; set; }
}
