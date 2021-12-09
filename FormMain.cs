using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace OphdTechEdit
{
    public partial class FormMain : Form
    {
        private string TechFileName { get; set; }
        private string PreviousItemName { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Panels.Hide();
            SetSaveMenuFunctions(false);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetSaveMenuFunctions(bool enabled)
        {
            CloseTechFile.Enabled = enabled;
            SaveAsTechFile.Enabled = enabled;
            SaveTechFile.Enabled = enabled;
            newToolStripMenuItem.Enabled= !enabled;
        }

        private void HideUi()
        {
            Panels.Hide();
            ListCategories.Items.Clear();
            ListViewTechs.Items.Clear();
        }

        private void OpenTechFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string openDirectory = Properties.Settings.Default.LastOpenDirectory;
            if (string.IsNullOrEmpty(openDirectory)) { openDirectory = Application.StartupPath; }
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = openDirectory,
                Filter = "XML files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFile.ShowDialog() != DialogResult.OK) { return; }

            FileInfo fileInfo = new FileInfo(openFile.FileName);
            Properties.Settings.Default.LastOpenDirectory = fileInfo.DirectoryName;
            Properties.Settings.Default.Save();

            Globals.Categories.Clear();
            HideUi();

            TechFileName = openFile.FileName;
            System.IO.Stream fileStream = openFile.OpenFile();

            XmlReader reader = XmlReader.Create(fileStream, new XmlReaderSettings { IgnoreWhitespace = true });

            _ = reader.MoveToContent();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "category")
                        {
                            ParseCategories(reader);
                        }
                        break;

                    default:
                        break;
                }
            }

            fileStream.Close();

            Panels.Show();
            SetSaveMenuFunctions(true);
        }

        private void ParseCategories(XmlReader reader)
        {
            string categoryName = reader.GetAttribute("name");

            ListViewItem categoryItem = ListCategories.Items.Add(categoryName);
            categoryItem.ImageIndex = 0;

            Category category = new Category { Name = categoryName };

            Globals.Categories.Add(category);
            ParseTechnologies(category, reader);
        }

        private void ParseTechnologies(Category category, XmlReader reader)
        {
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "tech")
                        {
                            string techId = reader.GetAttribute("id");
                            string labType = reader.GetAttribute("lab_type");
                            string cost = reader.GetAttribute("cost");

                            Technology technology = new Technology
                            {
                                Id = Convert.ToUInt32(techId),
                                LabType = Convert.ToUInt32(labType),
                                Cost = Convert.ToUInt32(cost)
                            };

                            ParseTech(technology, reader);

                            category.AddTechnology(technology);
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name == "category")
                        {
                            return;
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void ParseTech(Technology technology, XmlReader reader)
        {
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "name")
                        {
                            _= reader.Read();
                            technology.Name = reader.Value;
                        }
                        else if (reader.Name == "description")
                        {
                            _ = reader.Read();
                            technology.Description = reader.Value;
                        }
                        else if (reader.Name == "requires")
                        {
                            _ = reader.Read();
                            string techIds = reader.Value;

                            string[] techIdSplit = techIds.Split(',');

                            foreach (string techId in techIdSplit)
                            {
                                if (techId.Length == 0) { continue; }
                                technology.RequiredTechnologies.Add(Convert.ToUInt32(techId));
                            }
                        }
                        else if (reader.Name == "effects")
                        {
                            ParseEffects(technology, reader);
                        }

                        break;

                    case XmlNodeType.EndElement:
                        if (reader.Name == "tech")
                        {
                            return;
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void ParseEffects(Technology technology, XmlReader reader)
        {
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:

                        Effect effect;
                        string type = reader.GetAttribute("type");

                        if (reader.Name == "unlock")
                        {
                            _ = reader.Read();
                            effect = new Effect()
                            {
                                EffectType = Effect.Type.Unlock,
                                Unlocks = Effect.StringToUnlock[type],
                                Value = reader.Value
                            };
                        }
                        else if (reader.Name == "modifier")
                        {
                            _ = reader.Read();
                            effect = new Effect()
                            {
                                EffectType = Effect.Type.Modifier,
                                Modifies = Effect.StringToModifier[type],
                                Value = Convert.ToDouble(reader.Value)
                            };
                        }
                        else
                        {
                            throw new XmlException("Unknown effect node found: " + reader.Name);
                        }

                        technology.Effects.Add(effect);
                        break;

                    case XmlNodeType.EndElement:
                        if (reader.Name == "effects")
                        {
                            return;
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void WriteTechFile()
        {
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                NewLineHandling = NewLineHandling.Entitize,
                OmitXmlDeclaration = true,
                Encoding = System.Text.Encoding.ASCII
            };

            XmlWriter writer = XmlWriter.Create(TechFileName, settings);

            writer.WriteStartDocument();

            writer.WriteStartElement("technology");


            foreach (Category category in Globals.Categories)
            {
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", category.Name);

                foreach (Technology technology in category.Techs)
                {
                    WriteTechnology(writer, technology);
                }

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        private bool ShowSaveAsDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML Tech Definition|*.xml",
                Title = "Save As"
            };

            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName.Length == 0)
            {
                return false;
            }

            TechFileName = saveFileDialog.FileName;

            return true;
        }

        private void WriteTechnology(XmlWriter writer, Technology technology)
        {
            writer.WriteStartElement("tech");
            writer.WriteAttributeString("id", technology.Id.ToString());
            writer.WriteAttributeString("lab_type", technology.LabType.ToString());
            writer.WriteAttributeString("cost", technology.Cost.ToString());

            writer.WriteStartElement("name");
            writer.WriteString(technology.Name);
            writer.WriteEndElement();

            WriteDescription(writer, technology);

            WriteRequiredTechIds(writer, technology);

            if(technology.Effects.Count != 0)
            {
                WriteEffects(writer, technology);
            }

            writer.WriteEndElement();
        }

        private void WriteDescription(XmlWriter writer, Technology technology)
        {
            if (technology.Description.Length == 0)
            {
                return;
            }

            writer.WriteStartElement("description");
            writer.WriteString(technology.Description);
            writer.WriteEndElement();
        }

        private void WriteRequiredTechIds(XmlWriter writer, Technology technology)
        {
            if (technology.RequiredTechnologies.Count == 0) { return; }

            writer.WriteStartElement("requires");
            string requiredString = "";
            foreach (uint id in technology.RequiredTechnologies)
            {
                if (requiredString.Length != 0) { requiredString += ","; }
                requiredString += id.ToString();
            }
            writer.WriteString(requiredString);
            writer.WriteEndElement();
        }

        private void WriteEffects(XmlWriter writer, Technology technology)
        {
            if (technology.Effects.Count == 0) { return; }

            writer.WriteStartElement("effects");

            foreach (Effect effect in technology.Effects)
            {
                if(effect.EffectType == Effect.Type.Modifier)
                {
                    writer.WriteStartElement("modifier");
                    writer.WriteAttributeString("type", Effect.ModifierToString[effect.Modifies]);
                }
                else
                {
                    writer.WriteStartElement("unlock");
                    writer.WriteAttributeString("type", Effect.UnlockToString[effect.Unlocks]);
                }
                writer.WriteString(effect.Value.ToString());

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        private void MenuCategoriesContextAction_Click(object sender, EventArgs e)
        {
            if (ListCategories.SelectedItems.Count != 0 && ListCategories.SelectedItems[0] != null)
            {
                ListViewItem item = ListCategories.SelectedItems[0];

                Category category = Globals.Categories.Find(x => x.Name == item.Text);

                Trace.Assert(category != null);

                _ = Globals.Categories.Remove(category);

                item.Remove();
            }
            else
            {
                Category category = new Category { Name = "New Category" };
                Globals.Categories.Add(category);
                ListViewItem categoryItem = ListCategories.Items.Add(category.Name);
                categoryItem.ImageIndex = 0;
                SetCategoryName(categoryItem, true);
            }
        }

        private void MenuCategoriesContext_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ListCategories.SelectedItems.Count != 0 && ListCategories.SelectedItems[0] != null)
            {
                MenuCategoriesContext.Items[0].Text = "Remove";
            }
            else
            {
                MenuCategoriesContext.Items[0].Text = "Add";
            }
        }

        private void MenuTechnologiesContextAction_Click(object sender, EventArgs e)
        {
            if (ListViewTechs.SelectedItems.Count != 0 && ListViewTechs.SelectedItems[0] != null)
            {
                ListViewItem item = ListViewTechs.SelectedItems[0];
                (Category, uint) itemTag = ((Category, uint))item.Tag;

                itemTag.Item1.RemoveTechnology(itemTag.Item2);
                Globals.PurgeTechnologyReferences(itemTag.Item2);
                item.Remove();
            }
            else
            {
                FormTechnology techForm = new FormTechnology() { Technology = new Technology() };

                if (techForm.ShowDialog() != DialogResult.OK) { return; }

                Technology technology = techForm.Technology;

                ListViewItem item = ListViewTechs.Items.Add(technology.Name);
                item.ImageIndex = Convert.ToInt32(technology.LabType);

                string categoryName = ListCategories.SelectedItems[0].Text;
                Category category = Globals.Categories.Find(x => x.Name == categoryName);

                category.AddTechnology(technology);

                (Category, uint) itemTag = (category, technology.Id);

                item.Tag = itemTag;

                item.Text = technology.Name;
                item.ImageIndex = Convert.ToInt32(technology.LabType);
            }
        }

        private void MenuTechnologiesContext_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ListViewTechs.SelectedItems.Count != 0 && ListViewTechs.SelectedItems[0] != null)
            {
                MenuTechnologiesContext.Items[0].Text = "Remove";
            }
            else
            {
                MenuTechnologiesContext.Items[0].Text = "Add";
            }
        }

        private void CloseTechFile_Click(object sender, EventArgs e)
        {
            HideUi();
            Globals.Categories.Clear();
            SetSaveMenuFunctions(false);
            TechFileName = "";
            PreviousItemName = "";
        }

        private void ListCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewTechs.Items.Clear();

            if (ListCategories.SelectedIndices.Count < 1)
            {
                ListViewTechs.Enabled = false;
                return;
            }

            ListViewTechs.Enabled = true;

            string categoryName = ListCategories.SelectedItems[0].Text;
            Category category = Globals.Categories.Find(x => x.Name == categoryName);

            if (category == null) { return; }

            foreach (Technology tech in category.Techs)
            {
                ListViewItem item = ListViewTechs.Items.Add(tech.Name);
                item.ImageIndex = Convert.ToInt32(tech.LabType);

                (Category, uint) itemTag = (category, tech.Id);

                item.Tag = itemTag;
            }
        }

        private void ListViewTechs_DoubleClick(object sender, EventArgs e)
        {
            if (ListViewTechs.SelectedIndices.Count < 1) { return; }

            ListViewItem item = ListViewTechs.SelectedItems[0];
            (Category, uint) itemTag = ((Category, uint))item.Tag;
            uint previousTechId = itemTag.Item2;

            Technology technology = itemTag.Item1.Techs.Find(x => x.Id == itemTag.Item2);

            if (technology == null) { return; }

            FormTechnology techForm = new FormTechnology() { Technology = technology };

            if (techForm.ShowDialog() == DialogResult.OK)
            {
                item.Text = technology.Name;
                item.ImageIndex = Convert.ToInt32(technology.LabType);
                itemTag.Item2 = technology.Id;
                item.Tag = itemTag;

                if(previousTechId != technology.Id)
                {
                    Globals.UpdateTechIdReferences(previousTechId, technology.Id);
                }
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            _ = about.ShowDialog();
        }

        private void SaveTechFile_Click(object sender, EventArgs e)
        {
            if (TechFileName.Length == 0)
            {
                if (!ShowSaveAsDialog())
                {
                    return;
                }
            }

            WriteTechFile();
        }

        private void SaveAsTechFile_Click(object sender, EventArgs e)
        {
            _ = ShowSaveAsDialog();
            WriteTechFile();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panels.Show();
            SetSaveMenuFunctions(true);
        }

        private void SetCategoryName(ListViewItem item, bool forceNameChange)
        {
            Category category = Globals.Categories.Find(x => x.Name == item.Text);

            Trace.Assert(item != null);
            Trace.Assert(category != null);

            FormEditCategoryName editCategoryName = new FormEditCategoryName()
            {
                CategoryName = category.Name
            };

            if (forceNameChange)
            {
                editCategoryName.ForceNameChange();
            }

            for (;;)
            {
                if (editCategoryName.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                if (Globals.CategoryNameInUse(editCategoryName.CategoryName))
                {
                    _ = MessageBox.Show("Category name is already used in another Category. Please choose another name.",
                        "Category Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    break;
                }
            }

            category.Name = editCategoryName.CategoryName;
            item.Text = category.Name;
        }

        private void ListCategories_DoubleClick(object sender, EventArgs e)
        {
            if (ListCategories.SelectedItems.Count <= 0)
            {
                return;
            }

            ListViewItem item = ListCategories.SelectedItems[0];
            SetCategoryName(item, false);
        }
    }
}