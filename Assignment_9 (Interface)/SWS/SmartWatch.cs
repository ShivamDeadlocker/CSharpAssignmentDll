using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWS
{
    /// <summary>
    /// SmartWatch class implementing multiple interfaces.
    /// Demonstrates multiple interface inheritance.
    /// </summary>
    public class SmartWatch : IFitenessTracker, IBluetoothDevice, INotificationService
    {

        public string TrackFitness()
        {
            return "Tracking the fitness!!!";
        }

        public string ConnectBluetooth()
        {
            return "Bluetooth is connected!!!";
        }

        public string ShowNotification()
        {
            return "New Notification is arrived!!!";
        }

    }
}
