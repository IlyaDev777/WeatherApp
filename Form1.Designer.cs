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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblFeels = new System.Windows.Forms.Label();
            this.pbDefault = new System.Windows.Forms.PictureBox();
            this.pbThander = new System.Windows.Forms.PictureBox();
            this.pbSunny = new System.Windows.Forms.PictureBox();
            this.pbSun = new System.Windows.Forms.PictureBox();
            this.pbSnow = new System.Windows.Forms.PictureBox();
            this.pbFog = new System.Windows.Forms.PictureBox();
            this.pbRain = new System.Windows.Forms.PictureBox();
            this.pbLightRain = new System.Windows.Forms.PictureBox();
            this.pbOvercast = new System.Windows.Forms.PictureBox();
            this.pbCloudy = new System.Windows.Forms.PictureBox();
            this.lblO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLightRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOvercast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloudy)).BeginInit();
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
            // pbDefault
            // 
            this.pbDefault.Image = global::WeatherApp.Properties.Resources.pumpkin;
            this.pbDefault.Location = new System.Drawing.Point(25, 38);
            this.pbDefault.Name = "pbDefault";
            this.pbDefault.Size = new System.Drawing.Size(150, 150);
            this.pbDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDefault.TabIndex = 12;
            this.pbDefault.TabStop = false;
            // 
            // pbThander
            // 
            this.pbThander.Image = global::WeatherApp.Properties.Resources.Thunderstorms;
            this.pbThander.Location = new System.Drawing.Point(25, 38);
            this.pbThander.Name = "pbThander";
            this.pbThander.Size = new System.Drawing.Size(150, 150);
            this.pbThander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThander.TabIndex = 9;
            this.pbThander.TabStop = false;
            // 
            // pbSunny
            // 
            this.pbSunny.Image = global::WeatherApp.Properties.Resources.Sunny;
            this.pbSunny.Location = new System.Drawing.Point(25, 38);
            this.pbSunny.Name = "pbSunny";
            this.pbSunny.Size = new System.Drawing.Size(150, 150);
            this.pbSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSunny.TabIndex = 8;
            this.pbSunny.TabStop = false;
            // 
            // pbSun
            // 
            this.pbSun.Image = global::WeatherApp.Properties.Resources.Sun;
            this.pbSun.Location = new System.Drawing.Point(25, 38);
            this.pbSun.Name = "pbSun";
            this.pbSun.Size = new System.Drawing.Size(150, 150);
            this.pbSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSun.TabIndex = 7;
            this.pbSun.TabStop = false;
            // 
            // pbSnow
            // 
            this.pbSnow.Image = global::WeatherApp.Properties.Resources.Snow;
            this.pbSnow.Location = new System.Drawing.Point(25, 38);
            this.pbSnow.Name = "pbSnow";
            this.pbSnow.Size = new System.Drawing.Size(150, 150);
            this.pbSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSnow.TabIndex = 6;
            this.pbSnow.TabStop = false;
            // 
            // pbFog
            // 
            this.pbFog.Image = global::WeatherApp.Properties.Resources.Fog;
            this.pbFog.Location = new System.Drawing.Point(25, 38);
            this.pbFog.Name = "pbFog";
            this.pbFog.Size = new System.Drawing.Size(150, 150);
            this.pbFog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFog.TabIndex = 5;
            this.pbFog.TabStop = false;
            // 
            // pbRain
            // 
            this.pbRain.Image = global::WeatherApp.Properties.Resources.Rain;
            this.pbRain.Location = new System.Drawing.Point(25, 38);
            this.pbRain.Name = "pbRain";
            this.pbRain.Size = new System.Drawing.Size(150, 150);
            this.pbRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRain.TabIndex = 4;
            this.pbRain.TabStop = false;
            // 
            // pbLightRain
            // 
            this.pbLightRain.Image = global::WeatherApp.Properties.Resources.Lightshowers;
            this.pbLightRain.Location = new System.Drawing.Point(25, 38);
            this.pbLightRain.Name = "pbLightRain";
            this.pbLightRain.Size = new System.Drawing.Size(150, 150);
            this.pbLightRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLightRain.TabIndex = 3;
            this.pbLightRain.TabStop = false;
            // 
            // pbOvercast
            // 
            this.pbOvercast.Image = global::WeatherApp.Properties.Resources.Overcast;
            this.pbOvercast.Location = new System.Drawing.Point(25, 38);
            this.pbOvercast.Name = "pbOvercast";
            this.pbOvercast.Size = new System.Drawing.Size(150, 150);
            this.pbOvercast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOvercast.TabIndex = 2;
            this.pbOvercast.TabStop = false;
            // 
            // pbCloudy
            // 
            this.pbCloudy.Image = global::WeatherApp.Properties.Resources.Cloudy;
            this.pbCloudy.Location = new System.Drawing.Point(25, 38);
            this.pbCloudy.Name = "pbCloudy";
            this.pbCloudy.Size = new System.Drawing.Size(150, 150);
            this.pbCloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloudy.TabIndex = 1;
            this.pbCloudy.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(200, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.pbDefault);
            this.Controls.Add(this.lblFeels);
            this.Controls.Add(this.pbThander);
            this.Controls.Add(this.pbSunny);
            this.Controls.Add(this.pbSun);
            this.Controls.Add(this.pbSnow);
            this.Controls.Add(this.pbFog);
            this.Controls.Add(this.pbRain);
            this.Controls.Add(this.pbLightRain);
            this.Controls.Add(this.pbOvercast);
            this.Controls.Add(this.pbCloudy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLightRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOvercast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloudy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCloudy;
        private System.Windows.Forms.PictureBox pbOvercast;
        private System.Windows.Forms.PictureBox pbLightRain;
        private System.Windows.Forms.PictureBox pbRain;
        private System.Windows.Forms.PictureBox pbFog;
        private System.Windows.Forms.PictureBox pbSnow;
        private System.Windows.Forms.PictureBox pbSun;
        private System.Windows.Forms.PictureBox pbSunny;
        private System.Windows.Forms.PictureBox pbThander;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblFeels;
        private System.Windows.Forms.PictureBox pbDefault;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label label2;
    }
}

