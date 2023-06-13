namespace Data.Databases.CMS_EMBERPLUS;

public partial class Carousel : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Height { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Animation { get; set; }

    public string? Easing { get; set; }

    public int? SlideshowSpeed { get; set; }

    public int? AnimationSpeed { get; set; }

    public bool? AnimationLoop { get; set; }

    public bool? Slideshow { get; set; }

    public bool? PauseOnHover { get; set; }

    public bool? ControlNav { get; set; }

    public bool? DirectionNav { get; set; }

    public int? ItemWidth { get; set; }

    public int? ItemMargin { get; set; }

    public int? MinItems { get; set; }

    public int? MaxItems { get; set; }

    public bool? Thumbnail { get; set; }

    public bool? ThumbnailControlNav { get; set; }

    public int? ThumbnailItemWidth { get; set; }

    public int? ThumbnailItemMargin { get; set; }

    public int? ThumbnailMinItems { get; set; }

    public int? ThumbnailMaxItems { get; set; }

    public virtual ICollection<CarouselItem> CarouselItems { get; } = new List<CarouselItem>();

    public virtual ICollection<CarouselWidget> CarouselWidgets { get; } = new List<CarouselWidget>();
}
