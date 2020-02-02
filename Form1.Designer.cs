namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblFeels = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbMist = new System.Windows.Forms.PictureBox();
            this.pbSnow = new System.Windows.Forms.PictureBox();
            this.pbThunderstorm = new System.Windows.Forms.PictureBox();
            this.pbRain = new System.Windows.Forms.PictureBox();
            this.pbShowerRain = new System.Windows.Forms.PictureBox();
            this.pbBrokenClouds = new System.Windows.Forms.PictureBox();
            this.pbScatteredClouds = new System.Windows.Forms.PictureBox();
            this.pbFewClouds = new System.Windows.Forms.PictureBox();
            this.pbClearSky = new System.Windows.Forms.PictureBox();
            this.pbClear = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThunderstorm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowerRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrokenClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScatteredClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFewClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClearSky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(60, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemp.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblTemp.Location = new System.Drawing.Point(53, 186);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(89, 58);
            this.lblTemp.TabIndex = 10;
            this.lblTemp.Text = "-11";
            // 
            // lblFeels
            // 
            this.lblFeels.AutoSize = true;
            this.lblFeels.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFeels.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblFeels.Location = new System.Drawing.Point(140, 237);
            this.lblFeels.Name = "lblFeels";
            this.lblFeels.Size = new System.Drawing.Size(23, 26);
            this.lblFeels.TabIndex = 11;
            this.lblFeels.Text = "7";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.BackColor = System.Drawing.Color.Transparent;
            this.lblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblO.Location = new System.Drawing.Point(126, 188);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(18, 20);
            this.lblO.TabIndex = 13;
            this.lblO.Text = "о";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(10, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ощущается как:";
            // 
            // pbMist
            // 
            this.pbMist.Image = global::WeatherApp.Properties.Resources.mist;
            this.pbMist.Location = new System.Drawing.Point(25, 36);
            this.pbMist.Name = "pbMist";
            this.pbMist.Size = new System.Drawing.Size(150, 150);
            this.pbMist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMist.TabIndex = 23;
            this.pbMist.TabStop = false;
            // 
            // pbSnow
            // 
            this.pbSnow.Image = global::WeatherApp.Properties.Resources.snow;
            this.pbSnow.Location = new System.Drawing.Point(25, 36);
            this.pbSnow.Name = "pbSnow";
            this.pbSnow.Size = new System.Drawing.Size(150, 150);
            this.pbSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSnow.TabIndex = 22;
            this.pbSnow.TabStop = false;
            // 
            // pbThunderstorm
            // 
            this.pbThunderstorm.Image = global::WeatherApp.Properties.Resources.thunderstorm;
            this.pbThunderstorm.Location = new System.Drawing.Point(25, 36);
            this.pbThunderstorm.Name = "pbThunderstorm";
            this.pbThunderstorm.Size = new System.Drawing.Size(150, 150);
            this.pbThunderstorm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThunderstorm.TabIndex = 21;
            this.pbThunderstorm.TabStop = false;
            // 
            // pbRain
            // 
            this.pbRain.Image = global::WeatherApp.Properties.Resources.rain;
            this.pbRain.Location = new System.Drawing.Point(25, 36);
            this.pbRain.Name = "pbRain";
            this.pbRain.Size = new System.Drawing.Size(150, 150);
            this.pbRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRain.TabIndex = 20;
            this.pbRain.TabStop = false;
            // 
            // pbShowerRain
            // 
            this.pbShowerRain.Image = global::WeatherApp.Properties.Resources.shower_rain;
            this.pbShowerRain.Location = new System.Drawing.Point(25, 36);
            this.pbShowerRain.Name = "pbShowerRain";
            this.pbShowerRain.Size = new System.Drawing.Size(150, 150);
            this.pbShowerRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowerRain.TabIndex = 19;
            this.pbShowerRain.TabStop = false;
            // 
            // pbBrokenClouds
            // 
            this.pbBrokenClouds.Image = global::WeatherApp.Properties.Resources.broken_clouds;
            this.pbBrokenClouds.Location = new System.Drawing.Point(25, 36);
            this.pbBrokenClouds.Name = "pbBrokenClouds";
            this.pbBrokenClouds.Size = new System.Drawing.Size(150, 150);
            this.pbBrokenClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBrokenClouds.TabIndex = 18;
            this.pbBrokenClouds.TabStop = false;
            // 
            // pbScatteredClouds
            // 
            this.pbScatteredClouds.Image = global::WeatherApp.Properties.Resources.scattered_clouds;
            this.pbScatteredClouds.Location = new System.Drawing.Point(25, 36);
            this.pbScatteredClouds.Name = "pbScatteredClouds";
            this.pbScatteredClouds.Size = new System.Drawing.Size(150, 150);
            this.pbScatteredClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScatteredClouds.TabIndex = 17;
            this.pbScatteredClouds.TabStop = false;
            // 
            // pbFewClouds
            // 
            this.pbFewClouds.Image = global::WeatherApp.Properties.Resources.few_clouds;
            this.pbFewClouds.Location = new System.Drawing.Point(25, 36);
            this.pbFewClouds.Name = "pbFewClouds";
            this.pbFewClouds.Size = new System.Drawing.Size(150, 150);
            this.pbFewClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFewClouds.TabIndex = 16;
            this.pbFewClouds.TabStop = false;
            // 
            // pbClearSky
            // 
            this.pbClearSky.Image = ((System.Drawing.Image)(resources.GetObject("pbClearSky.Image")));
            this.pbClearSky.Location = new System.Drawing.Point(25, 36);
            this.pbClearSky.Name = "pbClearSky";
            this.pbClearSky.Size = new System.Drawing.Size(150, 150);
            this.pbClearSky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClearSky.TabIndex = 15;
            this.pbClearSky.TabStop = false;
            // 
            // pbClear
            // 
            this.pbClear.Location = new System.Drawing.Point(25, 36);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(150, 150);
            this.pbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClear.TabIndex = 15;
            this.pbClear.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(200, 268);
            this.Controls.Add(this.pbMist);
            this.Controls.Add(this.pbSnow);
            this.Controls.Add(this.pbThunderstorm);
            this.Controls.Add(this.pbRain);
            this.Controls.Add(this.pbShowerRain);
            this.Controls.Add(this.pbBrokenClouds);
            this.Controls.Add(this.pbScatteredClouds);
            this.Controls.Add(this.pbFewClouds);
            this.Controls.Add(this.pbClearSky);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lblFeels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbMist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThunderstorm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowerRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrokenClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScatteredClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFewClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClearSky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblFeels;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbClearSky;
        private System.Windows.Forms.PictureBox pbClear;
        private System.Windows.Forms.PictureBox pbFewClouds;
        private System.Windows.Forms.PictureBox pbScatteredClouds;
        private System.Windows.Forms.PictureBox pbBrokenClouds;
        private System.Windows.Forms.PictureBox pbShowerRain;
        private System.Windows.Forms.PictureBox pbRain;
        private System.Windows.Forms.PictureBox pbThunderstorm;
        private System.Windows.Forms.PictureBox pbSnow;
        private System.Windows.Forms.PictureBox pbMist;
    }
}

