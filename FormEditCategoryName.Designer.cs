
namespace OphdTechEdit
{
    partial class FormEditCategoryName
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
            this.TextCategoryName = new System.Windows.Forms.TextBox();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.PictureCategoryIcon = new System.Windows.Forms.PictureBox();
            this.ImageIndex = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCategoryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // TextCategoryName
            // 
            this.TextCategoryName.Location = new System.Drawing.Point(12, 12);
            this.TextCategoryName.Name = "TextCategoryName";
            this.TextCategoryName.Size = new System.Drawing.Size(336, 20);
            this.TextCategoryName.TabIndex = 0;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Location = new System.Drawing.Point(273, 105);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccept.TabIndex = 1;
            this.ButtonAccept.Text = "Save";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(192, 105);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // PictureCategoryIcon
            // 
            this.PictureCategoryIcon.Location = new System.Drawing.Point(12, 38);
            this.PictureCategoryIcon.Name = "PictureCategoryIcon";
            this.PictureCategoryIcon.Size = new System.Drawing.Size(64, 64);
            this.PictureCategoryIcon.TabIndex = 3;
            this.PictureCategoryIcon.TabStop = false;
            // 
            // ImageIndex
            // 
            this.ImageIndex.Location = new System.Drawing.Point(12, 108);
            this.ImageIndex.Name = "ImageIndex";
            this.ImageIndex.Size = new System.Drawing.Size(64, 20);
            this.ImageIndex.TabIndex = 4;
            this.ImageIndex.ValueChanged += new System.EventHandler(this.ImageIndex_ValueChanged);
            // 
            // FormEditCategoryName
            // 
            this.AcceptButton = this.ButtonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(360, 141);
            this.ControlBox = false;
            this.Controls.Add(this.ImageIndex);
            this.Controls.Add(this.PictureCategoryIcon);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.TextCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEditCategoryName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Category Name";
            ((System.ComponentModel.ISupportInitialize)(this.PictureCategoryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextCategoryName;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.PictureBox PictureCategoryIcon;
        private System.Windows.Forms.NumericUpDown ImageIndex;
    }
}