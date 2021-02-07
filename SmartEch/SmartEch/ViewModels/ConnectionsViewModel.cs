using Android.Bluetooth;
using SmartEch.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartEch.ViewModels
{
    public class ConnectionsViewModel : BaseViewModel
    {
        public ConnectionsViewModel()
        {
            Title = "Connections";
            LoadDevicesCommand = new Command(OnLoadDevicesCommand);           
        }      

        private void OnLoadDevicesCommand()
        {
            IsBusy = true;

            try
            {
                if (BluetoothAdapter.DefaultAdapter != null && BluetoothAdapter.DefaultAdapter.IsEnabled)
                {

                    foreach (var pairedDevice in BluetoothAdapter.DefaultAdapter.BondedDevices)
                    {
                        AvailableDevices.Add(pairedDevice);
                    }                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
      
        public ObservableCollection<BluetoothDevice> AvailableDevices { get; }

        public Command LoadDevicesCommand { get; }       
    }
}
