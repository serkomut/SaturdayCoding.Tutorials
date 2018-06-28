using System.Collections.Generic;


namespace DecoratorPatternPhoto
{
    public class PhotoList
    {
        public IEnumerable<Photo> GetHotelPhotos()
        {
            Photo[] hotel =
            {
                new Photo
                {
                    FileName = "Foto 1",
                    HotelName = "Suite Laguna Hotel",
                    FromUrl = @"D:\Gelen/img (1).jpg"
                },
                new Photo
                {
                    FileName = "Foto 2",
                    HotelName = "Dogan Hotel",
                    FromUrl = @"D:\Gelen/img (2).jpg"
                },
                new Photo
                {
                    FileName = "Foto 3",
                    HotelName = "Falan Otel 2",
                    FromUrl = @"D:\Gelen/img (3).jpg"
                },
                new Photo
                {
                    FileName = "Foto 4",
                    HotelName = "Aspen Hotel",
                    FromUrl = @"D:\Gelen/img (4).jpg"
                },
                new Photo
                {
                    FileName = "Foto 5",
                    HotelName = "Bilem High Class Hotel",
                    FromUrl = @"D:\Gelen/img (5).jpg"
                },
                new Photo
                {
                    FileName = "Foto 6",
                    HotelName = "ĞÜŞÇ-İ Otel",
                    FromUrl = @"D:\Gelen/img (6).jpg"
                }
            };
            return hotel;
        }
    }
}