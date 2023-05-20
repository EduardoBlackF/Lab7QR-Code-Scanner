using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QR_Code_Scanner.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
