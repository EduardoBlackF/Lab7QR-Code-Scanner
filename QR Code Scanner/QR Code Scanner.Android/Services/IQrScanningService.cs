using Android.App;
using Android.Content;
using Android.Nfc.Tech;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QR_Code_Scanner.Services;
using ZXing.Mobile;
using Xamarin.Forms;
using QR_Code_Scanner.Services;

[assembly: Dependency(typeof(QR_Code_Scanner.Droid.Services.QrScanningService))]
namespace QR_Code_Scanner.Droid.Services
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner() { TopText = "Scan the Bar Code", BottomText = "Click mobile cancel button to cancel scanning.", CancelButtonText = "Cancel" };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}