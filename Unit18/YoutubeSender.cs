using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Unit18
{
    class YoutubeSender
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }


        public async Task Load(string url)
        {
            if (_command != null)
            {
                await _command.Load(url);
            }
        }

    }
}
