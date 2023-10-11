namespace comic_book_gallery.Models;

public class ComicBooks
{
    public int Id { get; set; }
    public string SeriesTitle { get; set; } = null!;
    public int IssueNumber { get; set; }
    public string DescriptionHtml { get; set; } = null!;
    public Artist[] Artists { get; set; } = null!;
    public bool Favorite { get; set; }
}