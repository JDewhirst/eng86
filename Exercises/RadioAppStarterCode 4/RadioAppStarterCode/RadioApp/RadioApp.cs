using System;
using System.Collections.Generic;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;

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
    }

}