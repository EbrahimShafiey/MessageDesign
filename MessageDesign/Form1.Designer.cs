namespace MessageDesign
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButtonFP = new System.Windows.Forms.RadioButton();
            this.radioButtonHW = new System.Windows.Forms.RadioButton();
            this.radioButtonMS = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton16Point = new System.Windows.Forms.RadioButton();
            this.radioButton12Point = new System.Windows.Forms.RadioButton();
            this.radioButton8Point = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelMessageShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(14, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 142);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioButtonFP);
            this.tabPage3.Controls.Add(this.radioButtonHW);
            this.tabPage3.Controls.Add(this.radioButtonMS);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(380, 113);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Message";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButtonFP
            // 
            this.radioButtonFP.AutoSize = true;
            this.radioButtonFP.Location = new System.Drawing.Point(22, 75);
            this.radioButtonFP.Name = "radioButtonFP";
            this.radioButtonFP.Size = new System.Drawing.Size(107, 21);
            this.radioButtonFP.TabIndex = 2;
            this.radioButtonFP.Text = "First Project!";
            this.radioButtonFP.UseVisualStyleBackColor = true;
            this.radioButtonFP.CheckedChanged += new System.EventHandler(this.radioButtonFP_CheckedChanged);
            // 
            // radioButtonHW
            // 
            this.radioButtonHW.AutoSize = true;
            this.radioButtonHW.Location = new System.Drawing.Point(22, 48);
            this.radioButtonHW.Name = "radioButtonHW";
            this.radioButtonHW.Size = new System.Drawing.Size(105, 21);
            this.radioButtonHW.TabIndex = 1;
            this.radioButtonHW.Text = "Hello World!";
            this.radioButtonHW.UseVisualStyleBackColor = true;
            this.radioButtonHW.CheckedChanged += new System.EventHandler(this.radioButtonHW_CheckedChanged);
            // 
            // radioButtonMS
            // 
            this.radioButtonMS.AutoSize = true;
            this.radioButtonMS.Checked = true;
            this.radioButtonMS.Location = new System.Drawing.Point(22, 21);
            this.radioButtonMS.Name = "radioButtonMS";
            this.radioButtonMS.Size = new System.Drawing.Size(127, 21);
            this.radioButtonMS.TabIndex = 0;
            this.radioButtonMS.TabStop = true;
            this.radioButtonMS.Text = "Message Show!";
            this.radioButtonMS.UseVisualStyleBackColor = true;
            this.radioButtonMS.CheckedChanged += new System.EventHandler(this.radioButtonMS_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButtonGreen);
            this.tabPage1.Controls.Add(this.radioButtonRed);
            this.tabPage1.Controls.Add(this.radioButtonBlack);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 113);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Color";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(19, 71);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(69, 21);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(19, 44);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(55, 21);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(19, 17);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(63, 21);
            this.radioButtonBlack.TabIndex = 0;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            this.radioButtonBlack.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton16Point);
            this.tabPage2.Controls.Add(this.radioButton12Point);
            this.tabPage2.Controls.Add(this.radioButton8Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 113);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Size";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton16Point
            // 
            this.radioButton16Point.AutoSize = true;
            this.radioButton16Point.Location = new System.Drawing.Point(24, 72);
            this.radioButton16Point.Name = "radioButton16Point";
            this.radioButton16Point.Size = new System.Drawing.Size(88, 21);
            this.radioButton16Point.TabIndex = 5;
            this.radioButton16Point.TabStop = true;
            this.radioButton16Point.Text = "16 Points";
            this.radioButton16Point.UseVisualStyleBackColor = true;
            this.radioButton16Point.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton12Point
            // 
            this.radioButton12Point.AutoSize = true;
            this.radioButton12Point.Location = new System.Drawing.Point(24, 45);
            this.radioButton12Point.Name = "radioButton12Point";
            this.radioButton12Point.Size = new System.Drawing.Size(88, 21);
            this.radioButton12Point.TabIndex = 4;
            this.radioButton12Point.TabStop = true;
            this.radioButton12Point.Text = "12 Points";
            this.radioButton12Point.UseVisualStyleBackColor = true;
            this.radioButton12Point.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton8Point
            // 
            this.radioButton8Point.AutoSize = true;
            this.radioButton8Point.Location = new System.Drawing.Point(24, 18);
            this.radioButton8Point.Name = "radioButton8Point";
            this.radioButton8Point.Size = new System.Drawing.Size(80, 21);
            this.radioButton8Point.TabIndex = 3;
            this.radioButton8Point.TabStop = true;
            this.radioButton8Point.Text = "8 Points";
            this.radioButton8Point.UseVisualStyleBackColor = true;
            this.radioButton8Point.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(380, 113);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About us!";
            // 
            // labelMessageShow
            // 
            this.labelMessageShow.AutoSize = true;
            this.labelMessageShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelMessageShow.Location = new System.Drawing.Point(22, 171);
            this.labelMessageShow.Name = "labelMessageShow";
            this.labelMessageShow.Size = new System.Drawing.Size(0, 25);
            this.labelMessageShow.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(131, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 107);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thank you for using!\r\nDeveloper : Ebrahim Shafiey\r\nGmail:shafiey.ebrahim22@gmail." +
    "com\r\nGitHub : @ebrahimshafiey\r\nTelegram : @ebrahimshafiey\r\nPonisha : @ebrahimsha" +
    "fiey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 231);
            this.Controls.Add(this.labelMessageShow);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButton16Point;
        private System.Windows.Forms.RadioButton radioButton12Point;
        private System.Windows.Forms.RadioButton radioButton8Point;
        private System.Windows.Forms.Label labelMessageShow;
        private System.Windows.Forms.RadioButton radioButtonFP;
        private System.Windows.Forms.RadioButton radioButtonHW;
        private System.Windows.Forms.RadioButton radioButtonMS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

