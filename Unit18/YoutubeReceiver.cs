using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using System.Threading.Tasks;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Unit18
{
    class YoutubeReceiver
    {

        YoutubeClient youtube;

        public YoutubeReceiver()
        {
            youtube = new YoutubeClient();
        }

        public async Task OperationInfo(string UrlVideo)
        {

            var info = await youtube.Videos.GetAsync(UrlVideo);
            Console.WriteLine("Информация о файле по адресу " + UrlVideo + "\n");
            Console.WriteLine(info);
            Console.WriteLine($"Название: {info.Title}\n");
            Console.WriteLine($"Автор: {info.Author}\n");
            Console.WriteLine($"Продолжительность: {info.Duration}\n");
            Console.WriteLine($"Описание: {info.Description}\n");

        }

        public async Task OperationDownload(string UrlVideo)
        {
            Console.WriteLine("Загружаем видео...\n");

            await youtube.Videos.DownloadAsync( UrlVideo,  "video.mp4",
                builder => builder.SetPreset(ConversionPreset.UltraFast));

            Console.WriteLine("Загрузка завершена!");
        }
    }
}
