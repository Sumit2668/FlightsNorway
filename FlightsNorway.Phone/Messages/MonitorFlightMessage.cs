﻿using FlightsNorway.Model;
using GalaSoft.MvvmLight.Messaging;

namespace FlightsNorway.Messages
{
    public class MonitorFlightMessage : GenericMessage<Flight>
    {
        public MonitorFlightMessage(Flight content) : base(content)
        {
        }

        public MonitorFlightMessage(object sender, Flight content) : base(sender, content)
        {
        }

        public MonitorFlightMessage(object sender, object target, Flight content) : base(sender, target, content)
        {
        }
    }
}
