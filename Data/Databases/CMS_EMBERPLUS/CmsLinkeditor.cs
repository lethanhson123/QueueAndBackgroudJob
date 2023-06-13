﻿namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsLinkeditor : BaseModel
{
    public string Id { get; set; } = null!;

    public string? Value { get; set; }

    public int? CompanyId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Class { get; set; }

    public string? Style { get; set; }

    public string? Url { get; set; }

    public string? Name { get; set; }

    public string? Page { get; set; }

    public string? Target { get; set; }
}