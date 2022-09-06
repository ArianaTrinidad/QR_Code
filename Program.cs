using System;
using IronBarCode;

namespace QR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the text you want convert in QR code");

            var txtToQR = Console.ReadLine();

            Console.WriteLine("What name do you want to give the image?");

            var fileName = Console.ReadLine();

            GeneratedBarcode qrCode = IronBarCode.BarcodeWriter.CreateBarcode(txtToQR, BarcodeEncoding.QRCode);
            
            qrCode.SaveAsPng($"{fileName}.png"); // los guarda en la carpeta bin

            Console.WriteLine($"Your image has been save as {fileName}.png");
        }
    }
}
