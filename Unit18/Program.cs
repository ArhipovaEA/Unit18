using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Unit18
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var videoIdOrUrl = "https://www.youtube.com/watch?v=R15CLD9YZB4";

            var youtubesender = new YoutubeSender();
            var youtubereceiver = new YoutubeReceiver();

            youtubesender.SetCommand(new CommandInfo(youtubereceiver));
            await youtubesender.Load(videoIdOrUrl);

            youtubesender.SetCommand(new CommandLoad(youtubereceiver));
            await youtubesender.Load(videoIdOrUrl);

        }
    }
}
