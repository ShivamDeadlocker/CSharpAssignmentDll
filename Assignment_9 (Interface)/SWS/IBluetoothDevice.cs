using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWS
{
    /// <summary>
    /// Interface representing Bluetooth functionality.
    /// Any device implementing this interface must support Bluetooth connection.
    /// </summary>
    interface IBluetoothDevice
    {
        string ConnectBluetooth();
    }
}