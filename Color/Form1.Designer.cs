namespace Color
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.panColor = new System.Windows.Forms.Panel();
         this.lblRed = new System.Windows.Forms.Label();
         this.lblGreen = new System.Windows.Forms.Label();
         this.lblBlue = new System.Windows.Forms.Label();
         this.lblHex = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.panNamedColor = new System.Windows.Forms.Panel();
         this.lblNamedColor = new System.Windows.Forms.Label();
         this.name = new System.Windows.Forms.Label();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.panMixer = new System.Windows.Forms.Panel();
         this.lblBlueHexSlider = new System.Windows.Forms.Label();
         this.lblBlueSlider = new System.Windows.Forms.Label();
         this.sliderBlue = new System.Windows.Forms.TrackBar();
         this.lblGreenHexSlider = new System.Windows.Forms.Label();
         this.lblGreenSlider = new System.Windows.Forms.Label();
         this.sliderGreen = new System.Windows.Forms.TrackBar();
         this.lblRedHexSlider = new System.Windows.Forms.Label();
         this.lblRedSlider = new System.Windows.Forms.Label();
         this.sliderRed = new System.Windows.Forms.TrackBar();
         this.cbTop = new System.Windows.Forms.CheckBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.panWhatIs = new System.Windows.Forms.Panel();
         this.btnWhatIs = new System.Windows.Forms.Button();
         this.txtWhatIs = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).BeginInit();
         this.groupBox3.SuspendLayout();
         this.SuspendLayout();
         // 
         // panColor
         // 
         this.panColor.Location = new System.Drawing.Point(125, 16);
         this.panColor.Name = "panColor";
         this.panColor.Size = new System.Drawing.Size(69, 65);
         this.panColor.TabIndex = 1;
         // 
         // lblRed
         // 
         this.lblRed.AutoSize = true;
         this.lblRed.ForeColor = System.Drawing.Color.Red;
         this.lblRed.Location = new System.Drawing.Point(6, 16);
         this.lblRed.Name = "lblRed";
         this.lblRed.Size = new System.Drawing.Size(25, 13);
         this.lblRed.TabIndex = 2;
         this.lblRed.Text = "000";
         // 
         // lblGreen
         // 
         this.lblGreen.AutoSize = true;
         this.lblGreen.ForeColor = System.Drawing.Color.Green;
         this.lblGreen.Location = new System.Drawing.Point(50, 16);
         this.lblGreen.Name = "lblGreen";
         this.lblGreen.Size = new System.Drawing.Size(25, 13);
         this.lblGreen.TabIndex = 3;
         this.lblGreen.Text = "000";
         // 
         // lblBlue
         // 
         this.lblBlue.AutoSize = true;
         this.lblBlue.ForeColor = System.Drawing.Color.Blue;
         this.lblBlue.Location = new System.Drawing.Point(94, 16);
         this.lblBlue.Name = "lblBlue";
         this.lblBlue.Size = new System.Drawing.Size(25, 13);
         this.lblBlue.TabIndex = 4;
         this.lblBlue.Text = "000";
         // 
         // lblHex
         // 
         this.lblHex.AutoSize = true;
         this.lblHex.Location = new System.Drawing.Point(6, 42);
         this.lblHex.Name = "lblHex";
         this.lblHex.Size = new System.Drawing.Size(50, 13);
         this.lblHex.TabIndex = 5;
         this.lblHex.Text = "#000000";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.panNamedColor);
         this.groupBox1.Controls.Add(this.lblNamedColor);
         this.groupBox1.Controls.Add(this.name);
         this.groupBox1.Controls.Add(this.lblRed);
         this.groupBox1.Controls.Add(this.lblHex);
         this.groupBox1.Controls.Add(this.lblBlue);
         this.groupBox1.Controls.Add(this.panColor);
         this.groupBox1.Controls.Add(this.lblGreen);
         this.groupBox1.Location = new System.Drawing.Point(12, 26);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(205, 125);
         this.groupBox1.TabIndex = 6;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Current Color";
         this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
         // 
         // panNamedColor
         // 
         this.panNamedColor.Location = new System.Drawing.Point(125, 87);
         this.panNamedColor.Name = "panNamedColor";
         this.panNamedColor.Size = new System.Drawing.Size(69, 29);
         this.panNamedColor.TabIndex = 2;
         // 
         // lblNamedColor
         // 
         this.lblNamedColor.AutoSize = true;
         this.lblNamedColor.Location = new System.Drawing.Point(6, 87);
         this.lblNamedColor.Name = "lblNamedColor";
         this.lblNamedColor.Size = new System.Drawing.Size(55, 26);
         this.lblNamedColor.TabIndex = 7;
         this.lblNamedColor.Text = "Blue\r\n(0, 0, 255)";
         // 
         // name
         // 
         this.name.AutoSize = true;
         this.name.Location = new System.Drawing.Point(6, 96);
         this.name.Name = "name";
         this.name.Size = new System.Drawing.Size(0, 13);
         this.name.TabIndex = 6;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.panMixer);
         this.groupBox2.Controls.Add(this.lblBlueHexSlider);
         this.groupBox2.Controls.Add(this.lblBlueSlider);
         this.groupBox2.Controls.Add(this.sliderBlue);
         this.groupBox2.Controls.Add(this.lblGreenHexSlider);
         this.groupBox2.Controls.Add(this.lblGreenSlider);
         this.groupBox2.Controls.Add(this.sliderGreen);
         this.groupBox2.Controls.Add(this.lblRedHexSlider);
         this.groupBox2.Controls.Add(this.lblRedSlider);
         this.groupBox2.Controls.Add(this.sliderRed);
         this.groupBox2.Location = new System.Drawing.Point(12, 157);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(200, 274);
         this.groupBox2.TabIndex = 7;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Mixer";
         // 
         // panMixer
         // 
         this.panMixer.BackColor = System.Drawing.Color.Black;
         this.panMixer.Location = new System.Drawing.Point(6, 212);
         this.panMixer.Name = "panMixer";
         this.panMixer.Size = new System.Drawing.Size(188, 56);
         this.panMixer.TabIndex = 14;
         // 
         // lblBlueHexSlider
         // 
         this.lblBlueHexSlider.AutoSize = true;
         this.lblBlueHexSlider.ForeColor = System.Drawing.Color.Blue;
         this.lblBlueHexSlider.Location = new System.Drawing.Point(50, 195);
         this.lblBlueHexSlider.Name = "lblBlueHexSlider";
         this.lblBlueHexSlider.Size = new System.Drawing.Size(19, 13);
         this.lblBlueHexSlider.TabIndex = 13;
         this.lblBlueHexSlider.Text = "00";
         // 
         // lblBlueSlider
         // 
         this.lblBlueSlider.AutoSize = true;
         this.lblBlueSlider.ForeColor = System.Drawing.Color.Blue;
         this.lblBlueSlider.Location = new System.Drawing.Point(6, 195);
         this.lblBlueSlider.Name = "lblBlueSlider";
         this.lblBlueSlider.Size = new System.Drawing.Size(13, 13);
         this.lblBlueSlider.TabIndex = 12;
         this.lblBlueSlider.Text = "0";
         // 
         // sliderBlue
         // 
         this.sliderBlue.BackColor = System.Drawing.Color.Blue;
         this.sliderBlue.Location = new System.Drawing.Point(6, 147);
         this.sliderBlue.Maximum = 255;
         this.sliderBlue.Name = "sliderBlue";
         this.sliderBlue.Size = new System.Drawing.Size(188, 45);
         this.sliderBlue.TabIndex = 11;
         this.sliderBlue.TickFrequency = 15;
         this.sliderBlue.Scroll += new System.EventHandler(this.mixerChange);
         // 
         // lblGreenHexSlider
         // 
         this.lblGreenHexSlider.AutoSize = true;
         this.lblGreenHexSlider.ForeColor = System.Drawing.Color.Green;
         this.lblGreenHexSlider.Location = new System.Drawing.Point(50, 131);
         this.lblGreenHexSlider.Name = "lblGreenHexSlider";
         this.lblGreenHexSlider.Size = new System.Drawing.Size(19, 13);
         this.lblGreenHexSlider.TabIndex = 10;
         this.lblGreenHexSlider.Text = "00";
         // 
         // lblGreenSlider
         // 
         this.lblGreenSlider.AutoSize = true;
         this.lblGreenSlider.ForeColor = System.Drawing.Color.Green;
         this.lblGreenSlider.Location = new System.Drawing.Point(6, 131);
         this.lblGreenSlider.Name = "lblGreenSlider";
         this.lblGreenSlider.Size = new System.Drawing.Size(13, 13);
         this.lblGreenSlider.TabIndex = 9;
         this.lblGreenSlider.Text = "0";
         // 
         // sliderGreen
         // 
         this.sliderGreen.BackColor = System.Drawing.Color.Green;
         this.sliderGreen.Location = new System.Drawing.Point(6, 83);
         this.sliderGreen.Maximum = 255;
         this.sliderGreen.Name = "sliderGreen";
         this.sliderGreen.Size = new System.Drawing.Size(188, 45);
         this.sliderGreen.TabIndex = 8;
         this.sliderGreen.TickFrequency = 15;
         this.sliderGreen.Scroll += new System.EventHandler(this.mixerChange);
         // 
         // lblRedHexSlider
         // 
         this.lblRedHexSlider.AutoSize = true;
         this.lblRedHexSlider.ForeColor = System.Drawing.Color.Red;
         this.lblRedHexSlider.Location = new System.Drawing.Point(50, 67);
         this.lblRedHexSlider.Name = "lblRedHexSlider";
         this.lblRedHexSlider.Size = new System.Drawing.Size(19, 13);
         this.lblRedHexSlider.TabIndex = 7;
         this.lblRedHexSlider.Text = "00";
         // 
         // lblRedSlider
         // 
         this.lblRedSlider.AutoSize = true;
         this.lblRedSlider.ForeColor = System.Drawing.Color.Red;
         this.lblRedSlider.Location = new System.Drawing.Point(6, 67);
         this.lblRedSlider.Name = "lblRedSlider";
         this.lblRedSlider.Size = new System.Drawing.Size(13, 13);
         this.lblRedSlider.TabIndex = 6;
         this.lblRedSlider.Text = "0";
         // 
         // sliderRed
         // 
         this.sliderRed.BackColor = System.Drawing.Color.Red;
         this.sliderRed.Location = new System.Drawing.Point(6, 19);
         this.sliderRed.Maximum = 255;
         this.sliderRed.Name = "sliderRed";
         this.sliderRed.Size = new System.Drawing.Size(188, 45);
         this.sliderRed.TabIndex = 0;
         this.sliderRed.TickFrequency = 15;
         this.sliderRed.Scroll += new System.EventHandler(this.mixerChange);
         // 
         // cbTop
         // 
         this.cbTop.AutoSize = true;
         this.cbTop.Location = new System.Drawing.Point(131, 7);
         this.cbTop.Name = "cbTop";
         this.cbTop.Size = new System.Drawing.Size(84, 17);
         this.cbTop.TabIndex = 8;
         this.cbTop.Text = "Stay on Top";
         this.cbTop.UseVisualStyleBackColor = true;
         this.cbTop.CheckedChanged += new System.EventHandler(this.cbTop_CheckedChanged);
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.panWhatIs);
         this.groupBox3.Controls.Add(this.btnWhatIs);
         this.groupBox3.Controls.Add(this.txtWhatIs);
         this.groupBox3.Controls.Add(this.label1);
         this.groupBox3.Location = new System.Drawing.Point(12, 438);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(194, 68);
         this.groupBox3.TabIndex = 9;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "What is";
         // 
         // panWhatIs
         // 
         this.panWhatIs.Location = new System.Drawing.Point(129, 17);
         this.panWhatIs.Name = "panWhatIs";
         this.panWhatIs.Size = new System.Drawing.Size(53, 44);
         this.panWhatIs.TabIndex = 3;
         // 
         // btnWhatIs
         // 
         this.btnWhatIs.Location = new System.Drawing.Point(9, 39);
         this.btnWhatIs.Name = "btnWhatIs";
         this.btnWhatIs.Size = new System.Drawing.Size(113, 23);
         this.btnWhatIs.TabIndex = 2;
         this.btnWhatIs.Text = "Show";
         this.btnWhatIs.UseVisualStyleBackColor = true;
         this.btnWhatIs.Click += new System.EventHandler(this.btnWhatIs_Click);
         // 
         // txtWhatIs
         // 
         this.txtWhatIs.Location = new System.Drawing.Point(21, 17);
         this.txtWhatIs.Name = "txtWhatIs";
         this.txtWhatIs.Size = new System.Drawing.Size(100, 20);
         this.txtWhatIs.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 20);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(14, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "#";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(231, 519);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.cbTop);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.Text = "Color";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).EndInit();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panColor;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panMixer;
        private System.Windows.Forms.Label lblBlueHexSlider;
        private System.Windows.Forms.Label lblBlueSlider;
        private System.Windows.Forms.TrackBar sliderBlue;
        private System.Windows.Forms.Label lblGreenHexSlider;
        private System.Windows.Forms.Label lblGreenSlider;
        private System.Windows.Forms.TrackBar sliderGreen;
        private System.Windows.Forms.Label lblRedHexSlider;
        private System.Windows.Forms.Label lblRedSlider;
        private System.Windows.Forms.TrackBar sliderRed;
        private System.Windows.Forms.CheckBox cbTop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panWhatIs;
        private System.Windows.Forms.Button btnWhatIs;
        private System.Windows.Forms.TextBox txtWhatIs;
        private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panNamedColor;
      private System.Windows.Forms.Label lblNamedColor;
      private System.Windows.Forms.Label name;
   }
}

