using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openLibrary.Presatation
{
    public static class Utility
    {
       
            public static Image ByteArrayToImage(byte[] fileBytes)
        {   if (fileBytes.Length == 0) return Properties.Resources.boemployee_32x32;

            using (var stream = new MemoryStream(fileBytes))
            {
                
                return Image.FromStream(stream);
            }
        }

        public static Byte[] ImageToByteArray(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, img.RawFormat);
                return stream.ToArray();
            }
        }
    }

}
