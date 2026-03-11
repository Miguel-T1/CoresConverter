using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLoader
{
    public partial class Form1 : Form
    {

        Bitmap img1;
        Bitmap img2;
        Bitmap img3;
        Bitmap img4;
        int brilhoAtual = 0;
        float valorCalculo = 0;
        byte[,] somarsomarR;
        byte[,] somarsomarG;
        byte[,] somarsomarB;
        byte[,] vImg1Gray;

        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;




        public Form1()
        {

            InitializeComponent();
        }


        private void btCarregarImagem_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img1 = new Bitmap(filePath);

                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;
                    /* vImg1Gray = new byte[img1.Width, img1.Height];
                     vImg1R = new byte[img1.Width, img1.Height];
                     vImg1G = new byte[img1.Width, img1.Height];
                     vImg1B = new byte[img1.Width, img1.Height];
                     vImg1A = new byte[img1.Width, img1.Height];

                     // Percorre todos os pixels da imagem...
                     for (int i = 0; i < img1.Width; i++)
                     {
                         for (int j = 0; j < img1.Height; j++)
                         {
                             Color pixel = img1.GetPixel(i, j);

                             // Para imagens em escala de cinza, extrair o valor do pixel com...
                             //byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                             byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                             vImg1Gray[i, j] = pixelIntensity;

                             // Para imagens RGB, extrair o valor do pixel com...
                             byte R = pixel.R;
                             byte G = pixel.G;
                             byte B = pixel.B;
                             byte A = pixel.A;

                             vImg1R[i, j] = R;
                             vImg1G[i, j] = G;
                             vImg1B[i, j] = B;
                             vImg1A[i, j] = A;

                             Color cor = Color.FromArgb(
                                 255,
                                 vImg1Gray[i, j],
                                 vImg1Gray[i, j],
                                 vImg1Gray[i, j]);

                             img2.SetPixel(i, j, cor);
                         }
                     }

                    pictureBox2.Image = img2;
                */
                }

            }
        }

        private void btSalvarImagem_Click(object sender, EventArgs e)
        {
            if (img2 == null)
                return;

            // Configurações iniciais da saveFileDialog1
            var filePath = string.Empty;
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;


            ImageFormat format = img2.RawFormat;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".tif":
                        format = ImageFormat.Tiff;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }

                //pictureBox3.Image.Save(saveFileDialog1.FileName, format);
                img2.Save(saveFileDialog1.FileName, format);
            }
        }


        private void carregar2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                bool bLoadImgOK = false;

                try
                {
                    img3 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                if (bLoadImgOK == true)
                {
                    pictureBox3.Image = img3;
                }
            }
        }
        private void btSomarImagem_Click(object sender, EventArgs e)
        {
            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho!");
                return;
            }

            img4 = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);
                    Color pixel3 = img3.GetPixel(i, j);

                    int R = pixel.R + pixel3.R;
                    int G = pixel.G + pixel3.G;
                    int B = pixel.B + pixel3.B;
                    int A = pixel.A + pixel3.A;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (A > 255) A = 255;

                    Color cor = Color.FromArgb(A, R, G, B);

                    img4.SetPixel(i, j, cor);
                }
            }

            pictureBox2.Image = img4;
            img2 = img4;
        }

        private void btSubtImagem_Click(object sender, EventArgs e)
        {
            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho!");
                return;
            }
            img4 = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);
                    Color pixel3 = img3.GetPixel(i, j);

                    int R = pixel.R - pixel3.R;
                    int G = pixel.G - pixel3.G;
                    int B = pixel.B - pixel3.B;


                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;


                    Color cor = Color.FromArgb(R, G, B);

                    img4.SetPixel(i, j, cor);
                }
            }

            pictureBox2.Image = img4;
            img2 = img4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int R = pixel.R + brilhoAtual;
                    int G = pixel.G + brilhoAtual;
                    int B = pixel.B + brilhoAtual;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            pictureBox2.Image = resultado;
            img2 = resultado;
        }




        private void BrilhoUp_ValueChanged(object sender, EventArgs e)
        {
            brilhoAtual = (int)BrilhoUp.Value;
        }

        private void BrilhoDown_ValueChanged(object sender, EventArgs e)
        {
            brilhoAtual = (int)BrilhoDown.Value;
        }

        private void Dbrilho_Click(object sender, EventArgs e)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int R = pixel.R - brilhoAtual;
                    int G = pixel.G - brilhoAtual;
                    int B = pixel.B - brilhoAtual;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;


                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            pictureBox2.Image = resultado;
            img2 = resultado;
        }

       

        private void MultiplicarImagem_Click(object sender, EventArgs e)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int R = (int)(pixel.R * valorCalculo);
                    int G = (int)(pixel.G * valorCalculo);
                    int B = (int)(pixel.B * valorCalculo);

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;


                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            pictureBox2.Image = resultado;
            img2 = resultado;
        }

        private void ValorMultip_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                valorCalculo = (float)ValorMultip.Value;


                if (valorCalculo < 0.1 || valorCalculo > 1.5)
                {
                    throw new Exception("Valor fora do intervalo permitido (0.1 - 1.5)");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Insira um valor entre 0.1 e 1.5", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        
    }

        private void ValorDiv_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                valorCalculo = (float)ValorDiv.Value;


                if (valorCalculo < 0.1 || valorCalculo > 1.5)
                {
                    throw new Exception("Valor fora do intervalo permitido (0.1 - 1.5)");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Insira um valor entre 0.1 e 1.5", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DividirImagem_Click(object sender, EventArgs e)
        {

            if (valorCalculo == 0)
            {
                MessageBox.Show("O valor de divisão não pode ser 0.");
                return;
            }

            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int R = (int)(pixel.R / valorCalculo);
                    int G = (int)(pixel.G / valorCalculo);
                    int B = (int)(pixel.B / valorCalculo);

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            pictureBox2.Image = resultado;
            img2 = resultado;
        }
    }
    
}
    

        
    

