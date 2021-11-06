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
        public string CategoryName
        {
            get => TextCategoryName.Text;
            set => TextCategoryName.Text = value;
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
    }
}
