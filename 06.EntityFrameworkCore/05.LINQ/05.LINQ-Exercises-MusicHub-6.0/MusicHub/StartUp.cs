namespace MusicHub
{
    using System;
    using System.Xml.Linq;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            //Test your solutions here
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            context.Producers
                .Where(p => p.Id == producerId)
                .Select(p => new
                {
                    p.Name,
                    ReleaseDate = p.ReleaseDate.ToString("MM/dd/yyyy"),
                    ProducerName = p.Producer.Name,
                    

                })
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            throw new NotImplementedException();
        }
    }
}
