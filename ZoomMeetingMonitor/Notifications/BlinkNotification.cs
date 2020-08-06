using Sleddog.Blink1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomMeetingMonitor.Notifications
{
    public class BlinkNotification : INotification
    {
        public void OnMeetingEnd()
        {
            BlinkHelper.TurnOff();
        }

        public void OnMeetingStart(Color notificationColor)
        {
            BlinkHelper.SetBlinkColor(notificationColor);
        }
    }

    public static class BlinkHelper
    {
        public static void SetBlinkColor(Color color)
        {
            var connected = Blink1Connector.Scan();
            foreach (Blink1 blink in connected.ToArray())
            {
                blink.Set(color);
            }
        }

        public static void TurnOff()
        {
            var connected = Blink1Connector.Scan();
            foreach (Blink1 blink in connected.ToArray())
            {
                blink.TurnOff();
            }
        }
    }
}
