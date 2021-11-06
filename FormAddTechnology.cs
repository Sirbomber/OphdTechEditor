using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OphdTechEdit
{
    public partial class FormAddTechnology : Form
    {
        public uint TechnologyId { get; set; }
        public List<uint> RequiredTechnologies { get; set; }

        public uint TechnologyAddedId { get; private set; } = 0;

        public FormAddTechnology()
        {
            InitializeComponent();
        }

        private void FormAddTechnology_Load(object sender, EventArgs e)
        {
            foreach (Category category in Globals.Categories)
            {
                TreeNode categoryNode = TreeViewTechnologies.Nodes.Add(category.Name);
                categoryNode.Tag = (uint)0;

                foreach (Technology technology in category.Techs)
                {
                    if (technology.Id == TechnologyId || RequiredTechnologies.Exists(x => x == technology.Id))
                    {
                        continue;
                    }

                    TreeNode technologyNode = categoryNode.Nodes.Add(technology.Name);
                    technologyNode.Tag = technology.Id;
                }
            }
        }

        private void FormAddTechnology_FormClosed(object sender, FormClosedEventArgs e)
        {
            TreeNode selection = TreeViewTechnologies.SelectedNode;

            if(selection != null)
            {
                TechnologyAddedId = (uint)selection.Tag;
            }
        }
    }
}
