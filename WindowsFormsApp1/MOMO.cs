using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace WindowsFormsApp1
{
    public partial class MOMO : Form
    {
        public MOMO()
        {
            InitializeComponent();
        }

        #region MOMO Payment
        private void btnMOMO_Click(object sender, EventArgs e)
        {
            int tong = Form1.tong;
            txtTongMOMO.Text = tong.ToString();
            PayMOMO(sender, e);
        }

        private void PayMOMO(object sender, EventArgs e)
        {
            var qrcode_text = $"2|99|0981037321|vi|vi@gmail.com|0|0|{txtTongMOMO.Text.Trim()}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 370, Height = 370, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            Bitmap logo = resizeImage(Properties.Resources.images__1_, 64, 64) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            picMoMoQR.Image = bitmap;
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
