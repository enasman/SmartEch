using Android.Bluetooth;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartEch.Models
{
    [Serializable]
    public class SavedDevice
    {
        public BluetoothDevice BikeBluetoothDevice { get; set; }  
        
        public BluetoothDevice HRBluetoothDevice { get; set; }
    }
}
