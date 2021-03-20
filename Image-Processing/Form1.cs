using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(300, 300);
        Bitmap gray_goruntu = new Bitmap(300, 300);
        Bitmap bitmap_goruntu = new Bitmap(300, 300);
        Bitmap erosion_goruntu = new Bitmap(300, 300);
        Bitmap dilation_goruntu = new Bitmap(300, 300);
        Bitmap opening_goruntu = new Bitmap(300, 300);
        Bitmap closing_goruntu = new Bitmap(300, 300);
        Bitmap convulation_goruntu = new Bitmap(300, 300);
        Bitmap gradient_goruntu = new Bitmap(300, 300);
        Bitmap STD_goruntu = new Bitmap(300, 300);

        public Form1()
        {
            InitializeComponent();
        }

        private void ResimYukle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
            Graphics.FromImage(bmp).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
            Graphics.FromImage(gray_goruntu).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
            Graphics.FromImage(bitmap_goruntu).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
            Graphics.FromImage(erosion_goruntu).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
            Graphics.FromImage(dilation_goruntu).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
            Graphics.FromImage(opening_goruntu).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
            Graphics.FromImage(closing_goruntu).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
            Graphics.FromImage(convulation_goruntu).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
            Graphics.FromImage(gradient_goruntu).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
            Graphics.FromImage(STD_goruntu).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
        }

        private void Grayscale_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                for (int i = 0; i < 300; i++)
                {
                    for (int j = 0; j < 300; j++)
                    {
                        renk = gray_goruntu.GetPixel(i, j);
                        int grayscale = (renk.R + renk.G + renk.B) / 3;
                        renk = Color.FromArgb(grayscale, grayscale, grayscale);
                        gray_goruntu.SetPixel(i, j, renk);
                    }
                }
                pictureBox1.Image = gray_goruntu;
            }
        }

        private void Bitmap_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int threshold = Convert.ToInt32(textBox_threshold.Text);

                Color renk;
                for (int i = 0; i < 300; i++)
                {
                    for (int j = 0; j < 300; j++)
                    {
                        renk = bitmap_goruntu.GetPixel(i, j);
                        int grayscale = (renk.R + renk.G + renk.B) / 3;
                        if (grayscale >= threshold)
                        {
                            bitmap_goruntu.SetPixel(i, j, Color.White);
                        }
                        else
                        {
                            bitmap_goruntu.SetPixel(i, j, Color.Black);
                        }
                    }
                }
                pictureBox1.Image = bitmap_goruntu;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_threshold.Text = "50";
        }

        private void SetPixelPlus_Click(object sender, EventArgs e)
        {
            int r, g, b;
            int arti_renk = Convert.ToInt32(textBox_threshold.Text);
            Color renk;
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    renk = bmp.GetPixel(i, j);
                    r = renk.R + arti_renk;
                    if (r > 255) r = 255;
                    g = renk.G + arti_renk;
                    if (g > 255) g = 255;
                    b = renk.B + arti_renk;
                    if (b > 255) b = 255;
                    bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox1.Image = bmp;
        }

        private void SetPixelMinus_Click(object sender, EventArgs e)
        {
            int r, g, b;
            int arti_renk = Convert.ToInt32(textBox_threshold.Text);
            Color renk;
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    renk = bmp.GetPixel(i, j);
                    r = renk.R - arti_renk;
                    if (r < 0) r = 0;
                    g = renk.G - arti_renk;
                    if (g < 0) g = 0;
                    b = renk.B - arti_renk;
                    if (b < 0) b = 0;
                    bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox1.Image = bmp;
        }

        private void TersSimetri_Click(object sender, EventArgs e)
        {
            Color renk, tmp;
            for (int i = 0; i < 150; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    renk = bmp.GetPixel(i, j);
                    tmp = bmp.GetPixel(300 - i - 1, j);
                    bmp.SetPixel(i, j, tmp);
                    bmp.SetPixel(300 - i - 1, j, renk);
                }
            }
            pictureBox1.Image = bmp;
        }

        private void Erosion_Click(object sender, EventArgs e)
        {
            int x1 = 255, x2 = 255, x3 = 255, b1, b2, b3;
            Color renk;
            for (int j = 0; j < 300; j++)
            {
                for (int i = 1; i < 299; i++)
                {
                    renk = bitmap_goruntu.GetPixel(i, j);
                    b1 = renk.R;
                    renk = bitmap_goruntu.GetPixel(i - 1, j);
                    b2 = renk.R;
                    renk = bitmap_goruntu.GetPixel(i + 1, j);
                    b3 = renk.R;
                    if (x1 == b1 && x2 == b2 && x3 == b3)
                    {
                        erosion_goruntu.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        erosion_goruntu.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }

                }

            }
            pictureBox1.Image = erosion_goruntu;

        }

        private void Dilation_Click(object sender, EventArgs e)
        {
            int x1 = 255, x2 = 255, x3 = 255, b1, b2, b3;
            Color renk;
            for (int j = 0; j < 300; j++)
            {
                for (int i = 1; i < 299; i++)
                {
                    renk = bitmap_goruntu.GetPixel(i, j);
                    b1 = renk.R;
                    renk = bitmap_goruntu.GetPixel(i - 1, j);
                    b2 = renk.R;
                    renk = bitmap_goruntu.GetPixel(i + 1, j);
                    b3 = renk.R;
                    if (x1 == b1 || x2 == b2 || x3 == b3)
                    {
                        dilation_goruntu.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        dilation_goruntu.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }

                }

            }
            pictureBox1.Image = dilation_goruntu;

        }

        private void Opening_Click(object sender, EventArgs e)
        {
            int x1 = 255, x2 = 255, x3 = 255, b1, b2, b3;
            Color renk;
            for (int j = 0; j < 300; j++)
            {
                for (int i = 1; i < 299; i++)
                {
                    renk = bitmap_goruntu.GetPixel(i, j);
                    b1 = renk.R;
                    renk = bitmap_goruntu.GetPixel(i - 1, j);
                    b2 = renk.R;
                    renk = bitmap_goruntu.GetPixel(i + 1, j);
                    b3 = renk.R;
                    if (x1 == b1 && x2 == b2 && x3 == b3)
                    {
                        erosion_goruntu.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        erosion_goruntu.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }

                }
            }
            //***************************************************************************
            for (int y = 0; y < 300; y++)
            {
                for (int x = 1; x < 299; x++)
                {
                    renk = erosion_goruntu.GetPixel(x, y);
                    b1 = renk.R;
                    renk = erosion_goruntu.GetPixel(x - 1, y);
                    b2 = renk.R;
                    renk = erosion_goruntu.GetPixel(x + 1, y);
                    b3 = renk.R;
                    if (x1 == b1 || x2 == b2 || x3 == b3)
                    {
                        opening_goruntu.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        opening_goruntu.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }

                }

            }
            pictureBox1.Image = opening_goruntu;
        }

        private void Closing_Click(object sender, EventArgs e)
        {
            int x1 = 255, x2 = 255, x3 = 255, b1, b2, b3;
            Color renk;
            for (int j = 0; j < 300; j++)
            {
                for (int i = 1; i < 299; i++)
                {
                    renk = bitmap_goruntu.GetPixel(i, j);
                    b1 = renk.R;
                    renk = bitmap_goruntu.GetPixel(i - 1, j);
                    b2 = renk.R;
                    renk = bitmap_goruntu.GetPixel(i + 1, j);
                    b3 = renk.R;
                    if (x1 == b1 || x2 == b2 || x3 == b3)
                    {
                        dilation_goruntu.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        dilation_goruntu.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }

                }

            }
            //**********************************************************
            for (int j = 0; j < 300; j++)
            {
                for (int i = 1; i < 299; i++)
                {
                    renk = dilation_goruntu.GetPixel(i, j);
                    b1 = renk.R;
                    renk = dilation_goruntu.GetPixel(i - 1, j);
                    b2 = renk.R;
                    renk = dilation_goruntu.GetPixel(i + 1, j);
                    b3 = renk.R;
                    if (x1 == b1 && x2 == b2 && x3 == b3)
                    {
                        closing_goruntu.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        closing_goruntu.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }

                }

            }
            pictureBox1.Image = closing_goruntu;
        }

        private void Convulation_Click(object sender, EventArgs e)
        {
            int x1 = -1, x2 = -1, x3 = -1, x4 = -1, x5 = 8, x6 = -1, x7 = -1, x8 = -1, x9 = -1;
            int b1, b2, b3, b4, b5, b6, b7, b8, b9, sonuc;
            Color renk;
            for (int x = 1; x <= 298; x++)
            {
                for (int y = 1; y <= 298; y++)
                {
                    renk = bitmap_goruntu.GetPixel(x - 1, y - 1);
                    b1 = renk.R;
                    renk = bitmap_goruntu.GetPixel(x, y - 1);
                    b2 = renk.R;
                    renk = bitmap_goruntu.GetPixel(x + 1, y - 1);
                    b3 = renk.R;
                    renk = bitmap_goruntu.GetPixel(x - 1, y);
                    b4 = renk.R;
                    renk = bitmap_goruntu.GetPixel(x, y);
                    b5 = renk.R;
                    renk = bitmap_goruntu.GetPixel(x + 1, y);
                    b6 = renk.R;
                    renk = bitmap_goruntu.GetPixel(x - 1, y + 1);
                    b7 = renk.R;
                    renk = bitmap_goruntu.GetPixel(x, y + 1);
                    b8 = renk.R;
                    renk = bitmap_goruntu.GetPixel(x + 1, y - 1);
                    b9 = renk.R;

                    sonuc = (x1 * b1) + (x1 * b1) + (x2 * b2) + (x3 * b3) + (x4 * b4) + (x5 * b5) + (x6 * b6) + (x7 * b7) + (x8 * b8) + (x9 * b9);
                    if (sonuc > 255) sonuc = 255;
                    if (sonuc < 0) sonuc = 0;

                    convulation_goruntu.SetPixel(x, y, Color.FromArgb(sonuc, sonuc, sonuc));
                }

            }
            pictureBox1.Image = convulation_goruntu;
        }

        private void Gradient_Click(object sender, EventArgs e)
        {
            //x1 x2
            //Gradient filter=[-1 1]
            // [-1 1]
            //x3 x4

            int gradient;
            Color cl;
            int x1, x2, x3, x4;
            int b1, b2, b3, b4;
            x1 = -1; x2 = 1; x3 = -1; x4 = 1;
            for (int x = 1; x < 299; x++)
            {
                for (int y = 1; y < 299; y++)
                {
                    cl = gray_goruntu.GetPixel(x, y);
                    b1 = cl.R;
                    cl = gray_goruntu.GetPixel(x + 1, y);
                    b2 = cl.R;
                    cl = gray_goruntu.GetPixel(x, y + 1);
                    b3 = cl.R;
                    cl = gray_goruntu.GetPixel(x + 1, y + 1);
                    b4 = cl.R;
                    gradient = x1 * b1 + x2 * b2 + x3 * b3 + x4 * b4;
                    if (gradient > 255) gradient = 255;
                    if (gradient < 0) gradient = 0;
                    gradient_goruntu.SetPixel(x, y, Color.FromArgb(gradient, gradient, gradient));
                }

            }
            pictureBox1.Image = gradient_goruntu;
        }

        private void STD_Click(object sender, EventArgs e)
        {
            int ort_toplam, standart_toplam;
            double ort, STD;
            Color cl;
            ort_toplam = 0;
            standart_toplam = 0;
            for (int x = 1; x < 299; x++)
            {
                for (int y = 1; y < 299; y++)
                {
                    cl = gray_goruntu.GetPixel(x, y);
                    ort_toplam += cl.R;
                }
            }
            ort = ort_toplam / (300 * 300);
            for (int x = 1; x < 299; x++)
            {
                for (int y = 1; y < 299; y++)
                {
                    int gecici;
                    int piksel;
                    cl = gray_goruntu.GetPixel(x, y);
                    piksel = cl.R;
                    gecici = Convert.ToInt32(ort) - piksel;
                    standart_toplam += gecici * gecici;
                }
            }
            STD = Math.Sqrt(standart_toplam / (300 * 300 - 1));
            int taban, tavan;
            taban = (int)Math.Abs(ort - STD);
            tavan = (int)Math.Abs(ort + STD);
            for (int x = 1; x < 299; x++)
            {
                for (int y = 1; y < 299; y++)
                {

                    int piksel;
                    cl = gray_goruntu.GetPixel(x, y);
                    piksel = cl.R;
                    if ((piksel >= taban) && (piksel <= tavan))
                    {
                        STD_goruntu.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        STD_goruntu.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            pictureBox1.Image = STD_goruntu;
        }
    }
}



