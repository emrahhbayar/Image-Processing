namespace Image_Processing
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResimYukle = new System.Windows.Forms.Button();
            this.Grayscale = new System.Windows.Forms.Button();
            this.Bitmap = new System.Windows.Forms.Button();
            this.TersSimetri = new System.Windows.Forms.Button();
            this.SetPixelMinus = new System.Windows.Forms.Button();
            this.SetPixelPlus = new System.Windows.Forms.Button();
            this.Erosion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Dilation = new System.Windows.Forms.Button();
            this.Opening = new System.Windows.Forms.Button();
            this.Closing = new System.Windows.Forms.Button();
            this.Convulation = new System.Windows.Forms.Button();
            this.Gradient = new System.Windows.Forms.Button();
            this.STD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ResimYukle
            // 
            this.ResimYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResimYukle.Location = new System.Drawing.Point(342, 70);
            this.ResimYukle.Name = "ResimYukle";
            this.ResimYukle.Size = new System.Drawing.Size(116, 41);
            this.ResimYukle.TabIndex = 1;
            this.ResimYukle.Text = "Resim Yükle";
            this.ResimYukle.UseVisualStyleBackColor = true;
            this.ResimYukle.Click += new System.EventHandler(this.ResimYukle_Click);
            // 
            // Grayscale
            // 
            this.Grayscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Grayscale.Location = new System.Drawing.Point(342, 224);
            this.Grayscale.Name = "Grayscale";
            this.Grayscale.Size = new System.Drawing.Size(116, 41);
            this.Grayscale.TabIndex = 2;
            this.Grayscale.Text = "Grayscale";
            this.Grayscale.UseVisualStyleBackColor = true;
            this.Grayscale.Click += new System.EventHandler(this.Grayscale_Click);
            // 
            // Bitmap
            // 
            this.Bitmap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bitmap.Location = new System.Drawing.Point(342, 271);
            this.Bitmap.Name = "Bitmap";
            this.Bitmap.Size = new System.Drawing.Size(116, 41);
            this.Bitmap.TabIndex = 3;
            this.Bitmap.Text = "Bitmap";
            this.Bitmap.UseVisualStyleBackColor = true;
            this.Bitmap.Click += new System.EventHandler(this.Bitmap_Click);
            // 
            // TersSimetri
            // 
            this.TersSimetri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TersSimetri.Location = new System.Drawing.Point(677, 128);
            this.TersSimetri.Name = "TersSimetri";
            this.TersSimetri.Size = new System.Drawing.Size(116, 41);
            this.TersSimetri.TabIndex = 4;
            this.TersSimetri.Text = "Ters Simetri";
            this.TersSimetri.UseVisualStyleBackColor = true;
            this.TersSimetri.Click += new System.EventHandler(this.TersSimetri_Click);
            // 
            // SetPixelMinus
            // 
            this.SetPixelMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SetPixelMinus.Location = new System.Drawing.Point(677, 81);
            this.SetPixelMinus.Name = "SetPixelMinus";
            this.SetPixelMinus.Size = new System.Drawing.Size(116, 41);
            this.SetPixelMinus.TabIndex = 5;
            this.SetPixelMinus.Text = "Set Pixel -";
            this.SetPixelMinus.UseVisualStyleBackColor = true;
            this.SetPixelMinus.Click += new System.EventHandler(this.SetPixelMinus_Click);
            // 
            // SetPixelPlus
            // 
            this.SetPixelPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SetPixelPlus.Location = new System.Drawing.Point(677, 34);
            this.SetPixelPlus.Name = "SetPixelPlus";
            this.SetPixelPlus.Size = new System.Drawing.Size(116, 41);
            this.SetPixelPlus.TabIndex = 6;
            this.SetPixelPlus.Text = "Set Pixel +";
            this.SetPixelPlus.UseVisualStyleBackColor = true;
            this.SetPixelPlus.Click += new System.EventHandler(this.SetPixelPlus_Click);
            // 
            // Erosion
            // 
            this.Erosion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Erosion.Location = new System.Drawing.Point(677, 175);
            this.Erosion.Name = "Erosion";
            this.Erosion.Size = new System.Drawing.Size(116, 41);
            this.Erosion.TabIndex = 7;
            this.Erosion.Text = "Erosion";
            this.Erosion.UseVisualStyleBackColor = true;
            this.Erosion.Click += new System.EventHandler(this.Erosion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(551, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Değer/Threshold :";
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Location = new System.Drawing.Point(674, 8);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(119, 20);
            this.textBox_threshold.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(639, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = " Emrah BAYAR";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Dilation
            // 
            this.Dilation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dilation.Location = new System.Drawing.Point(674, 222);
            this.Dilation.Name = "Dilation";
            this.Dilation.Size = new System.Drawing.Size(116, 41);
            this.Dilation.TabIndex = 11;
            this.Dilation.Text = "Dilation";
            this.Dilation.UseVisualStyleBackColor = true;
            this.Dilation.Click += new System.EventHandler(this.Dilation_Click);
            // 
            // Opening
            // 
            this.Opening.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Opening.Location = new System.Drawing.Point(674, 269);
            this.Opening.Name = "Opening";
            this.Opening.Size = new System.Drawing.Size(116, 41);
            this.Opening.TabIndex = 12;
            this.Opening.Text = "Opening";
            this.Opening.UseVisualStyleBackColor = true;
            this.Opening.Click += new System.EventHandler(this.Opening_Click);
            // 
            // Closing
            // 
            this.Closing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Closing.Location = new System.Drawing.Point(674, 316);
            this.Closing.Name = "Closing";
            this.Closing.Size = new System.Drawing.Size(116, 41);
            this.Closing.TabIndex = 13;
            this.Closing.Text = "Closing";
            this.Closing.UseVisualStyleBackColor = true;
            this.Closing.Click += new System.EventHandler(this.Closing_Click);
            // 
            // Convulation
            // 
            this.Convulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Convulation.Location = new System.Drawing.Point(674, 363);
            this.Convulation.Name = "Convulation";
            this.Convulation.Size = new System.Drawing.Size(116, 41);
            this.Convulation.TabIndex = 14;
            this.Convulation.Text = "Convulation";
            this.Convulation.UseVisualStyleBackColor = true;
            this.Convulation.Click += new System.EventHandler(this.Convulation_Click);
            // 
            // Gradient
            // 
            this.Gradient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gradient.Location = new System.Drawing.Point(483, 224);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(116, 41);
            this.Gradient.TabIndex = 15;
            this.Gradient.Text = "Gradient";
            this.Gradient.UseVisualStyleBackColor = true;
            this.Gradient.Click += new System.EventHandler(this.Gradient_Click);
            // 
            // STD
            // 
            this.STD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.STD.Location = new System.Drawing.Point(483, 271);
            this.STD.Name = "STD";
            this.STD.Size = new System.Drawing.Size(116, 41);
            this.STD.TabIndex = 16;
            this.STD.Text = "STD";
            this.STD.UseVisualStyleBackColor = true;
            this.STD.Click += new System.EventHandler(this.STD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 474);
            this.Controls.Add(this.STD);
            this.Controls.Add(this.Gradient);
            this.Controls.Add(this.Convulation);
            this.Controls.Add(this.Closing);
            this.Controls.Add(this.Opening);
            this.Controls.Add(this.Dilation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_threshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Erosion);
            this.Controls.Add(this.SetPixelPlus);
            this.Controls.Add(this.SetPixelMinus);
            this.Controls.Add(this.TersSimetri);
            this.Controls.Add(this.Bitmap);
            this.Controls.Add(this.Grayscale);
            this.Controls.Add(this.ResimYukle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ResimYukle;
        private System.Windows.Forms.Button Grayscale;
        private System.Windows.Forms.Button Bitmap;
        private System.Windows.Forms.Button TersSimetri;
        private System.Windows.Forms.Button SetPixelMinus;
        private System.Windows.Forms.Button SetPixelPlus;
        private System.Windows.Forms.Button Erosion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_threshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Dilation;
        private System.Windows.Forms.Button Opening;
        private System.Windows.Forms.Button Closing;
        private System.Windows.Forms.Button Convulation;
        private System.Windows.Forms.Button Gradient;
        private System.Windows.Forms.Button STD;
    }
}

