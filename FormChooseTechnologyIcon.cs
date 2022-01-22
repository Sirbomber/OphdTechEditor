﻿using System;
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
                return ListViewTechIcons.SelectedItems[0].Index;
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

            for(int i = 0; i < techIcons.Images.Count; i++)
            {
                ListViewTechIcons.Items.Add("", i);
            }
        }
    }
}
