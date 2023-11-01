using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace BLL_DAL
{
    public class QRCode
    {
        private Action<string> _onQRCodeReceived;

        public QRCode(Action<string> onQRCodeReceived)
        {
            _onQRCodeReceived = onQRCodeReceived;
        }

        //public override void OnReceive(Context context, Intent intent)
        //{
        //        if (intent.Action == "com.example.QRCodeReader")
        //{
        //string content = intent.GetStringExtra("content");
        //_onQRCodeReceived?.Invoke(content);

    }
}
        //public Bitmap GenerateQRCode(string content)
        //{
        //    BarcodeWriter writer = new BarcodeWriter
        //    {
        //        Format = BarcodeFormat.QR_CODE,
        //        Options = new EncodingOptions
        //        {
        //            Height = 300,
        //            Width = 300,
        //            Margin = 0
        //        }
        //    };

        //    return writer.Write(content);
        //}
   
