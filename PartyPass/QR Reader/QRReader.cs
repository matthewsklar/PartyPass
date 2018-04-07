using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CnetSDK.Barcode.Scanner.Trial;

namespace PartyPass.QRReader
{
    class QRReader
    {
        public ScanResult[] Scan { get; private set; }

        public QRReader()
        {
            ReadBarcodeFromImage("barcodes.png");
        }

        public void ReadBarcodeFromImage(string file)
        {
            Scan = CSBarcodeScanner.ScanBarcode(file);

            foreach (ScanResult s in Scan)
            {
                Console.WriteLine(s.BarcodeType.ToString() + ": " + s.BarcodeData);
            }

            Console.ReadKey();
        }
    }
}
