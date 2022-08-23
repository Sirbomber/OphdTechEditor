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
            this.SuspendLayout();
            // 
            // ListViewTechIcons
            // 
            this.ListViewTechIcons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewTechIcons.HideSelection = false;
            this.ListViewTechIcons.Location = new System.Drawing.Point(0, 0);
            this.ListViewTechIcons.Name = "ListViewTechIcons";
            this.ListViewTechIcons.Size = new System.Drawing.Size(626, 558);
            this.ListViewTechIcons.TabIndex = 0;
            this.ListViewTechIcons.UseCompatibleStateImageBehavior = false;
            this.ListViewTechIcons.DoubleClick += new System.EventHandler(this.ListViewTechIcons_DoubleClick);
            // 
            // FormChooseTechnologyIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 558);
            this.ControlBox = false;
            this.Controls.Add(this.ListViewTechIcons);
            this.KeyPreview = true;
            this.Name = "FormChooseTechnologyIcon";
            this.Text = "Choose Technology Icon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormChooseTechnologyIcon_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewTechIcons;
    }
}