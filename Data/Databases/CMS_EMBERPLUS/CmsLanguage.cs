﻿namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsLanguage : BaseModel
{
    public int Id { get; set; }

    public string? Key { get; set; }

    public string? Title { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public int? CompanyId { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsDisplay { get; set; }
}
