using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImageViewer
{
    public partial class FormImageViewer : Form
    {
        private Bitmap MyImage;
        private DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Ovett\Documents\UNAN Leon - PC\semestre-6\Programacion Visual\Parcial 1\Practica-3\ImageViewer\img\pictures\");        

        public FormImageViewer()
        {
            InitializeComponent();
        }

        private void FormImageViewer_Load(object sender, EventArgs e)
        {
            LoadImages();
        }
        private void cmbActualImg_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowImage();
        }
        private void btnOneStepForward_Click(object sender, EventArgs e)
        {
            if (cmbActualImg.SelectedIndex < cmbActualImg.Items.Count - 1)
            {
                cmbActualImg.SelectedIndex++;
            }
            else
            {
                cmbActualImg.SelectedIndex = 0;
            }
            ShowImage();
        }

        private void btnOneStepBack_Click(object sender, EventArgs e)
        {
            if (cmbActualImg.SelectedIndex > 0)
            {
                cmbActualImg.SelectedIndex--;
            }
            else
            {
                cmbActualImg.SelectedIndex = cmbActualImg.Items.Count - 1;
            }
        }
        private void btnTwoStepsForward_Click(object sender, EventArgs e)
        {
            int newIndex = cmbActualImg.SelectedIndex + 2;
            if (newIndex >= cmbActualImg.Items.Count)
            {
                newIndex -= cmbActualImg.Items.Count;
            }
            cmbActualImg.SelectedIndex = newIndex;
        }

        private void btnTwoStepsBack_Click(object sender, EventArgs e)
        {
            int newIndex = cmbActualImg.SelectedIndex - 2;
            if (newIndex < 0)
            {
                newIndex += cmbActualImg.Items.Count;
            }
            cmbActualImg.SelectedIndex = newIndex;
        }
        private void rbGrayscale_Click(object sender, EventArgs e)
        {
            rbNormal.Checked = false;
            rbGrayscale.Checked = true;
            ImageModeValidations();
        }
        private void rbNormal_Click(object sender, EventArgs e)
        {
            rbGrayscale.Checked = false;
            rbNormal.Checked = true;
            ImageModeValidations();
        }
        private void rbCentered_Click(object sender, EventArgs e)
        {
            rbCentered.Checked = true;
            ImagePositionValidations();
        }
        private void rbStretch_Click(object sender, EventArgs e)
        {
            rbStretch.Checked = true;
            ImagePositionValidations();
        }

        private void rbZoom_Click(object sender, EventArgs e)
        {
            rbZoom.Checked = true;
            ImagePositionValidations();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = cmbActualImg.SelectedItem.ToString();
            saveFileDialog.Filter = "File images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Save Image";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                pictureBox.Image.Save(filePath);
                MessageBox.Show("Image saved in your computer!");
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Crea un nuevo objeto ContextMenuStrip
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

                // Agrega las opciones al menú
                contextMenuStrip.Items.Add("Rotate 90° to the right", null, (s, args) =>
                {
                    pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox.Refresh();
                });
                contextMenuStrip.Items.Add("Rotate 90° to the left", null, (s, args) => {
                    pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pictureBox.Refresh();
                });
                contextMenuStrip.Items.Add("Copy image", null, (s, args) => {
                    Clipboard.SetImage(pictureBox.Image);
                    MessageBox.Show("Image copied");
                });

                // Asigna el ContextMenuStrip al PictureBox
                pictureBox.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadImages()
        {
            foreach (var file in directory.GetFiles())
            {
                cmbActualImg.Items.Add(file.Name);
            }
            cmbActualImg.SelectedIndex = 0;
            ShowImage();
        }
        
        private void ShowImage()
        {
            ImageCreation();
            ImageModeValidations();
            ImagePositionValidations();
        }
        private void ImageCreation()
        {
            string fileName = cmbActualImg.SelectedItem.ToString();
            string fileToDisplay = directory + fileName;
            tssLabelPath.Text = fileToDisplay;

            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            MyImage = new Bitmap(fileToDisplay);
            pictureBox.Image = MyImage;
        }
        private void ImageModeValidations()
        {
            if (rbGrayscale.Checked)
            {
                tsbModeNormal.CheckState = CheckState.Unchecked;
                tsbModeGrayscale.CheckState = CheckState.Checked;
                pictureBox.Image = CreateGrayScaleBitmap(MyImage);
            }
            else
            {
                tsbModeGrayscale.CheckState= CheckState.Unchecked;
                tsbModeNormal.CheckState = CheckState.Checked;
                ImageCreation();
            }
        }
        private void ImagePositionValidations()
        {
            if (rbCentered.Checked)
            {
                tsbZoom.CheckState = CheckState.Unchecked;
                tsbStretch.CheckState = CheckState.Unchecked;
                tsbCentered.CheckState = CheckState.Checked;
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (rbZoom.Checked)
            {
                tsbCentered.CheckState= CheckState.Unchecked;
                tsbStretch.CheckState= CheckState.Unchecked;
                tsbZoom.CheckState= CheckState.Checked;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else 
            {
                tsbZoom.CheckState = CheckState.Unchecked;
                tsbCentered.CheckState = CheckState.Unchecked;
                tsbStretch.CheckState = CheckState.Checked;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private byte[] GetImageBytes(Bitmap image, ImageLockMode lockMode, out BitmapData bmpData)
        {
            bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                     lockMode, image.PixelFormat);

            byte[] imageBytes = new byte[bmpData.Stride * image.Height];
            Marshal.Copy(bmpData.Scan0, imageBytes, 0, imageBytes.Length);

            return imageBytes;
        }
        private Bitmap CreateGrayScaleBitmap(Bitmap source)
        {
            Bitmap target = new Bitmap(source.Width, source.Height, source.PixelFormat);
            BitmapData targetData, sourceData;

            byte[] sourceBytes = GetImageBytes(source, ImageLockMode.ReadOnly, out sourceData);
            byte[] targetBytes = GetImageBytes(target, ImageLockMode.ReadWrite, out targetData);

            //recorrer los pixeles
            for (int i = 0; i < sourceBytes.Length - 2; i += 3)
            {
                //ignorar el padding, es decir solo procesar los bytes necesarios
                if ((i + 3) % (source.Width * 3) > 0)
                {
                    //Hallar tono gris
                    byte y = (byte)((sourceBytes[i + 2] * 0.3f)
                                 + (sourceBytes[i + 1] * 0.59f)
                                 + (sourceBytes[i] * 0.11f));

                    //Asignar tono gris a cada byte del pixel
                    targetBytes[i + 2] = targetBytes[i + 1] = targetBytes[i] = y;
                }
            }


            Marshal.Copy(targetBytes, 0, targetData.Scan0, targetBytes.Length);

            source.UnlockBits(sourceData);
            target.UnlockBits(targetData);

            return target;
        }

    }
}
