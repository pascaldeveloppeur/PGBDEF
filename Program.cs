using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace PGBDEF
{
    internal class Program
    {
        
       


    static void Main(string[] args)
        {
           // DisplayArtists();
            DisplayArtistsWhenNameStartsWith("B");

        }

        static void DisplayArtists()
        {
            using (var context = new DB.ChinookContext())
            {
                List<DB.Artist> artists = context.Artists.ToList();
                foreach (var artist in artists)
                {
                    Console.WriteLine($"ArtistId: {artist.ArtistId}, Name: {artist.Name}");
                }
            }
        }

        static void DisplayArtistsWhenNameStartsWith(string prefix)
        {
            using (var context = new DB.ChinookContext())
            {
                List<DB.Artist> artists = context.Artists
                    .Where(a => a.Name.StartsWith(prefix))
                    .ToList();
                foreach (var artist in artists)
                {
                    Console.WriteLine($"ArtistId: {artist.ArtistId}, Name: {artist.Name}");
                }
            }
        }
    }
}
