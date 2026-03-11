namespace ImageLoader
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
            this.btCarregarImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btSalvarImagem = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.carregar2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btSomarImagem = new System.Windows.Forms.Button();
            this.btSubtImagem = new System.Windows.Forms.Button();
            this.BrilhoUp = new System.Windows.Forms.NumericUpDown();
            this.Abrilho = new System.Windows.Forms.Button();
            this.BrilhoDown = new System.Windows.Forms.NumericUpDown();
            this.Dbrilho = new System.Windows.Forms.Button();
            this.MultiplicarImagem = new System.Windows.Forms.Button();
            this.ValorMultip = new System.Windows.Forms.NumericUpDown();
            this.ValorDiv = new System.Windows.Forms.NumericUpDown();
            this.DividirImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrilhoUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrilhoDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorMultip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorDiv)).BeginInit();
            this.SuspendLayout();
            // 
            // btCarregarImagem
            // 
            this.btCarregarImagem.Location = new System.Drawing.Point(37, 184);
            this.btCarregarImagem.Name = "btCarregarImagem";
            this.btCarregarImagem.Size = new System.Drawing.Size(163, 37);
            this.btCarregarImagem.TabIndex = 0;
            this.btCarregarImagem.Text = "Carregar Imagem";
            this.btCarregarImagem.UseVisualStyleBackColor = true;
            this.btCarregarImagem.Click += new System.EventHandler(this.btCarregarImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(931, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btSalvarImagem
            // 
            this.btSalvarImagem.Location = new System.Drawing.Point(947, 184);
            this.btSalvarImagem.Name = "btSalvarImagem";
            this.btSalvarImagem.Size = new System.Drawing.Size(163, 37);
            this.btSalvarImagem.TabIndex = 3;
            this.btSalvarImagem.Text = "Salvar Imagem";
            this.btSalvarImagem.UseVisualStyleBackColor = true;
            this.btSalvarImagem.Click += new System.EventHandler(this.btSalvarImagem_Click);
            // 
            // carregar2
            // 
            this.carregar2.Location = new System.Drawing.Point(300, 184);
            this.carregar2.Name = "carregar2";
            this.carregar2.Size = new System.Drawing.Size(163, 37);
            this.carregar2.TabIndex = 4;
            this.carregar2.Text = "Carregar Imagem";
            this.carregar2.UseVisualStyleBackColor = true;
            this.carregar2.Click += new System.EventHandler(this.carregar2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(280, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 161);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btSomarImagem
            // 
            this.btSomarImagem.Location = new System.Drawing.Point(168, 261);
            this.btSomarImagem.Name = "btSomarImagem";
            this.btSomarImagem.Size = new System.Drawing.Size(163, 37);
            this.btSomarImagem.TabIndex = 6;
            this.btSomarImagem.Text = "Somar Imagem";
            this.btSomarImagem.UseVisualStyleBackColor = true;
            this.btSomarImagem.Click += new System.EventHandler(this.btSomarImagem_Click);
            // 
            // btSubtImagem
            // 
            this.btSubtImagem.Location = new System.Drawing.Point(168, 315);
            this.btSubtImagem.Name = "btSubtImagem";
            this.btSubtImagem.Size = new System.Drawing.Size(163, 37);
            this.btSubtImagem.TabIndex = 7;
            this.btSubtImagem.Text = "Subtrair Imagem";
            this.btSubtImagem.UseVisualStyleBackColor = true;
            this.btSubtImagem.Click += new System.EventHandler(this.btSubtImagem_Click);
            // 
            // BrilhoUp
            // 
            this.BrilhoUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrilhoUp.Location = new System.Drawing.Point(499, 12);
            this.BrilhoUp.Name = "BrilhoUp";
            this.BrilhoUp.Size = new System.Drawing.Size(94, 20);
            this.BrilhoUp.TabIndex = 8;
            this.BrilhoUp.ValueChanged += new System.EventHandler(this.BrilhoUp_ValueChanged);
            // 
            // Abrilho
            // 
            this.Abrilho.Location = new System.Drawing.Point(617, 2);
            this.Abrilho.Name = "Abrilho";
            this.Abrilho.Size = new System.Drawing.Size(163, 37);
            this.Abrilho.TabIndex = 9;
            this.Abrilho.Text = "Aumentar brilho";
            this.Abrilho.UseVisualStyleBackColor = true;
            this.Abrilho.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrilhoDown
            // 
            this.BrilhoDown.Location = new System.Drawing.Point(499, 55);
            this.BrilhoDown.Name = "BrilhoDown";
            this.BrilhoDown.Size = new System.Drawing.Size(94, 20);
            this.BrilhoDown.TabIndex = 10;
            this.BrilhoDown.ValueChanged += new System.EventHandler(this.BrilhoDown_ValueChanged);
            // 
            // Dbrilho
            // 
            this.Dbrilho.Location = new System.Drawing.Point(617, 45);
            this.Dbrilho.Name = "Dbrilho";
            this.Dbrilho.Size = new System.Drawing.Size(163, 37);
            this.Dbrilho.TabIndex = 11;
            this.Dbrilho.Text = "Diminuir brilho";
            this.Dbrilho.UseVisualStyleBackColor = true;
            this.Dbrilho.Click += new System.EventHandler(this.Dbrilho_Click);
            // 
            // MultiplicarImagem
            // 
            this.MultiplicarImagem.Location = new System.Drawing.Point(617, 88);
            this.MultiplicarImagem.Name = "MultiplicarImagem";
            this.MultiplicarImagem.Size = new System.Drawing.Size(163, 37);
            this.MultiplicarImagem.TabIndex = 12;
            this.MultiplicarImagem.Text = "Mutiplicar";
            this.MultiplicarImagem.UseVisualStyleBackColor = true;
            this.MultiplicarImagem.Click += new System.EventHandler(this.MultiplicarImagem_Click);
            // 
            // ValorMultip
            // 
            this.ValorMultip.Location = new System.Drawing.Point(499, 98);
            this.ValorMultip.Name = "ValorMultip";
            this.ValorMultip.Size = new System.Drawing.Size(94, 20);
            this.ValorMultip.TabIndex = 13;
            this.ValorMultip.ValueChanged += new System.EventHandler(this.ValorMultip_ValueChanged);
            // 
            // ValorDiv
            // 
            this.ValorDiv.Location = new System.Drawing.Point(499, 141);
            this.ValorDiv.Name = "ValorDiv";
            this.ValorDiv.Size = new System.Drawing.Size(94, 20);
            this.ValorDiv.TabIndex = 14;
            this.ValorDiv.ValueChanged += new System.EventHandler(this.ValorDiv_ValueChanged);
            // 
            // DividirImagem
            // 
            this.DividirImagem.Location = new System.Drawing.Point(617, 131);
            this.DividirImagem.Name = "DividirImagem";
            this.DividirImagem.Size = new System.Drawing.Size(163, 37);
            this.DividirImagem.TabIndex = 15;
            this.DividirImagem.Text = "Dividir";
            this.DividirImagem.UseVisualStyleBackColor = true;
            this.DividirImagem.Click += new System.EventHandler(this.DividirImagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 562);
            this.Controls.Add(this.DividirImagem);
            this.Controls.Add(this.ValorDiv);
            this.Controls.Add(this.ValorMultip);
            this.Controls.Add(this.MultiplicarImagem);
            this.Controls.Add(this.Dbrilho);
            this.Controls.Add(this.BrilhoDown);
            this.Controls.Add(this.Abrilho);
            this.Controls.Add(this.BrilhoUp);
            this.Controls.Add(this.btSubtImagem);
            this.Controls.Add(this.btSomarImagem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.carregar2);
            this.Controls.Add(this.btSalvarImagem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCarregarImagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrilhoUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrilhoDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorMultip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorDiv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCarregarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btSalvarImagem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button carregar2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btSomarImagem;
        private System.Windows.Forms.Button btSubtImagem;
        private System.Windows.Forms.NumericUpDown BrilhoUp;
        private System.Windows.Forms.Button Abrilho;
        private System.Windows.Forms.NumericUpDown BrilhoDown;
        private System.Windows.Forms.Button Dbrilho;
        private System.Windows.Forms.Button MultiplicarImagem;
        private System.Windows.Forms.NumericUpDown ValorMultip;
        private System.Windows.Forms.NumericUpDown ValorDiv;
        private System.Windows.Forms.Button DividirImagem;
    }
}

