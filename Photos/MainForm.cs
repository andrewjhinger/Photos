using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void photosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet.PhotoCategories' table. You can move, or remove it, as needed.
            this.photoCategoriesTableAdapter.Fill(this.myDatabaseDataSet.PhotoCategories);
            // TODO: This line of code loads data into the 'myDatabaseDataSet.Photos' table. You can move, or remove it, as needed.
            this.photosTableAdapter.Fill(this.myDatabaseDataSet.Photos);

        }

        private void photographPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void photographPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (filePaths.Length > 0)
                {
                    // Attempt to load, may not be valid image
                    string path = filePaths[0];
                    try
                    {
                        using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(path)))
                        {
                            Image tempImage = Image.FromStream(memoryStream);
                            photographPictureBox.Image = new Bitmap(tempImage);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading file: " + ex.Message);
                    }
                }
            }
        }
    }
}
