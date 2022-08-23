using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OphdTechEdit
{
    public struct TechInfo
    {
        public string Name;
        public uint Id;

        public override string ToString()
        {
            return Name;
        }
    }

    public partial class FormTechnology : Form
    {
        private Technology technology;

        private string PreviousTechName { get; set; }
        private uint PreviousIconIndex { get; set; }
        private List<uint> PreviousRequiredTechnologies { get; set; }
        private List<Effect> PreviousEffects { get; set; }


        public ImageList TopicIcons { get; set; } = new ImageList();

        public Technology Technology
        {
            get => technology;
        
            set
            {
                technology = value;
                TechPropertyChanged();
            }
        }

        public FormTechnology()
        {
            InitializeComponent();
        }

        private void TechPropertyChanged()
        {
            PreviousTechName = technology.Name;
            PreviousIconIndex = technology.IconIndex;
            PreviousRequiredTechnologies = new List<uint>(technology.RequiredTechnologies);
            PreviousEffects = new List<Effect>(technology.Effects);
            TextName.Text = technology.Name;
            TextDescription.Text = technology.Description;
            
            NumericTechId.Value = Convert.ToDecimal(technology.Id);
            NumericCost.Value = Convert.ToDecimal(technology.Cost);

            try
            {
                TechIcon.Image = TopicIcons.Images[Convert.ToInt32(technology.IconIndex)];
            }
            catch
            {
                TechIcon.Image = TopicIcons.Images[0];
                technology.IconIndex = 0;
            }

            _ = technology.LabType == 0 ? RadioLabUnderground.Checked = true : RadioLabSurface.Checked = true;

            ListRequiredTechs.Items.Clear();

            foreach (uint techId in technology.RequiredTechnologies)
            {
                Technology tech = Globals.FindTechnologyById(techId);

                if (tech != null)
                {
                    _ = ListRequiredTechs.Items.Add(new TechInfo() { Name = tech.Name, Id = tech.Id });
                }
            }

            foreach (Effect effect in technology.Effects)
            {
                _ = ListEffects.Items.Add(effect);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (PreviousTechName != TextName.Text && Globals.TechNameInUse(TextName.Text))
            {
                _ = MessageBox.Show("Another technology uses that name, please choose another.", "Edit Technology", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            if (Globals.TechIdInUse(Convert.ToUInt32(NumericTechId.Value), TextName.Text, PreviousTechName != TextName.Text))
            {
                _ = MessageBox.Show("TechID in use, please choose another.", "Edit Technology", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            technology.Name = TextName.Text;
            technology.Description = TextDescription.Text;

            technology.Id = Convert.ToUInt32(NumericTechId.Value);
            technology.Cost = Convert.ToUInt32(NumericCost.Value);

            technology.LabType = RadioLabSurface.Checked ? 1u : 0;
        }

        private void ButtonAddTech_Click(object sender, EventArgs e)
        {
            FormAddTechnology addTech = new FormAddTechnology()
            {
                TechnologyId = technology.Id,
                RequiredTechnologies = technology.RequiredTechnologies
            };

            if (addTech.ShowDialog() != DialogResult.OK) { return; }

            uint addedTechnologyId = addTech.TechnologyAddedId;
            if (addedTechnologyId == 0) { return; }

            technology.RequiredTechnologies.Add(addedTechnologyId);

            Technology tech = Globals.FindTechnologyById(addedTechnologyId);
            if (tech == null) { return; } /// necessary?

            _ = ListRequiredTechs.Items.Add(new TechInfo() { Name = tech.Name, Id = tech.Id });
        }

        private void ButtonRemoveTech_Click(object sender, EventArgs e)
        {
            object selectedItem = ListRequiredTechs.SelectedItem;
            if (selectedItem == null) { return; }
            
            uint technologyId = ((TechInfo)selectedItem).Id;
            Trace.Assert(technology.RequiredTechnologies.Remove(technologyId));
            ListRequiredTechs.Items.Remove(selectedItem);
        }

        private void ButtonRemoveEffect_Click(object sender, EventArgs e)
        {
            Effect selectedItem = (Effect)ListEffects.SelectedItem;
            if (selectedItem == null) { return; }

            _ = technology.Effects.Remove(selectedItem);
            ListEffects.Items.Remove(selectedItem);
        }

        private void ButtonAddEffect_Click(object sender, EventArgs e)
        {
            FormAddEffect addEffect = new FormAddEffect();
            
           if(addEffect.ShowDialog() == DialogResult.OK)
            {
                technology.Effects.Add(addEffect.Effect);
                _ = ListEffects.Items.Add(addEffect.Effect);
            }
        }

        private void ButtonChooseIcon_Click(object sender, EventArgs e)
        {
            FormChooseTechnologyIcon formChooseIcon = new FormChooseTechnologyIcon()
            {
                TechIcons = TopicIcons,
                SelectionIndex = (int)Technology.IconIndex
            };

            if(formChooseIcon.ShowDialog() == DialogResult.OK)
            {
                technology.IconIndex = (uint)formChooseIcon.SelectionIndex;
                TechIcon.Image = TopicIcons.Images[formChooseIcon.SelectionIndex];
            }
        }

        private void ButtonEditEffect_Click(object sender, EventArgs e)
        {
            Effect selectedItem = (Effect)ListEffects.SelectedItem;
            if (selectedItem == null) { return; }

            FormAddEffect addEffect = new FormAddEffect(selectedItem);

            if (addEffect.ShowDialog() == DialogResult.OK)
            {
                selectedItem = addEffect.Effect;
                technology.Effects[ListEffects.SelectedIndex] = selectedItem;
                ListEffects.Items.Insert(ListEffects.SelectedIndex, selectedItem);
                ListEffects.Items.RemoveAt(ListEffects.SelectedIndex);
            }

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            technology.IconIndex = PreviousIconIndex;
            technology.RequiredTechnologies.Clear();
            technology.RequiredTechnologies = new List<uint>(PreviousRequiredTechnologies);
            technology.Effects.Clear();
            technology.Effects = new List<Effect>(PreviousEffects);
        }
    }
}
