using System.ComponentModel;
using comic_book_gallery.Models;

namespace comic_book_gallery.Data;

public class ComicBookRepository
{
    private static ComicBook[] _comicBooks = new ComicBook[]
    {
        new()
        {
            Id = 1,
            SeriesTitle = "The Amazing Spider-Man",
            IssueNumber = 700,
            DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
            Artists = new Artist[]
            {
                new() { Name = "Script", Role = "Dan Slott" },
                new() { Name = "Pendils", Role = "Humberto Ramos" },
                new() { Name = "Inks", Role = "Victor Olazaba" },
                new() { Name = "Colors", Role = "Edgar Delgado" },
                new() { Name = "Letters", Role = "Chris Elipoulos" }
            }
        },
        new()
        {
            Id = 2,
            SeriesTitle = "The Amazing Spider-Man",
            IssueNumber = 657,
            DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
            Artists = new Artist[]
            {
                new() { Name = "Dan Slott", Role = "Script" },
                new() { Name = "Marcos Martin", Role = "Pencils" },
                new() { Name = "Marcos Martin", Role = "Inks" },
                new() { Name = "Muntsa Vicente", Role = "Colors" },
                new() { Name = "Joe Caramagna", Role = "Letters" }
            },
            Favorite = false
        },
        new()
        {
            Id = 3,
            SeriesTitle = "Bone",
            IssueNumber = 50,
            DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
            Artists = new Artist[]
            {
                new() { Name = "Jeff Smith", Role = "Script" },
                new() { Name = "Jeff Smith", Role = "Pencils" },
                new() { Name = "Jeff Smith", Role = "Inks" },
                new() { Name = "Jeff Smith", Role = "Letters" }
            },
            Favorite = false
        }
    };

    public ComicBook GetComicBook(int id) => _comicBooks.First(c => c.Id == id);
}
