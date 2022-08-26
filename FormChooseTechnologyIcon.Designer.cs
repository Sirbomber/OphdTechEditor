namespace OphdTechEdit
{
    partial class FormChooseTechnologyIcon
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
            this.ListViewTechIcons = new System.Windows.Forms.ListView();
            this.ComboIconFilter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListViewTechIcons
            // 
            this.ListViewTechIcons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewTechIcons.HideSelection = false;
            this.ListViewTechIcons.Location = new System.Drawing.Point(0, 27);
            this.ListViewTechIcons.Name = "ListViewTechIcons";
            this.ListViewTechIcons.Size = new System.Drawing.Size(626, 533);
            this.ListViewTechIcons.TabIndex = 0;
            this.ListViewTechIcons.UseCompatibleStateImageBehavior = false;
            this.ListViewTechIcons.DoubleClick += new System.EventHandler(this.ListViewTechIcons_DoubleClick);
            // 
            // ComboIconFilter
            // 
            this.ComboIconFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboIconFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboIconFilter.FormattingEnabled = true;
            this.ComboIconFilter.Location = new System.Drawing.Point(0, 0);
            this.ComboIconFilter.Name = "ComboIconFilter";
            this.ComboIconFilter.Size = new System.Drawing.Size(626, 21);
            this.ComboIconFilter.TabIndex = 1;
            this.ComboIconFilter.SelectionChangeCommitted += new System.EventHandler(this.ComboIconFilter_SelectionChangeCommitted);
            // 
            // FormChooseTechnologyIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 558);
            this.ControlBox = false;
            this.Controls.Add(this.ComboIconFilter);
            this.Controls.Add(this.ListViewTechIcons);
            this.KeyPreview = true;
            this.Name = "FormChooseTechnologyIcon";
            this.Text = "Choose Technology Icon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormChooseTechnologyIcon_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewTechIcons;
        private System.Windows.Forms.ComboBox ComboIconFilter;
    }
}