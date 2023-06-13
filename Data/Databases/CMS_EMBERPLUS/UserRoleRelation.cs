namespace Data.Databases.CMS_EMBERPLUS;

public partial class UserRoleRelation : BaseModel
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public string? UserId { get; set; }
}

