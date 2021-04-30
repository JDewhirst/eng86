using System;
using System.Collections.Generic;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;

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