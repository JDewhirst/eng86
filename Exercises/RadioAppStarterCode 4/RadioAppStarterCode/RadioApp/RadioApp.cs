using System;
using System.IO;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;
        private static string _folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RadioApp");
        private static string _channelFilePath = Path.Combine(_folderPath, "WriteFile.txt");

        private Uri[] _channelURIArray = new Uri[4]
        {
            new Uri("http://icy-e-bab-04-cr.sharp-stream.com/absoluteradio.mp3"),
            new Uri("https://stream-al.planetradio.co.uk/kerrang.mp3"),
            new Uri("http://46.10.150.243/jazz-fm-lounge.mp3"),
            new Uri("http://live-bauer-mz.sharp-stream.com/viking.mp3")
        };

        public Uri ChannelURI { get => _channelURIArray[_channel - 1]; }

        public int Channel 
        { 
            get => _channel;
            set => _channel = _on && value >= 1 && value <= 4 ? value :_channel ;
        }

        public string Play() => _on ? $"Playing channel {_channel}" : "Radio is off";

        public void TurnOff() => _on = false;
        public void TurnOn() => _on = true;

        public void SaveChannel()
        {
            if (!Directory.Exists(_folderPath))
                Directory.CreateDirectory(_folderPath);
            using (StreamWriter outputFile = new StreamWriter(_channelFilePath))
            {
                outputFile.WriteLine(_channel);
            }
        }

        public void LoadChannel()
        {

            if (Directory.Exists(_folderPath))
            {
                using (StreamReader inputFile = new StreamReader(_channelFilePath))
                {
                    _channel = int.Parse(inputFile.ReadLine());
                }
            }
        }
    }

}