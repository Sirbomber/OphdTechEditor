
namespace OphdTechEdit
{
    partial class FormAddTechnology
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
            this.TreeViewTechnologies = new System.Windows.Forms.TreeView();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TreeViewTechnologies
            // 
            this.TreeViewTechnologies.Location = new System.Drawing.Point(12, 12);
            this.TreeViewTechnologies.Name = "TreeViewTechnologies";
            this.TreeViewTechnologies.Size = new System.Drawing.Size(430, 292);
            this.TreeViewTechnologies.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAdd.Location = new System.Drawing.Point(367, 313);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(286, 313);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddTechnology
            // 
            this.AcceptButton = this.ButtonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(454, 348);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TreeViewTechnologies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddTechnology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Technology";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddTechnology_FormClosed);
            this.Load += new System.EventHandler(this.FormAddTechnology_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewTechnologies;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonCancel;
    }
}