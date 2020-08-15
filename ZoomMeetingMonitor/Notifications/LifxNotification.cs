using LifxNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomMeetingMonitor.Notifications
{
    class LifxNotification : INotification
    {
        LifxNet.LifxClient _client;
        public LifxNet.LifxClient client
        {
            get
            {
                if(_client == null)
                    _client = LifxNet.LifxClient.CreateAsync().Result;
                return _client;
            }
        }

        LifxNet.Color onColor = new LifxNet.Color();
        LifxNet.Color offColor = new LifxNet.Color();
        public void OnMeetingEnd()
        {
            offColor.R = 255;
            offColor.G = 255;
            offColor.B = 255;
            client.DeviceDiscovered += Client_DeviceDiscoveredOff;
            client.StartDeviceDiscovery();
        }

        public void OnMeetingStart(System.Drawing.Color notificationColor)
        {
            offColor.R = notificationColor.R;
            offColor.G = notificationColor.G;
            offColor.B = notificationColor.B;
            client.DeviceDiscovered += Client_DeviceDiscoveredOn;
            client.StartDeviceDiscovery();
        }

        private async void Client_DeviceDiscoveredOn(object sender, LifxNet.LifxClient.DeviceDiscoveryEventArgs e)
        {
            var bulb = e.Device as LifxNet.LightBulb;
            await client.SetDevicePowerStateAsync(bulb, true); //Turn bulb on
            await client.SetColorAsync(bulb, onColor, 2700); //Set color to Red and 2700K Temperature	
        }

        private async void Client_DeviceDiscoveredOff(object sender, LifxNet.LifxClient.DeviceDiscoveryEventArgs e)
        {
            var bulb = e.Device as LifxNet.LightBulb;
            await client.SetDevicePowerStateAsync(bulb, true); //Turn bulb on
            await client.SetColorAsync(bulb, offColor, 2700); //Set color to Red and 2700K Temperature			
        }
    }
}
