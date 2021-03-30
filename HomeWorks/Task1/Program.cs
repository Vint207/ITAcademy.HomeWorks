using System;
using System.Text.Json;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song.list.Add(new Song
            {
                Title = "Holy War",
                Length = 5.02f,
                AuthorName = "Василий Лебедев-Кумач",
                SongGenre = Song.Genre.Military,
                Year = 1941
            });

            Song.list.Add(new Song
            {
                Title = "And Battle Continues Again",
                Length = 4f,
                AuthorName = "Александра Пахмутова, Николай Добронравов",
                SongGenre = 5,
                Year = 1974
            });

            dynamic song = Song.GetSongData("Holy War");

            Console.WriteLine($"Title: {song.Title}\nLength: {song.Length}\nYear: {song.Year}\nGenre: {song._songGenre}\n");

            string json = JsonSerializer.Serialize<dynamic>(song);
            Console.WriteLine(json);

            song = Song.GetSongData("And Battle Continues Again");

            Console.WriteLine($"\nTitle: {song.Title}\nLength: {song.Length}\nYear: {song.Year}\nGenre: {song._songGenre}\n");
           
            json = JsonSerializer.Serialize<dynamic>(song);
            Console.WriteLine(json);
        }
    }
}
