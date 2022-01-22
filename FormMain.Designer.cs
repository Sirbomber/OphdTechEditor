
namespace OphdTechEdit
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openTechFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseTechFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.SaveTechFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsTechFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.Panels = new System.Windows.Forms.SplitContainer();
            this.ListCategories = new System.Windows.Forms.ListView();
            this.MenuCategoriesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuCategoriesContextAction = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryIcons = new System.Windows.Forms.ImageList(this.components);
            this.ListViewTechs = new System.Windows.Forms.ListView();
            this.MenuTechnologiesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuTechnologiesContextAction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panels)).BeginInit();
            this.Panels.Panel1.SuspendLayout();
            this.Panels.Panel2.SuspendLayout();
            this.Panels.SuspendLayout();
            this.MenuCategoriesContext.SuspendLayout();
            this.MenuTechnologiesContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openTechFileToolStripMenuItem,
            this.CloseTechFile,
            this.saveToolStripMenuItem,
            this.SaveTechFile,
            this.SaveAsTechFile,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // openTechFileToolStripMenuItem
            // 
            this.openTechFileToolStripMenuItem.Name = "openTechFileToolStripMenuItem";
            this.openTechFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openTechFileToolStripMenuItem.Text = "Open Tech File...";
            this.openTechFileToolStripMenuItem.Click += new System.EventHandler(this.OpenTechFileToolStripMenuItem_Click);
            // 
            // CloseTechFile
            // 
            this.CloseTechFile.Name = "CloseTechFile";
            this.CloseTechFile.Size = new System.Drawing.Size(180, 22);
            this.CloseTechFile.Text = "Close";
            this.CloseTechFile.Click += new System.EventHandler(this.CloseTechFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // SaveTechFile
            // 
            this.SaveTechFile.Name = "SaveTechFile";
            this.SaveTechFile.Size = new System.Drawing.Size(180, 22);
            this.SaveTechFile.Text = "Save";
            this.SaveTechFile.Click += new System.EventHandler(this.SaveTechFile_Click);
            // 
            // SaveAsTechFile
            // 
            this.SaveAsTechFile.Name = "SaveAsTechFile";
            this.SaveAsTechFile.Size = new System.Drawing.Size(180, 22);
            this.SaveAsTechFile.Text = "Save As...";
            this.SaveAsTechFile.Click += new System.EventHandler(this.SaveAsTechFile_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "regularlab.png");
            this.IconList.Images.SetKeyName(1, "hotlab.png");
            // 
            // Panels
            // 
            this.Panels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panels.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Panels.Location = new System.Drawing.Point(0, 24);
            this.Panels.Name = "Panels";
            // 
            // Panels.Panel1
            // 
            this.Panels.Panel1.Controls.Add(this.ListCategories);
            // 
            // Panels.Panel2
            // 
            this.Panels.Panel2.Controls.Add(this.ListViewTechs);
            this.Panels.Size = new System.Drawing.Size(784, 537);
            this.Panels.SplitterDistance = 222;
            this.Panels.TabIndex = 3;
            // 
            // ListCategories
            // 
            this.ListCategories.ContextMenuStrip = this.MenuCategoriesContext;
            this.ListCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCategories.HideSelection = false;
            this.ListCategories.LargeImageList = this.CategoryIcons;
            this.ListCategories.Location = new System.Drawing.Point(0, 0);
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(220, 535);
            this.ListCategories.SmallImageList = this.CategoryIcons;
            this.ListCategories.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListCategories.TabIndex = 0;
            this.ListCategories.TileSize = new System.Drawing.Size(64, 64);
            this.ListCategories.UseCompatibleStateImageBehavior = false;
            this.ListCategories.SelectedIndexChanged += new System.EventHandler(this.ListCategories_SelectedIndexChanged);
            this.ListCategories.DoubleClick += new System.EventHandler(this.ListCategories_DoubleClick);
            // 
            // MenuCategoriesContext
            // 
            this.MenuCategoriesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCategoriesContextAction});
            this.MenuCategoriesContext.Name = "MenuCategoriesContext";
            this.MenuCategoriesContext.ShowImageMargin = false;
            this.MenuCategoriesContext.Size = new System.Drawing.Size(113, 26);
            this.MenuCategoriesContext.Opening += new System.ComponentModel.CancelEventHandler(this.MenuCategoriesContext_Opening);
            // 
            // MenuCategoriesContextAction
            // 
            this.MenuCategoriesContextAction.Name = "MenuCategoriesContextAction";
            this.MenuCategoriesContextAction.Size = new System.Drawing.Size(112, 22);
            this.MenuCategoriesContextAction.Text = "Action Here";
            this.MenuCategoriesContextAction.Click += new System.EventHandler(this.MenuCategoriesContextAction_Click);
            // 
            // CategoryIcons
            // 
            this.CategoryIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CategoryIcons.ImageStream")));
            this.CategoryIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.CategoryIcons.Images.SetKeyName(0, "astronomy.png");
            this.CategoryIcons.Images.SetKeyName(1, "biology.png");
            this.CategoryIcons.Images.SetKeyName(2, "chemistry.png");
            this.CategoryIcons.Images.SetKeyName(3, "compsci.png");
            this.CategoryIcons.Images.SetKeyName(4, "geology.png");
            this.CategoryIcons.Images.SetKeyName(5, "material.png");
            this.CategoryIcons.Images.SetKeyName(6, "medicine.png");
            this.CategoryIcons.Images.SetKeyName(7, "physics.png");
            this.CategoryIcons.Images.SetKeyName(8, "social.png");
            // 
            // ListViewTechs
            // 
            this.ListViewTechs.ContextMenuStrip = this.MenuTechnologiesContext;
            this.ListViewTechs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewTechs.HideSelection = false;
            this.ListViewTechs.LargeImageList = this.IconList;
            this.ListViewTechs.Location = new System.Drawing.Point(0, 0);
            this.ListViewTechs.Name = "ListViewTechs";
            this.ListViewTechs.Size = new System.Drawing.Size(556, 535);
            this.ListViewTechs.SmallImageList = this.IconList;
            this.ListViewTechs.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListViewTechs.TabIndex = 0;
            this.ListViewTechs.TileSize = new System.Drawing.Size(128, 128);
            this.ListViewTechs.UseCompatibleStateImageBehavior = false;
            this.ListViewTechs.DoubleClick += new System.EventHandler(this.ListViewTechs_DoubleClick);
            // 
            // MenuTechnologiesContext
            // 
            this.MenuTechnologiesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTechnologiesContextAction});
            this.MenuTechnologiesContext.Name = "MenuTechnologiesContext";
            this.MenuTechnologiesContext.Size = new System.Drawing.Size(138, 26);
            this.MenuTechnologiesContext.Opening += new System.ComponentModel.CancelEventHandler(this.MenuTechnologiesContext_Opening);
            // 
            // MenuTechnologiesContextAction
            // 
            this.MenuTechnologiesContextAction.AutoSize = false;
            this.MenuTechnologiesContextAction.Name = "MenuTechnologiesContextAction";
            this.MenuTechnologiesContextAction.Size = new System.Drawing.Size(251, 22);
            this.MenuTechnologiesContextAction.Text = "Action Here";
            this.MenuTechnologiesContextAction.Click += new System.EventHandler(this.MenuTechnologiesContextAction_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Panels);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechEdit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panels.Panel1.ResumeLayout(false);
            this.Panels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panels)).EndInit();
            this.Panels.ResumeLayout(false);
            this.MenuCategoriesContext.ResumeLayout(false);
            this.MenuTechnologiesContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTechFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveTechFile;
        private System.Windows.Forms.ToolStripMenuItem SaveAsTechFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.SplitContainer Panels;
        private System.Windows.Forms.ListView ListViewTechs;
        private System.Windows.Forms.ListView ListCategories;
        private System.Windows.Forms.ContextMenuStrip MenuCategoriesContext;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoriesContextAction;
        private System.Windows.Forms.ToolStripMenuItem CloseTechFile;
        private System.Windows.Forms.ImageList CategoryIcons;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuTechnologiesContext;
        private System.Windows.Forms.ToolStripMenuItem MenuTechnologiesContextAction;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

