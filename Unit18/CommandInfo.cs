using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;
using System.Threading.Tasks;


namespace Unit18
{
    class CommandInfo: ICommand
    {
        YoutubeReceiver receiver;

        
        public CommandInfo(YoutubeReceiver receiver)
        {
            this.receiver = receiver;
        }

       
        public async Task Load(string url)
        {
            await receiver.OperationInfo(url);
        }

       
    }
}
