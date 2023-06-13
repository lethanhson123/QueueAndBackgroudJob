namespace Data.Databases.Tpfsystem;

public partial class ClientWebAccountBakUpdateProfile : BaseModel
{
    public int WebAccId { get; set; }

    public long ClientId { get; set; }

    public int Catalogueid { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Psentence { get; set; }

    public int? Accesslevel { get; set; }

    public string? Notes { get; set; }

    public string? Extrainfo { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public DateTime? Lastupdate { get; set; }

    public int? Updateby { get; set; }

    public DateTime? Createdate { get; set; }

    public int? Createby { get; set; }

    public string AccessStatus { get; set; } = null!;

    public string? Oktospam { get; set; }

    public string Status { get; set; } = null!;

    public long? OldAccId { get; set; }

    public int? PriceProfileId { get; set; }

    public int? Accesstagid { get; set; }

    public int? Caninvoice { get; set; }

    public Guid? Token { get; set; }

    public DateTime? Tokendate { get; set; }

    public string? Seed { get; set; }

    public string? Encryptedpw { get; set; }

    public bool? UseEncryption { get; set; }

    public string? Hashfunction { get; set; }

    public DateTime? LastExported { get; set; }

    public bool? IsLogin { get; set; }

    public DateTime? Lastlogin { get; set; }
}

