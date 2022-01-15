using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RobloxAssetDownloader {
    public partial class UI : Form {
        public UI() { InitializeComponent(); }
        public string GetBetween(string source, string start, string end) {
            int Start, End;
            if (source.Contains(start) && source.Contains(end))
                if (source.Substring(source.IndexOf(start)).Contains(end))
                    try {
                        Start = source.IndexOf(start, 0) + start.Length;
                        End = source.IndexOf(end, Start);
                        return source.Substring(Start, End - Start); }
                    catch (ArgumentOutOfRangeException) { return ""; }
                else return "";
            else return ""; }
        private void Loaded(object sender, EventArgs e) { Directory.CreateDirectory(Environment.CurrentDirectory + "\\Download"); }

        private void TextFocus(object sender, EventArgs e) {
            URLBox.ForeColor = Color.Black;
            if (URLBox.Text == "Enter Clothing ID or Catalog URL (eg. 6607924538)") URLBox.Text = "";
            URLBox.Text = Regex.Replace(URLBox.Text, "[^0-9]", ""); }

        private void GithubLink(object sender, EventArgs e) { Process.Start("https://github.com/uDMBK/RobloxAssetDownloader-CSharp"); }

        private void Download(object sender, EventArgs e) {
            string html, imagelocation = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://assetdelivery.roblox.com/v1/asset/?id={URLBox.Text}");
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream)) { html = reader.ReadToEnd(); }}

            string AssetId = GetBetween(html, "<url>http://www.roblox.com/asset/?id=", "</url>");
            HttpWebRequest imagelocationreq = (HttpWebRequest)WebRequest.Create($"https://assetdelivery.roblox.com/v1/assetid/{AssetId}");
            imagelocationreq.AutomaticDecompression = DecompressionMethods.GZip;
            
            using (HttpWebResponse iresponse = (HttpWebResponse)imagelocationreq.GetResponse())
            using (Stream istream = iresponse.GetResponseStream())
            using (StreamReader reader = new StreamReader(istream)) { imagelocation = reader.ReadToEnd(); }
            
            string imageloc = GetBetween(imagelocation, "{\"location\":\"", "\"");
            HttpWebRequest imagereq = (HttpWebRequest)WebRequest.Create(imageloc);
            imagereq.AutomaticDecompression = DecompressionMethods.GZip;
            
            Bitmap img = new Bitmap(1, 1);
            using (HttpWebResponse iresponse = (HttpWebResponse)imagereq.GetResponse())
            using (Stream istream = iresponse.GetResponseStream()) img = (Bitmap)Image.FromStream(istream);

            if (!noOverlay.Checked)
                using (Graphics g = Graphics.FromImage(img)) {
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                    if (Shirt.Checked) g.DrawImage(Properties.Resources.shirt_template, new RectangleF(0, 0, img.Width, img.Height));
                    else g.DrawImage(Properties.Resources.pants_template, new RectangleF(0, 0, img.Width, img.Height)); }
            ImageOutput.Image = img;
            
            Directory.CreateDirectory(Environment.CurrentDirectory + "\\Download");
            img.Save($"{Environment.CurrentDirectory}\\Download\\{URLBox.Text}.png", System.Drawing.Imaging.ImageFormat.Png); }}}
