namespace CoresConverter
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Vprc = new System.Windows.Forms.Label();
            this.Sprc = new System.Windows.Forms.Label();
            this.Hprc = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.colorB = new System.Windows.Forms.Label();
            this.colorG = new System.Windows.Forms.Label();
            this.colorR = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Vprc);
            this.tabPage1.Controls.Add(this.Sprc);
            this.tabPage1.Controls.Add(this.Hprc);
            this.tabPage1.Controls.Add(this.V);
            this.tabPage1.Controls.Add(this.S);
            this.tabPage1.Controls.Add(this.H);
            this.tabPage1.Controls.Add(this.colorB);
            this.tabPage1.Controls.Add(this.colorG);
            this.tabPage1.Controls.Add(this.colorR);
            this.tabPage1.Controls.Add(this.numericUpDown3);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.trackBar3);
            this.tabPage1.Controls.Add(this.trackBar2);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "r";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Vprc
            // 
            this.Vprc.AutoSize = true;
            this.Vprc.Location = new System.Drawing.Point(68, 337);
            this.Vprc.Name = "Vprc";
            this.Vprc.Size = new System.Drawing.Size(42, 13);
            this.Vprc.TabIndex = 18;
            this.Vprc.Text = "00.00%";
            // 
            // Sprc
            // 
            this.Sprc.AutoSize = true;
            this.Sprc.Location = new System.Drawing.Point(67, 287);
            this.Sprc.Name = "Sprc";
            this.Sprc.Size = new System.Drawing.Size(42, 13);
            this.Sprc.TabIndex = 17;
            this.Sprc.Text = "00.00%";
            // 
            // Hprc
            // 
            this.Hprc.AutoSize = true;
            this.Hprc.Location = new System.Drawing.Point(67, 239);
           
            this.Hprc.Size = new System.Drawing.Size(42, 13);
            this.Hprc.TabIndex = 16;
            this.Hprc.Text = "00.00%";
            
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(25, 337);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(14, 13);
            this.V.TabIndex = 15;
            this.V.Text = "V";
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(24, 287);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(14, 13);
            this.S.TabIndex = 14;
            this.S.Text = "S";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(24, 239);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(15, 13);
            this.H.TabIndex = 13;
            this.H.Text = "H";
            // 
            // colorB
            // 
            this.colorB.AutoSize = true;
            this.colorB.Location = new System.Drawing.Point(24, 168);
            this.colorB.Name = "colorB";
            this.colorB.Size = new System.Drawing.Size(14, 13);
            this.colorB.TabIndex = 9;
            this.colorB.Text = "B";
            // 
            // colorG
            // 
            this.colorG.AutoSize = true;
            this.colorG.Location = new System.Drawing.Point(24, 108);
            this.colorG.Name = "colorG";
            this.colorG.Size = new System.Drawing.Size(15, 13);
            this.colorG.TabIndex = 8;
            this.colorG.Text = "G";
            // 
            // colorR
            // 
            this.colorR.AutoSize = true;
            this.colorR.Location = new System.Drawing.Point(24, 47);
            this.colorR.Name = "colorR";
            this.colorR.Size = new System.Drawing.Size(15, 13);
            this.colorR.TabIndex = 7;
            this.colorR.Text = "R";
            this.colorR.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(70, 166);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(70, 106);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(500, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 160);
            this.panel1.TabIndex = 3;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(160, 152);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(177, 45);
            this.trackBar3.TabIndex = 2;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(160, 92);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(177, 45);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(160, 32);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(177, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(735, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label colorR;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label colorG;
        private System.Windows.Forms.Label colorB;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label Vprc;
        private System.Windows.Forms.Label Sprc;
        private System.Windows.Forms.Label Hprc;
    }
}

