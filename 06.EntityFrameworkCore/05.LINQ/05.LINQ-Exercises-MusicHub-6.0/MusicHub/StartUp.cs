namespace MusicHub
{
    using System;
    using System.Diagnostics.Metrics;
    using System.Text;
    using System.Xml.Linq;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore.Metadata.Conventions;
    using MusicHub.Data.Models;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine(ExportSongsAboveDuration(context, duration));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albumInfo = context.Producers
                 .Where(p => p.Id == producerId)
                 .SelectMany(p => p.Albums)
                 .Select(a => new
                 {
                     AlbumName = a.Name,
                     ReleaseData = a.ReleaseDate.ToString("MM/dd/yyyy"),
                     ProducerName = a.Producer.Name,
                     Songs = a.Songs.Select(s => new
                     {
                         SongName = s.Name,
                         s.Price,
                         SongWriterName = s.Writer.Name
                     }).OrderByDescending(s => s.SongName)
                     .ThenBy(s => s.SongWriterName)
                     .ToList(),

                     TotalAlbumCost = a.Songs.Sum(s => s.Price)
                 })
                 .OrderByDescending(a => a.TotalAlbumCost);

            StringBuilder sb = new StringBuilder();

            foreach (var album in albumInfo)
            {
                sb.AppendLine($"-AlbumName: {album.AlbumName}");
                sb.AppendLine($"-ReleaseDate: {album.ReleaseData}");
                sb.AppendLine($"-ProducerName: {album.ProducerName}");
                sb.AppendLine($"-Songs:");
                int counter = 1;
                foreach (var song in album.Songs)
                {
                    sb.AppendLine($"---#{counter}");
                    sb.AppendLine($"---SongName: {song.SongName}");
                    sb.AppendLine($"---Price: {song.Price:F2}");
                    sb.AppendLine($"---Writer: {song.SongWriterName}");

                    counter++;
                }
                sb.AppendLine($"-AlbumPrice: {album.TotalAlbumCost:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var timeSpanDuration = TimeSpan.FromSeconds(duration);
            var songsInfo = context.Songs
                .Where(s => s.Duration > timeSpanDuration)
                .Select(s => new
                {
                    SongName = s.Name,
                    Performers = s.SongPerformers
                    .Select(sp => sp.Performer)
                    .Select(p => new
                    {
                        FullName = p.FirstName + " " + p.LastName
                    })
                    .OrderBy(p => p.FullName)
                    .ToList(),
                    WriterName = s.Writer.Name,
                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration.ToString("c")
                })
                .OrderBy(s => s.SongName)
                .ThenBy(s => s.WriterName)
                .ToList();
            StringBuilder sb = new StringBuilder();
            int songCounter = 1;

            foreach (var song in songsInfo)
            {
                sb.AppendLine($"-Song #{songCounter}");
                sb.AppendLine($"---SongName: {song.SongName}");
                sb.AppendLine($"---Writer: {song.WriterName}");
                if (song.Performers.Any())
                {
                    foreach (var performer in song.Performers)
                    {
                        sb.AppendLine($"---Performer: {performer.FullName}");
                    }
                }
                sb.AppendLine($"---AlbumProducer: {song.AlbumProducer}");
                sb.AppendLine($"---Duration: {song.Duration}");
                songCounter++;
            }

            return sb.ToString().TrimEnd();
        }

    }
}
