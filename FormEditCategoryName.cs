using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OphdTechEdit
{
    public partial class FormEditCategoryName : Form
    {
        private ImageList mCategoryImages = new ImageList();

        public string CategoryName
        {
            get => TextCategoryName.Text;
            set => TextCategoryName.Text = value;
        }

        public ImageList CategoryImages
        {
            get => mCategoryImages;
            set
            {
                mCategoryImages = value;
                ImageListChanged();
            }
        }

        public int IconIndex
        {
            get => (int)ImageIndex.Value;
            set => ImageIndex.Value = value;
        }

        public void ForceNameChange()
        {
            ButtonCancel.Enabled = false;
        }

        public FormEditCategoryName()
        {
            InitializeComponent();
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            if(TextCategoryName.Text == "New Category")
            {
                _ = MessageBox.Show("Category name must be changed.", "Category Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void ImageIndex_ValueChanged(object sender, EventArgs e)
        {
            ImageIndex.Value %= mCategoryImages.Images.Count;
            PictureCategoryIcon.Image = mCategoryImages.Images[decimal.ToInt32(ImageIndex.Value)];
        }


        private void ImageListChanged()
        {
            ImageIndex.Maximum = mCategoryImages.Images.Count;
            PictureCategoryIcon.Image = mCategoryImages.Images[decimal.ToInt32(ImageIndex.Value)];
        }
    }
}
