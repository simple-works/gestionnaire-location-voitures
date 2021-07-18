using System.Drawing;
using System.IO;

namespace Car_Rental_Project.API
{
    public static class Picture
    {
        public static byte[] ImageToByteArray(Image image)
        {
            if (image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
            return null;
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray != null)
            {
                MemoryStream memoryStream = new MemoryStream(byteArray);
                return Image.FromStream(memoryStream);
            }
            return null;
        }
    }
}
