
namespace OphdTechEdit
{
    partial class FormAddEffect
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
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ComboEffectType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboEffectSubType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Location = new System.Drawing.Point(254, 131);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccept.TabIndex = 0;
            this.ButtonAccept.Text = "Save";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(173, 131);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ComboEffectType
            // 
            this.ComboEffectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEffectType.FormattingEnabled = true;
            this.ComboEffectType.Items.AddRange(new object[] {
            "Modifier",
            "Unlock"});
            this.ComboEffectType.Location = new System.Drawing.Point(12, 25);
            this.ComboEffectType.Name = "ComboEffectType";
            this.ComboEffectType.Size = new System.Drawing.Size(317, 21);
            this.ComboEffectType.Sorted = true;
            this.ComboEffectType.TabIndex = 2;
            this.ComboEffectType.SelectionChangeCommitted += new System.EventHandler(this.ComboEffectType_SelectionChangeCommitted);
            this.ComboEffectType.Enter += new System.EventHandler(this.ComboEffectType_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sub Type";
            // 
            // ComboEffectSubType
            // 
            this.ComboEffectSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEffectSubType.FormattingEnabled = true;
            this.ComboEffectSubType.Location = new System.Drawing.Point(12, 65);
            this.ComboEffectSubType.Name = "ComboEffectSubType";
            this.ComboEffectSubType.Size = new System.Drawing.Size(317, 21);
            this.ComboEffectSubType.Sorted = true;
            this.ComboEffectSubType.TabIndex = 5;
            this.ComboEffectSubType.Enter += new System.EventHandler(this.ComboEffectSubType_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value";
            // 
            // TextValue
            // 
            this.TextValue.Location = new System.Drawing.Point(12, 105);
            this.TextValue.Name = "TextValue";
            this.TextValue.Size = new System.Drawing.Size(317, 20);
            this.TextValue.TabIndex = 7;
            this.TextValue.Enter += new System.EventHandler(this.TextValue_Enter);
            // 
            // FormAddEffect
            // 
            this.AcceptButton = this.ButtonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(341, 161);
            this.ControlBox = false;
            this.Controls.Add(this.TextValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboEffectSubType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboEffectType);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddEffect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Effect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox ComboEffectType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboEffectSubType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextValue;
    }
}