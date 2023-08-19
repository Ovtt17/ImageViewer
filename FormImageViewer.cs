using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class FormImageViewer : Form
    {
        private Bitmap MyImage;
        private DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Ovett\Documents\UNAN Leon - PC\semestre-6\Programacion Visual\Parcial 1\Practica-3\ImageViewer\img\pictures\");
        private List<FileInfo> files = new List<FileInfo>();
        

        public FormImageViewer()
        {
            InitializeComponent();
        }

        private void FormImageViewer_Load(object sender, EventArgs e)
        {
            LoadImages();
        }
        private void LoadImages()
        {
            foreach (var file in directory.GetFiles())
            {
                files.Add(file);
                cmbActualImg.Items.Add(file.Name);
            }
            cmbActualImg.SelectedIndex = 0;
            CreatePath();
        }

        private void ShowMyImage(string fileToDisplay)
        {
            if (MyImage != null)
            {
                MyImage.Dispose();
            }
            
            if (rbCentered.Checked)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            } else if (rbZoom.Checked)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            MyImage = new Bitmap(fileToDisplay);
            pictureBox.Image = (Image)MyImage;
        }
        private void CreatePath()
        {
            string fileName = cmbActualImg.SelectedItem.ToString();
            string fileToDisplay = directory + fileName;
            tssLabel.Text = fileToDisplay;
            ShowMyImage(fileToDisplay);
        }

        private void cmbActualImg_SelectedValueChanged(object sender, EventArgs e)
        {
            CreatePath();
        }

        private void rbCentered_CheckedChanged(object sender, EventArgs e)
        {
            CreatePath();
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
    }
}
