using System;

namespace Open_Lab__10._00
{
    class Program
    {

        static void Main(string[] args)
        {
            Book Lotr = new Book();
            Lotr.Title =("Janko Hraško");
            Lotr.Pages =("12");
            Lotr.Category =("fairy tale");
            Lotr.Autor =("Mária Ďuríčková");
            Lotr.ReleaseDate =("3.6.2014");
        }
            class Book
        {
            private string title;
            private int pages;
            private string category;
            private string autor;
            private int releaseDate;

            public void Title(string newTitle) { title = newTitle; }
            public void Pages(int newPages) { pages = newPages; }
            public void Category(string newCategory) { category = newCategory; }
            public void Autor(string newAutor) { autor = newAutor; }
            public void ReleaseDate(int newReleaseDate) { releaseDate = newReleaseDate; }
        }
        
            public void Write()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }
    }
}
