
namespace OphdTechEdit
{
    partial class FormTechnology
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonChooseIcon = new System.Windows.Forms.Button();
            this.TechIcon = new System.Windows.Forms.PictureBox();
            this.TextDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonRemoveTech = new System.Windows.Forms.Button();
            this.ButtonAddTech = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ListRequiredTechs = new System.Windows.Forms.ListBox();
            this.RadioLabSurface = new System.Windows.Forms.RadioButton();
            this.RadioLabUnderground = new System.Windows.Forms.RadioButton();
            this.NumericCost = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericTechId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ButtonRemoveEffect = new System.Windows.Forms.Button();
            this.ButtonAddEffect = new System.Windows.Forms.Button();
            this.ListEffects = new System.Windows.Forms.ListBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonEditEffect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechIcon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTechId)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonChooseIcon);
            this.groupBox1.Controls.Add(this.TechIcon);
            this.groupBox1.Controls.Add(this.TextDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // ButtonChooseIcon
            // 
            this.ButtonChooseIcon.Location = new System.Drawing.Point(372, 165);
            this.ButtonChooseIcon.Name = "ButtonChooseIcon";
            this.ButtonChooseIcon.Size = new System.Drawing.Size(128, 23);
            this.ButtonChooseIcon.TabIndex = 5;
            this.ButtonChooseIcon.Text = "Choose Icon...";
            this.ButtonChooseIcon.UseVisualStyleBackColor = true;
            this.ButtonChooseIcon.Click += new System.EventHandler(this.ButtonChooseIcon_Click);
            // 
            // TechIcon
            // 
            this.TechIcon.Location = new System.Drawing.Point(372, 16);
            this.TechIcon.Name = "TechIcon";
            this.TechIcon.Size = new System.Drawing.Size(128, 128);
            this.TechIcon.TabIndex = 4;
            this.TechIcon.TabStop = false;
            // 
            // TextDescription
            // 
            this.TextDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDescription.DetectUrls = false;
            this.TextDescription.Location = new System.Drawing.Point(6, 72);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextDescription.Size = new System.Drawing.Size(355, 117);
            this.TextDescription.TabIndex = 3;
            this.TextDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(6, 32);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(355, 20);
            this.TextName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonRemoveTech);
            this.groupBox2.Controls.Add(this.ButtonAddTech);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ListRequiredTechs);
            this.groupBox2.Controls.Add(this.RadioLabSurface);
            this.groupBox2.Controls.Add(this.RadioLabUnderground);
            this.groupBox2.Controls.Add(this.NumericCost);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NumericTechId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // ButtonRemoveTech
            // 
            this.ButtonRemoveTech.Location = new System.Drawing.Point(438, 102);
            this.ButtonRemoveTech.Name = "ButtonRemoveTech";
            this.ButtonRemoveTech.Size = new System.Drawing.Size(62, 23);
            this.ButtonRemoveTech.TabIndex = 9;
            this.ButtonRemoveTech.Text = "Remove";
            this.ButtonRemoveTech.UseVisualStyleBackColor = true;
            this.ButtonRemoveTech.Click += new System.EventHandler(this.ButtonRemoveTech_Click);
            // 
            // ButtonAddTech
            // 
            this.ButtonAddTech.Location = new System.Drawing.Point(438, 73);
            this.ButtonAddTech.Name = "ButtonAddTech";
            this.ButtonAddTech.Size = new System.Drawing.Size(62, 23);
            this.ButtonAddTech.TabIndex = 8;
            this.ButtonAddTech.Text = "Add...";
            this.ButtonAddTech.UseVisualStyleBackColor = true;
            this.ButtonAddTech.Click += new System.EventHandler(this.ButtonAddTech_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Required Techs";
            // 
            // ListRequiredTechs
            // 
            this.ListRequiredTechs.FormattingEnabled = true;
            this.ListRequiredTechs.Location = new System.Drawing.Point(6, 73);
            this.ListRequiredTechs.Name = "ListRequiredTechs";
            this.ListRequiredTechs.ScrollAlwaysVisible = true;
            this.ListRequiredTechs.Size = new System.Drawing.Size(426, 69);
            this.ListRequiredTechs.Sorted = true;
            this.ListRequiredTechs.TabIndex = 6;
            // 
            // RadioLabSurface
            // 
            this.RadioLabSurface.AutoSize = true;
            this.RadioLabSurface.Location = new System.Drawing.Point(368, 32);
            this.RadioLabSurface.Name = "RadioLabSurface";
            this.RadioLabSurface.Size = new System.Drawing.Size(132, 17);
            this.RadioLabSurface.TabIndex = 5;
            this.RadioLabSurface.Text = "Surface Lab / Hot Lab";
            this.RadioLabSurface.UseVisualStyleBackColor = true;
            // 
            // RadioLabUnderground
            // 
            this.RadioLabUnderground.AutoSize = true;
            this.RadioLabUnderground.Checked = true;
            this.RadioLabUnderground.Location = new System.Drawing.Point(254, 32);
            this.RadioLabUnderground.Name = "RadioLabUnderground";
            this.RadioLabUnderground.Size = new System.Drawing.Size(108, 17);
            this.RadioLabUnderground.TabIndex = 4;
            this.RadioLabUnderground.TabStop = true;
            this.RadioLabUnderground.Text = "Underground Lab";
            this.RadioLabUnderground.UseVisualStyleBackColor = true;
            // 
            // NumericCost
            // 
            this.NumericCost.Location = new System.Drawing.Point(112, 32);
            this.NumericCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericCost.Name = "NumericCost";
            this.NumericCost.Size = new System.Drawing.Size(100, 20);
            this.NumericCost.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Research Cost";
            // 
            // NumericTechId
            // 
            this.NumericTechId.Location = new System.Drawing.Point(6, 32);
            this.NumericTechId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericTechId.Name = "NumericTechId";
            this.NumericTechId.Size = new System.Drawing.Size(100, 20);
            this.NumericTechId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tech ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ButtonEditEffect);
            this.groupBox3.Controls.Add(this.ButtonRemoveEffect);
            this.groupBox3.Controls.Add(this.ButtonAddEffect);
            this.groupBox3.Controls.Add(this.ListEffects);
            this.groupBox3.Location = new System.Drawing.Point(12, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Effects";
            // 
            // ButtonRemoveEffect
            // 
            this.ButtonRemoveEffect.Location = new System.Drawing.Point(437, 78);
            this.ButtonRemoveEffect.Name = "ButtonRemoveEffect";
            this.ButtonRemoveEffect.Size = new System.Drawing.Size(62, 23);
            this.ButtonRemoveEffect.TabIndex = 13;
            this.ButtonRemoveEffect.Text = "Remove";
            this.ButtonRemoveEffect.UseVisualStyleBackColor = true;
            this.ButtonRemoveEffect.Click += new System.EventHandler(this.ButtonRemoveEffect_Click);
            // 
            // ButtonAddEffect
            // 
            this.ButtonAddEffect.Location = new System.Drawing.Point(437, 19);
            this.ButtonAddEffect.Name = "ButtonAddEffect";
            this.ButtonAddEffect.Size = new System.Drawing.Size(62, 23);
            this.ButtonAddEffect.TabIndex = 11;
            this.ButtonAddEffect.Text = "Add...";
            this.ButtonAddEffect.UseVisualStyleBackColor = true;
            this.ButtonAddEffect.Click += new System.EventHandler(this.ButtonAddEffect_Click);
            // 
            // ListEffects
            // 
            this.ListEffects.FormattingEnabled = true;
            this.ListEffects.Location = new System.Drawing.Point(6, 19);
            this.ListEffects.Name = "ListEffects";
            this.ListEffects.ScrollAlwaysVisible = true;
            this.ListEffects.Size = new System.Drawing.Size(426, 82);
            this.ListEffects.TabIndex = 10;
            // 
            // ButtonSave
            // 
            this.ButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonSave.Location = new System.Drawing.Point(442, 482);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(361, 482);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonEditEffect
            // 
            this.ButtonEditEffect.Location = new System.Drawing.Point(437, 48);
            this.ButtonEditEffect.Name = "ButtonEditEffect";
            this.ButtonEditEffect.Size = new System.Drawing.Size(62, 23);
            this.ButtonEditEffect.TabIndex = 12;
            this.ButtonEditEffect.Text = "Edit...";
            this.ButtonEditEffect.UseVisualStyleBackColor = true;
            this.ButtonEditEffect.Click += new System.EventHandler(this.ButtonEditEffect_Click);
            // 
            // FormTechnology
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(529, 515);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTechnology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Technology";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechIcon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTechId)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NumericCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericTechId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioLabSurface;
        private System.Windows.Forms.RadioButton RadioLabUnderground;
        private System.Windows.Forms.Button ButtonRemoveTech;
        private System.Windows.Forms.Button ButtonAddTech;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ListRequiredTechs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ButtonRemoveEffect;
        private System.Windows.Forms.Button ButtonAddEffect;
        private System.Windows.Forms.ListBox ListEffects;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.RichTextBox TextDescription;
        private System.Windows.Forms.Button ButtonChooseIcon;
        private System.Windows.Forms.PictureBox TechIcon;
        private System.Windows.Forms.Button ButtonEditEffect;
    }
}