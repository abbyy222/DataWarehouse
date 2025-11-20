using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigData
{
    public partial class TestR : Form
    {
        public TestR()
        {
            InitializeComponent();
        }

        private void TestR_Load(object sender, EventArgs e)
        {
            ApplySimulatedBlur(panel1);
        }
        public void ApplySimulatedBlur(Panel panel)
        {
            // Capture the background
            var bmp = new Bitmap(panel.Width, panel.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(panel.PointToScreen(Point.Empty), Point.Empty, panel.Size);
            }

            // Apply blur effect
            bmp = BlurBitmap(bmp);

            // Set the blurred image as the panel's background
            panel.BackgroundImage = bmp;
            panel.BackgroundImageLayout = ImageLayout.Stretch; // Adjust layout as needed
        }

        public Bitmap BlurBitmap(Bitmap image)
        {
            // Simple blur implementation
            int blurSize = 10;
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            using (Graphics graphics = Graphics.FromImage(blurred))
            {
                for (int xx = 0; xx < image.Width; xx += blurSize)
                {
                    for (int yy = 0; yy < image.Height; yy += blurSize)
                    {
                        int avgR = 0, avgG = 0, avgB = 0, blurPixelCount = 0;

                        for (int x = xx; x < xx + blurSize && x < image.Width; x++)
                        {
                            for (int y = yy; y < yy + blurSize && y < image.Height; y++)
                            {
                                Color pixel = image.GetPixel(x, y);

                                avgR += pixel.R;
                                avgG += pixel.G;
                                avgB += pixel.B;

                                blurPixelCount++;
                            }
                        }

                        avgR = avgR / blurPixelCount;
                        avgG = avgG / blurPixelCount;
                        avgB = avgB / blurPixelCount;

                        using (Brush brush = new SolidBrush(Color.FromArgb(avgR, avgG, avgB)))
                        {
                            graphics.FillRectangle(brush, xx, yy, blurSize, blurSize);
                        }
                    }
                }
            }

            return blurred;
        }
    }
}
