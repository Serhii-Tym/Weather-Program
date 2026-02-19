namespace Weather_Program
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblWeatherDescription = new System.Windows.Forms.Label();
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(63, 45);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(173, 20);
            this.txtCity.TabIndex = 0;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWeather.Location = new System.Drawing.Point(63, 89);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(173, 84);
            this.btnGetWeather.TabIndex = 1;
            this.btnGetWeather.Text = "Know Weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(48, 200);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(213, 26);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "Display Temperature";
            this.lblTemperature.Click += new System.EventHandler(this.lblTemperature_Click);
            // 
            // lblWeatherDescription
            // 
            this.lblWeatherDescription.AutoSize = true;
            this.lblWeatherDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherDescription.Location = new System.Drawing.Point(58, 239);
            this.lblWeatherDescription.Name = "lblWeatherDescription";
            this.lblWeatherDescription.Size = new System.Drawing.Size(192, 26);
            this.lblWeatherDescription.TabIndex = 3;
            this.lblWeatherDescription.Text = "Weather Condition";
            this.lblWeatherDescription.Click += new System.EventHandler(this.lblWeatherDescription_Click);
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(12, 268);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(300, 170);
            this.picWeatherIcon.TabIndex = 4;
            this.picWeatherIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.picWeatherIcon);
            this.Controls.Add(this.lblWeatherDescription);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.txtCity);
            this.Name = "Form1";
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblWeatherDescription;
        private System.Windows.Forms.PictureBox picWeatherIcon;
    }
}
