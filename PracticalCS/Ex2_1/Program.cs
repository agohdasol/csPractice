using System;

namespace Ex2_1
{
    class Song
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }
        public Song(string title, string artistName, int length)
        {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }
        public static void PrintSongProperty(Song song)
        {
            int minutes;
            int seconds;
            if (song.Length >= 60)
            {
                minutes = (int)song.Length / 60;
                seconds = song.Length % 60;
            }
            else
            {
                minutes = 0;
                seconds = song.Length;
            }
            Console.WriteLine($"곡명 : {song.Title},  아티스트 : {song.ArtistName},  길이 : {minutes}분 {seconds}초");
        }
    }
    class Program
    {
        static void Main()
        {
            Song song1 = new Song("노래일번", "임의가수1", 84);
            Song song2 = new Song("노래이번", "임의가수2", 143);
            Song song3 = new Song("노래삼번", "임의가수3", 34);
            Song[] array = new Song[3];
            array[0] = song1;
            array[1] = song2;
            array[2] = song3;

            foreach (var item in array)
            {
                Song.PrintSongProperty(item);
            }
        }
    }
}
