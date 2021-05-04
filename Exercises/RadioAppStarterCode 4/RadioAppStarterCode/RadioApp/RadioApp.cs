using System;
using System.Collections.Generic;
using System.IO;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private int _numChannels;
        private bool _on = false;
        private double _volume;
        public double Volume { get => _volume; set => _volume = value <= 0.0 ? 0.0 : value >= 1.0 ? 1.0 : value ; }

        private static string _folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RadioApp");
        private static string _currentChannelFilePath = Path.Combine(_folderPath, "CurrentChannel.txt");
        private static string _channelDataFilePath = Path.Combine(_folderPath, "RadioStations.txt");

        private readonly List<Uri> _channelURIArray = new List<Uri>();

        public Uri ChannelURI { get => _channelURIArray[_channel - 1]; }

        public int Channel 
        { 
            get => _channel;
            set => _channel = _on && value >= 1 && value <= _numChannels ? value :_channel ;
        }

        public Radio()
        {
            _channelURIArray = LoadStations();
            _numChannels = _channelURIArray.Capacity;
        }

        public string Play() => _on ? $"Playing channel {_channel}" : "Radio is off";

        public void TurnOff() => _on = false;
        public void TurnOn() => _on = true;

        
        public List<Uri> LoadStations()
        {
            if (File.Exists(_channelDataFilePath))
            {
                List<Uri> channelsList = new List<Uri>();

                using (StreamReader inputFile = new StreamReader(_channelDataFilePath))
                {
                    string line;

                    while ((line = inputFile.ReadLine()) != null)
                    {
                        channelsList.Add(new Uri(line));
                    }
                }

                return channelsList;
            }
            else
            {
                List<Uri> channelsList = new List<Uri>
                {
                    new Uri("http://icy-e-bab-04-cr.sharp-stream.com/absoluteradio.mp3"),
                    new Uri("https://stream-al.planetradio.co.uk/kerrang.mp3"),
                    new Uri("http://46.10.150.243/jazz-fm-lounge.mp3"),
                    new Uri("http://live-bauer-mz.sharp-stream.com/viking.mp3")
                 };
                return channelsList;
            } 
        }

        public void SaveChannel()
        {
            if (!Directory.Exists(_folderPath))
                Directory.CreateDirectory(_folderPath);
            using (StreamWriter outputFile = new StreamWriter(_currentChannelFilePath))
            {
                outputFile.WriteLine(_channel);
            }
        }

        public void LoadPreviousChannel()
        {
            if (File.Exists(_currentChannelFilePath))
            {
                using (StreamReader inputFile = new StreamReader(_currentChannelFilePath))
                {
                    Channel = int.Parse(inputFile.ReadLine());
                }
            }
        }
    }

}