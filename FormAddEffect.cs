using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OphdTechEdit
{
    public partial class FormAddEffect : Form
    {
        public Effect Effect { get; set; }

        public FormAddEffect()
        {
            InitializeComponent();
        }

        public FormAddEffect(Effect _toEdit)
        {
            InitializeComponent();
            Effect = _toEdit;

            if (Effect.EffectType == Effect.Type.Modifier)
            {
                ComboEffectType.Text = "Modifier";
                foreach (KeyValuePair<Effect.Modifier, string> item in Effect.ModifierToString)
                {
                    _ = ComboEffectSubType.Items.Add(item.Value);
                }
                ComboEffectSubType.Text = Effect.ModifierToString[Effect.Modifies];
                TextValue.Text = Convert.ToString(Effect.Value);
            }
            else
            {
                ComboEffectType.Text = "Unlock";
                foreach (KeyValuePair<Effect.Unlock, string> item in Effect.UnlockToString)
                {
                    _ = ComboEffectSubType.Items.Add(item.Value);
                }
                ComboEffectSubType.Text = Effect.UnlockToString[Effect.Unlocks];
                TextValue.Text = Convert.ToString(Effect.Value);
            }
        }

        private void TextValue_Enter(object sender, EventArgs e)
        {
            TextValue.BackColor = Control.DefaultBackColor;
        }

        private void ComboEffectSubType_Enter(object sender, EventArgs e)
        {
            ComboEffectSubType.BackColor = Control.DefaultBackColor;
        }

        private void ComboEffectType_Enter(object sender, EventArgs e)
        {
            ComboEffectType.BackColor = Control.DefaultBackColor;
        }


        private void ComboEffectType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string effectType = ComboEffectType.Text;

            ComboEffectSubType.Items.Clear();

            if (effectType == "Modifier")
            {
                foreach (KeyValuePair<Effect.Modifier, string> item in Effect.ModifierToString)
                {
                    _ = ComboEffectSubType.Items.Add(item.Value);
                }
            }
            else if(effectType == "Unlock")
            {
                foreach (KeyValuePair<Effect.Unlock, string> item in Effect.UnlockToString)
                {
                    _ = ComboEffectSubType.Items.Add(item.Value);
                }
            }
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            if(ComboEffectType.Text.Length == 0)
            {
                _ = MessageBox.Show("Must make a Type selection.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboEffectType.BackColor = Color.Yellow;
                return;

            }

            if (ComboEffectSubType.Text.Length == 0)
            {
                _ = MessageBox.Show("Must make a Sub Type selection.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboEffectSubType.BackColor = Color.Yellow;
                return;
            }

            if (TextValue.Text.Trim().Length == 0)
            {
                _ = MessageBox.Show("Value cannot be empty.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextValue.BackColor = Color.Yellow;
                return;
            }

            Effect effect;

            if (ComboEffectType.Text == "Modifier")
            {
                try
                {
                    effect = new Effect()
                    {
                        EffectType = Effect.Type.Modifier,
                        Modifies = Effect.StringToModifier[ComboEffectSubType.Text],
                        Value = Convert.ToDecimal(TextValue.Text)
                    };
                }
                catch(System.FormatException)
                {
                    _ = MessageBox.Show("Value must be numeric.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextValue.BackColor = Color.Yellow;
                    return;
                }
            }
            else
            {
                effect = new Effect()
                {
                    EffectType = Effect.Type.Unlock,
                    Unlocks = Effect.StringToUnlock[ComboEffectSubType.Text],
                    Value = TextValue.Text
                };
            }

            Effect = effect;

            DialogResult = DialogResult.OK;
        }
    }
}
