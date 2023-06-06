namespace API__weather
{
    partial class cuaca
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
            this.label1 = new System.Windows.Forms.Label();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tblCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labWind = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "kota";
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.Location = new System.Drawing.Point(87, 162);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(60, 20);
            this.labCondition.TabIndex = 1;
            this.labCondition.Text = "Kondisi";
            // 
            // labDetail
            // 
            this.labDetail.AutoSize = true;
            this.labDetail.Location = new System.Drawing.Point(87, 214);
            this.labDetail.Name = "labDetail";
            this.labDetail.Size = new System.Drawing.Size(50, 20);
            this.labDetail.TabIndex = 2;
            this.labDetail.Text = "Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sunrise :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sunset :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wind Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pressure: ";
            // 
            // tblCity
            // 
            this.tblCity.Location = new System.Drawing.Point(189, 37);
            this.tblCity.Name = "tblCity";
            this.tblCity.Size = new System.Drawing.Size(305, 26);
            this.tblCity.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(535, 246);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(210, 166);
            this.picIcon.TabIndex = 9;
            this.picIcon.TabStop = false;
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.Location = new System.Drawing.Point(173, 268);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(35, 20);
            this.labSunrise.TabIndex = 10;
            this.labSunrise.Text = "N/A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.Location = new System.Drawing.Point(173, 328);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(35, 20);
            this.labSunset.TabIndex = 11;
            this.labSunset.Text = "N/A";
            // 
            // labWind
            // 
            this.labWind.AutoSize = true;
            this.labWind.Location = new System.Drawing.Point(446, 162);
            this.labWind.Name = "labWind";
            this.labWind.Size = new System.Drawing.Size(35, 20);
            this.labWind.TabIndex = 12;
            this.labWind.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.Location = new System.Drawing.Point(446, 214);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(35, 20);
            this.labPressure.TabIndex = 13;
            this.labPressure.Text = "N/A";
            // 
            // cuaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWind);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetail);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.label1);
            this.Name = "cuaca";
            this.Text = "cuaca";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tblCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labWind;
        private System.Windows.Forms.Label labPressure;
    }
}

