using System;

namespace DecoratorPatternPhoto
{
    public class PhotoBuilder
    {
        public string FileName { get; set; }
        public string HotelName { get; set; }
        public string FromUrl { get; set; }

        public PhotoBuilder(string p1, string p2)
        {
            FileName = p1;
            HotelName = p2;
            FromUrl = p2;
        }

        public PhotoBuilder Hotel(string name)
        {
            FileName = name;
            return this;
        }

        public Photo Builder()
        {
            var p = new Photo(this);
            if (p.FileName == "")
            {
                throw new Exception("Otel adı yok.");
            }
            return p;
        }
    }
}
