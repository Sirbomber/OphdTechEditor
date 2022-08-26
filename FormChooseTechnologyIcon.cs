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
    public partial class FormChooseTechnologyIcon : Form
    {
        private const string NO_FILTER = "(all)";
        private ImageList techIcons = new ImageList();

        public ImageList TechIcons
        {
            get
            {
                return techIcons;
            }

            set
            {
                techIcons = value;
                IconsSet();
            }
        }

        public int SelectionIndex
        {
            get
            {
                return Convert.ToInt32(ListViewTechIcons.SelectedItems[0].Name);
            }

            set
            {
                ListViewTechIcons.Items[value].Selected = true;
            }
        }

        public FormChooseTechnologyIcon()
        {
            InitializeComponent();
        }

        private void ListViewTechIcons_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        private void IconsSet()
        {
            ListViewTechIcons.LargeImageList = techIcons;
            ComboIconFilter.Items.Add(NO_FILTER);
            ComboIconFilter.SelectedItem = NO_FILTER;
            string lastAdded = null;

            for (int i = 0; i < techIcons.Images.Count; i++)
            {
                string key = techIcons.Images.Keys[i].ToString();
                key = key.Split()[0];
                if (key != lastAdded)
                {
                    lastAdded = key;
                    ComboIconFilter.Items.Add(key);
                }
                ListViewTechIcons.Items.Add(Convert.ToString(i), "", i);
            }
        }

        private void FormChooseTechnologyIcon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void ComboIconFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string filter = ComboIconFilter.Text;
            ListViewTechIcons.Clear();
            for (int i = 0; i < techIcons.Images.Count; i++)
            {
                if (filter == NO_FILTER)
                {
                    ListViewTechIcons.Items.Add(Convert.ToString(i), "", i);
                }
                else
                {
                    string key = techIcons.Images.Keys[i].ToString();
                    key = key.Split()[0];
                    if (key == filter)
                    {
                        ListViewTechIcons.Items.Add(Convert.ToString(i), "", i);
                    }
                }
            }
        }
    }
}
