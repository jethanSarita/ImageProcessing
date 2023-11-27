using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessingTake2
{
    public partial class Form1 : Form
    {
        Bitmap loadImage, resultImage, bgImage;
        int xSize, ySize;
        private Device webcamDevice;
        public Form1()
        {
            InitializeComponent();
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void grayscaleBtn_Click(object sender, EventArgs e)
        {
            resultImage = initBit();
            for(int x = 0; x < xSize; x++)
                for(int y = 0; y < ySize; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    Color grayedPixel = Color.FromArgb(gray, gray, gray);
                    resultImage.SetPixel(x, y, grayedPixel);
                }
            pictureBox2.Image = resultImage;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            resultImage = initBit();
            for (int x = 0; x < xSize; x++)
                for(int y = 0; y < ySize; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    resultImage.SetPixel(x, y, pixel);
                }
            pictureBox2.Image = resultImage;
        }

        private void invertBtn_Click(object sender, EventArgs e)
        {
            resultImage = initBit();
            for(int x = 0; x < xSize; x++)
                for(int y = 0; y < ySize; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    Color invertedPixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    resultImage.SetPixel(x, y, invertedPixel);
                }
            pictureBox2.Image = resultImage;
        }

        private void histBtn_Click(object sender, EventArgs e)
        {
            resultImage = initBit();
            for(int x = 0; x < xSize; x++)
                for(int y = 0; y < ySize; y++)
                {
                    Color pixel1 = loadImage.GetPixel(x, y);
                    int gray = (pixel1.R + pixel1.G + pixel1.B) / 3;
                    Color grayedPixel = Color.FromArgb(gray, gray, gray);
                    resultImage.SetPixel(x, y, grayedPixel);
                }
            Color pixel2;
            int[] histData = new int[256];
            for(int x = 0; x < xSize; x++)
                for(int y = 0; y < ySize; y++)
                {
                    pixel2 = resultImage.GetPixel(x, y);
                    histData[pixel2.R]++;
                }
            Bitmap histMap = new Bitmap(256, 800);
            for(int x = 0; x < 256; x++)
                for(int y = 0; y < 800; y++)
                {
                    histMap.SetPixel(x, y, Color.White);
                }
            for(int x = 0; x < 256; x++)
                for(int y = 0; y < Math.Min(histData[x]/5, 800); y++)
                {
                    histMap.SetPixel(x, y, Color.Black);
                }
            pictureBox2.Image = histMap;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            resultImage.Save(saveFileDialog1.FileName);
        }

        private void sepiaBtn_Click(object sender, EventArgs e)
        {
            resultImage = initBit();
            for(int x = 0; x < xSize; x++)
                for(int y = 0; y < ySize; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);

                    int speiaR = (int)(pixel.R * 0.393 + pixel.G * 0.769 + pixel.B * 0.189);
                    int speiaG = (int)(pixel.R * 0.349 + pixel.G * 0.686 + pixel.B * 0.168);
                    int speiaB = (int)(pixel.R * 0.272 + pixel.G * 0.534 + pixel.B * 0.131);

                    speiaR = Math.Min(255, speiaR);
                    speiaG = Math.Min(255, speiaG);
                    speiaB = Math.Min(255, speiaB);

                    resultImage.SetPixel(x, y, Color.FromArgb(speiaR, speiaG, speiaB));
                }
            pictureBox2.Image = resultImage;
        }

        private void loadBGBtn_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color extractedGreen = loadImage.GetPixel(0, 0); //grab topleft pixel (assuming it is gren)
            int greygreen = (extractedGreen.R + extractedGreen.G + extractedGreen.B) / 3;
            int threshold = 5;
            for (int x = 0; x < loadImage.Width; x++)
                for (int y = 0; y < loadImage.Height; y++)
                {
                    Color mainPixel = loadImage.GetPixel(x, y);
                    Color backPixel = bgImage.GetPixel(x, y);
                    int grey = (mainPixel.R + mainPixel.G + mainPixel.B) / 3;
                    int substractValue = Math.Abs(grey - greygreen);
                    if (substractValue > threshold)
                        resultImage.SetPixel(x, y, mainPixel);
                    else
                        resultImage.SetPixel(x, y, backPixel);
                }
            pictureBox2.Image = resultImage;
        }

        private void cameraBtn_Click(object sender, EventArgs e)
        {
            Device[] devices = DeviceManager.GetAllDevices();

            if(devices.Length > 0)
            {
                webcamDevice = devices[0];
                webcamDevice.ShowWindow(pictureBox1);
            }
            else
            {
                MessageBox.Show("No webcam devices found.");
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap temp = new Bitmap(openFileDialog2.FileName);
            bgImage = new Bitmap(loadImage.Width, loadImage.Height);
            using (Graphics graphics = Graphics.FromImage(bgImage))
            {
                graphics.DrawImage(temp, 0, 0, loadImage.Width, loadImage.Height);
            }

            pictureBox3.Image = bgImage;

            temp.Dispose();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loadImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loadImage;
            xSize = loadImage.Width;
            ySize = loadImage.Height;
        }

        private Bitmap initBit()
        {
            return new Bitmap(xSize, ySize);
        }
    }
}
