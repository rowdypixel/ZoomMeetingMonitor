using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomMeetingMonitor.Notifications
{
    interface INotification
    {
        void OnMeetingStart(Color notificationColor);

        void OnMeetingEnd();
    }
}
