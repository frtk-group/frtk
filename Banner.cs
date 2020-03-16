public class Banner 
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; }

    public string Link { get; set; }

    public string ImageUrl { get; set; }

    public DateTimeOffset ExpDate { get; set; }
}