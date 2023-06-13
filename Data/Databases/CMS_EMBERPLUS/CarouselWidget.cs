namespace Data.Databases.CMS_EMBERPLUS;

public partial class CarouselWidget : BaseModel
{
    public string Id { get; set; } = null!;

    public int? CarouselId { get; set; }

    public virtual Carousel? Carousel { get; set; }

    public virtual ICollection<CarouselItem> CarouselItems { get; } = new List<CarouselItem>();
}
