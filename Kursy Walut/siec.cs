using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Kursy_Walut
{
    class siec
    {
        const string srcBankier = @"http://www.bankier.pl/inwestowanie/notowania/waluty/currency.html";
        public const string destBankier = "bankier.html";

        public static int pobierzKursy()
        {
            WebClient httpClient = new WebClient();
            try
            {
                httpClient.DownloadFile(srcBankier, destBankier);
            }
            catch
            {
                return 0;
            }
            return 1;
        }
    }
}
