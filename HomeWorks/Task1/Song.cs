using System.Collections.Generic;

namespace Task1
{
    class Song
    {

        public static List<Song> list = new();

        public string Title { get; set; }
        public float Length { get; set; }
        public string AuthorName { get; set; }
        public int Year { get; set; }
        public enum Genre : int
        {
            Pop = 1,
            Clasic,
            Rock,
            Jazz,
            Military
        }
        Genre _songGenre;
        public object SongGenre
        {
            get { return _songGenre; }
            set
            {
                Genre genre = (Genre)value;
                switch (genre)
                {
                    case Genre.Pop:
                        _songGenre = genre;
                        break;
                    case Genre.Clasic:
                        _songGenre = genre;
                        break;
                    case Genre.Rock:
                        _songGenre = genre;
                        break;
                    case Genre.Jazz:
                        _songGenre = genre;
                        break;
                    case Genre.Military:
                        _songGenre = genre;
                        break;
                    default:
                        _songGenre = Genre.Pop;
                        break;
                }
            }
        } 
 
        public static dynamic GetSongData(string title)
        {
            Song item = list?.Find(song => song.Title == title);

            if (item != null) return new { item.Title, item.Length, item.Year, item._songGenre };

            return item;
        }
    }
}
