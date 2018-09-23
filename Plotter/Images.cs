using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Plotter
{
    class Images
    {
        Bitmap image;
        int x;
        int y;
        int size;
        public void set_image(Bitmap img, int x_coordinate, int y_coordinate, int img_size)
        {
            image = img;
            x = x_coordinate;
            y = y_coordinate;
            size = img_size;
        }
    }
}
