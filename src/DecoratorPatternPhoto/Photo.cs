using System;
using System.Globalization;
using System.Net;

namespace DecoratorPatternPhoto
{
    public class Photo
    {
        public string FileName { get; set; }
        public string HotelName { get; set; }
        public string FromUrl { get; set; }
        public Photo()
        {

        }
        public Photo(PhotoBuilder photoBuilder)
        {
            FileName = photoBuilder.FileName;
            HotelName = photoBuilder.HotelName;
            FromUrl = photoBuilder.FromUrl;
        }

        public Photo(string filename, string hotelname, string fromurl)
        {
            FileName = filename;
            HotelName = hotelname;
            FromUrl = fromurl;
        }

        public string RandomString(int lenght, string lowuprand)
        {
            var cr = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            FileName = string.Empty;
            var random = new Random();

            for (var i = 0; i < lenght; i++)
            {
                FileName += cr[random.Next(0, cr.Length - 1)].ToString(CultureInfo.InvariantCulture);
            }
            switch (lowuprand)
            {
                case "low":
                    FileName = FileName.ToLowerInvariant();
                    break;
                case "up":
                    FileName = FileName.ToUpperInvariant();
                    break;
            }
            return FileName;
        }

        public void MoveToPhotos()
        {
            var webClient = new WebClient();
            webClient.DownloadFile(FromUrl, ToUrl + FileName);
        }
    }
}
