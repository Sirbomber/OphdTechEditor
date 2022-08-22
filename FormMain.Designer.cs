
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
            this.exportIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.exportIconsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // openTechFileToolStripMenuItem
            // 
            this.openTechFileToolStripMenuItem.Name = "openTechFileToolStripMenuItem";
            this.openTechFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openTechFileToolStripMenuItem.Text = "Open Tech File...";
            this.openTechFileToolStripMenuItem.Click += new System.EventHandler(this.OpenTechFileToolStripMenuItem_Click);
            // 
            // CloseTechFile
            // 
            this.CloseTechFile.Name = "CloseTechFile";
            this.CloseTechFile.Size = new System.Drawing.Size(160, 22);
            this.CloseTechFile.Text = "Close";
            this.CloseTechFile.Click += new System.EventHandler(this.CloseTechFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(157, 6);
            // 
            // SaveTechFile
            // 
            this.SaveTechFile.Name = "SaveTechFile";
            this.SaveTechFile.Size = new System.Drawing.Size(160, 22);
            this.SaveTechFile.Text = "Save";
            this.SaveTechFile.Click += new System.EventHandler(this.SaveTechFile_Click);
            // 
            // SaveAsTechFile
            // 
            this.SaveAsTechFile.Name = "SaveAsTechFile";
            this.SaveAsTechFile.Size = new System.Drawing.Size(160, 22);
            this.SaveAsTechFile.Text = "Save As...";
            this.SaveAsTechFile.Click += new System.EventHandler(this.SaveAsTechFile_Click);
            // 
            // exportIconsToolStripMenuItem
            // 
            this.exportIconsToolStripMenuItem.Name = "exportIconsToolStripMenuItem";
            this.exportIconsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportIconsToolStripMenuItem.Text = "Export Icons";
            this.exportIconsToolStripMenuItem.Click += new System.EventHandler(this.ExportIconsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
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
            this.IconList.Images.SetKeyName(0, "(31).png");
            this.IconList.Images.SetKeyName(1, "(149).png");
            this.IconList.Images.SetKeyName(2, "(169).png");
            this.IconList.Images.SetKeyName(3, "(233).png");
            this.IconList.Images.SetKeyName(4, "(250).png");
            this.IconList.Images.SetKeyName(5, "(263).png");
            this.IconList.Images.SetKeyName(6, "(267).png");
            this.IconList.Images.SetKeyName(7, "(276).png");
            this.IconList.Images.SetKeyName(8, "(682).png");
            this.IconList.Images.SetKeyName(9, "(741).png");
            this.IconList.Images.SetKeyName(10, "(752).png");
            this.IconList.Images.SetKeyName(11, "(855).png");
            this.IconList.Images.SetKeyName(12, "(912).png");
            this.IconList.Images.SetKeyName(13, "ai (1).png");
            this.IconList.Images.SetKeyName(14, "ai (2).png");
            this.IconList.Images.SetKeyName(15, "ai (3).png");
            this.IconList.Images.SetKeyName(16, "ai (4).png");
            this.IconList.Images.SetKeyName(17, "ai (5).png");
            this.IconList.Images.SetKeyName(18, "ai (6).png");
            this.IconList.Images.SetKeyName(19, "ai (7).png");
            this.IconList.Images.SetKeyName(20, "ai (8).png");
            this.IconList.Images.SetKeyName(21, "ai (9).png");
            this.IconList.Images.SetKeyName(22, "ai (10).png");
            this.IconList.Images.SetKeyName(23, "ai (11).png");
            this.IconList.Images.SetKeyName(24, "ai (12).png");
            this.IconList.Images.SetKeyName(25, "analysis (1).png");
            this.IconList.Images.SetKeyName(26, "analysis (2).png");
            this.IconList.Images.SetKeyName(27, "analysis (3).png");
            this.IconList.Images.SetKeyName(28, "analysis (4).png");
            this.IconList.Images.SetKeyName(29, "analysis (5).png");
            this.IconList.Images.SetKeyName(30, "analysis (6).png");
            this.IconList.Images.SetKeyName(31, "analysis (7).png");
            this.IconList.Images.SetKeyName(32, "analysis (8).png");
            this.IconList.Images.SetKeyName(33, "analysis (9).png");
            this.IconList.Images.SetKeyName(34, "analysis (10).png");
            this.IconList.Images.SetKeyName(35, "animals (1).png");
            this.IconList.Images.SetKeyName(36, "animals (2).png");
            this.IconList.Images.SetKeyName(37, "animals (3).png");
            this.IconList.Images.SetKeyName(38, "animals (4).png");
            this.IconList.Images.SetKeyName(39, "animals (5).png");
            this.IconList.Images.SetKeyName(40, "animals (6).png");
            this.IconList.Images.SetKeyName(41, "animals (7).png");
            this.IconList.Images.SetKeyName(42, "animals (8).png");
            this.IconList.Images.SetKeyName(43, "animals (9).png");
            this.IconList.Images.SetKeyName(44, "animals (10).png");
            this.IconList.Images.SetKeyName(45, "animals (11).png");
            this.IconList.Images.SetKeyName(46, "animals (12).png");
            this.IconList.Images.SetKeyName(47, "animals (13).png");
            this.IconList.Images.SetKeyName(48, "animals (14).png");
            this.IconList.Images.SetKeyName(49, "animals (15).png");
            this.IconList.Images.SetKeyName(50, "animals (16).png");
            this.IconList.Images.SetKeyName(51, "animals (17).png");
            this.IconList.Images.SetKeyName(52, "animals (18).png");
            this.IconList.Images.SetKeyName(53, "animals (19).png");
            this.IconList.Images.SetKeyName(54, "animals (20).png");
            this.IconList.Images.SetKeyName(55, "animals (21).png");
            this.IconList.Images.SetKeyName(56, "animals (22).png");
            this.IconList.Images.SetKeyName(57, "animals (23).png");
            this.IconList.Images.SetKeyName(58, "animals (24).png");
            this.IconList.Images.SetKeyName(59, "animals (25).png");
            this.IconList.Images.SetKeyName(60, "animals (26).png");
            this.IconList.Images.SetKeyName(61, "at (1).png");
            this.IconList.Images.SetKeyName(62, "at (2).png");
            this.IconList.Images.SetKeyName(63, "at (3).png");
            this.IconList.Images.SetKeyName(64, "at (4).png");
            this.IconList.Images.SetKeyName(65, "at (5).png");
            this.IconList.Images.SetKeyName(66, "at (6).png");
            this.IconList.Images.SetKeyName(67, "chemistry (1).png");
            this.IconList.Images.SetKeyName(68, "chemistry (2).png");
            this.IconList.Images.SetKeyName(69, "chemistry (3).png");
            this.IconList.Images.SetKeyName(70, "chemistry (4).png");
            this.IconList.Images.SetKeyName(71, "chemistry (5).png");
            this.IconList.Images.SetKeyName(72, "chemistry (6).png");
            this.IconList.Images.SetKeyName(73, "chemistry (7).png");
            this.IconList.Images.SetKeyName(74, "chemistry (8).png");
            this.IconList.Images.SetKeyName(75, "chemistry (9).png");
            this.IconList.Images.SetKeyName(76, "chemistry (10).png");
            this.IconList.Images.SetKeyName(77, "chemistry (11).png");
            this.IconList.Images.SetKeyName(78, "chemistry (12).png");
            this.IconList.Images.SetKeyName(79, "chemistry (13).png");
            this.IconList.Images.SetKeyName(80, "chemistry (14).png");
            this.IconList.Images.SetKeyName(81, "chemistry (15).png");
            this.IconList.Images.SetKeyName(82, "chemistry (16).png");
            this.IconList.Images.SetKeyName(83, "chemistry (17).png");
            this.IconList.Images.SetKeyName(84, "chemistry (18).png");
            this.IconList.Images.SetKeyName(85, "chemistry (19).png");
            this.IconList.Images.SetKeyName(86, "chemistry (20).png");
            this.IconList.Images.SetKeyName(87, "chemistry (21).png");
            this.IconList.Images.SetKeyName(88, "chemistry (22).png");
            this.IconList.Images.SetKeyName(89, "chemistry (23).png");
            this.IconList.Images.SetKeyName(90, "chemistry (24).png");
            this.IconList.Images.SetKeyName(91, "chemistry (25).png");
            this.IconList.Images.SetKeyName(92, "chemistry (26).png");
            this.IconList.Images.SetKeyName(93, "chemistry (27).png");
            this.IconList.Images.SetKeyName(94, "chemistry (28).png");
            this.IconList.Images.SetKeyName(95, "chemistry (29).png");
            this.IconList.Images.SetKeyName(96, "chemistry (30).png");
            this.IconList.Images.SetKeyName(97, "chemistry (31).png");
            this.IconList.Images.SetKeyName(98, "chemistry (32).png");
            this.IconList.Images.SetKeyName(99, "chemistry (33).png");
            this.IconList.Images.SetKeyName(100, "chemistry (34).png");
            this.IconList.Images.SetKeyName(101, "chemistry (35).png");
            this.IconList.Images.SetKeyName(102, "chemistry (36).png");
            this.IconList.Images.SetKeyName(103, "chemistry (37).png");
            this.IconList.Images.SetKeyName(104, "chemistry (38).png");
            this.IconList.Images.SetKeyName(105, "chemistry (39).png");
            this.IconList.Images.SetKeyName(106, "chemistry (40).png");
            this.IconList.Images.SetKeyName(107, "chemistry (41).png");
            this.IconList.Images.SetKeyName(108, "chemistry (42).png");
            this.IconList.Images.SetKeyName(109, "code (1).png");
            this.IconList.Images.SetKeyName(110, "code (2).png");
            this.IconList.Images.SetKeyName(111, "code (3).png");
            this.IconList.Images.SetKeyName(112, "code (4).png");
            this.IconList.Images.SetKeyName(113, "code (5).png");
            this.IconList.Images.SetKeyName(114, "code (6).png");
            this.IconList.Images.SetKeyName(115, "code (7).png");
            this.IconList.Images.SetKeyName(116, "code (8).png");
            this.IconList.Images.SetKeyName(117, "code (9).png");
            this.IconList.Images.SetKeyName(118, "code (10).png");
            this.IconList.Images.SetKeyName(119, "code (11).png");
            this.IconList.Images.SetKeyName(120, "code (12).png");
            this.IconList.Images.SetKeyName(121, "code (13).png");
            this.IconList.Images.SetKeyName(122, "code (14).png");
            this.IconList.Images.SetKeyName(123, "code (15).png");
            this.IconList.Images.SetKeyName(124, "code (16).png");
            this.IconList.Images.SetKeyName(125, "code (17).png");
            this.IconList.Images.SetKeyName(126, "code (18).png");
            this.IconList.Images.SetKeyName(127, "code (19).png");
            this.IconList.Images.SetKeyName(128, "code (20).png");
            this.IconList.Images.SetKeyName(129, "code (21).png");
            this.IconList.Images.SetKeyName(130, "code (22).png");
            this.IconList.Images.SetKeyName(131, "code (23).png");
            this.IconList.Images.SetKeyName(132, "code (24).png");
            this.IconList.Images.SetKeyName(133, "code (25).png");
            this.IconList.Images.SetKeyName(134, "code (26).png");
            this.IconList.Images.SetKeyName(135, "code (27).png");
            this.IconList.Images.SetKeyName(136, "code (28).png");
            this.IconList.Images.SetKeyName(137, "code (29).png");
            this.IconList.Images.SetKeyName(138, "code (30).png");
            this.IconList.Images.SetKeyName(139, "comm (1).png");
            this.IconList.Images.SetKeyName(140, "comm (2).png");
            this.IconList.Images.SetKeyName(141, "commerce (1).png");
            this.IconList.Images.SetKeyName(142, "commerce (2).png");
            this.IconList.Images.SetKeyName(143, "commerce (3).png");
            this.IconList.Images.SetKeyName(144, "commerce (4).png");
            this.IconList.Images.SetKeyName(145, "commerce (5).png");
            this.IconList.Images.SetKeyName(146, "commerce (6).png");
            this.IconList.Images.SetKeyName(147, "commerce (7).png");
            this.IconList.Images.SetKeyName(148, "commerce (8).png");
            this.IconList.Images.SetKeyName(149, "commerce (9).png");
            this.IconList.Images.SetKeyName(150, "edu (1).png");
            this.IconList.Images.SetKeyName(151, "edu (2).png");
            this.IconList.Images.SetKeyName(152, "edu (3).png");
            this.IconList.Images.SetKeyName(153, "edu (4).png");
            this.IconList.Images.SetKeyName(154, "edu (5).png");
            this.IconList.Images.SetKeyName(155, "edu (6).png");
            this.IconList.Images.SetKeyName(156, "edu (7).png");
            this.IconList.Images.SetKeyName(157, "edu (8).png");
            this.IconList.Images.SetKeyName(158, "edu (9).png");
            this.IconList.Images.SetKeyName(159, "edu (10).png");
            this.IconList.Images.SetKeyName(160, "edu (11).png");
            this.IconList.Images.SetKeyName(161, "edu (12).png");
            this.IconList.Images.SetKeyName(162, "edu (13).png");
            this.IconList.Images.SetKeyName(163, "electronics (1).png");
            this.IconList.Images.SetKeyName(164, "electronics (2).png");
            this.IconList.Images.SetKeyName(165, "electronics (3).png");
            this.IconList.Images.SetKeyName(166, "electronics (4).png");
            this.IconList.Images.SetKeyName(167, "electronics (5).png");
            this.IconList.Images.SetKeyName(168, "electronics (6).png");
            this.IconList.Images.SetKeyName(169, "electronics (7).png");
            this.IconList.Images.SetKeyName(170, "electronics (8).png");
            this.IconList.Images.SetKeyName(171, "electronics (9).png");
            this.IconList.Images.SetKeyName(172, "electronics (10).png");
            this.IconList.Images.SetKeyName(173, "electronics (11).png");
            this.IconList.Images.SetKeyName(174, "electronics (12).png");
            this.IconList.Images.SetKeyName(175, "electronics (13).png");
            this.IconList.Images.SetKeyName(176, "electronics (14).png");
            this.IconList.Images.SetKeyName(177, "electronics (15).png");
            this.IconList.Images.SetKeyName(178, "electronics (16).png");
            this.IconList.Images.SetKeyName(179, "electronics (17).png");
            this.IconList.Images.SetKeyName(180, "electronics (18).png");
            this.IconList.Images.SetKeyName(181, "electronics (19).png");
            this.IconList.Images.SetKeyName(182, "electronics (20).png");
            this.IconList.Images.SetKeyName(183, "electronics (21).png");
            this.IconList.Images.SetKeyName(184, "electronics (22).png");
            this.IconList.Images.SetKeyName(185, "electronics (23).png");
            this.IconList.Images.SetKeyName(186, "electronics (24).png");
            this.IconList.Images.SetKeyName(187, "electronics (25).png");
            this.IconList.Images.SetKeyName(188, "electronics (26).png");
            this.IconList.Images.SetKeyName(189, "electronics (27).png");
            this.IconList.Images.SetKeyName(190, "electronics (28).png");
            this.IconList.Images.SetKeyName(191, "electronics (29).png");
            this.IconList.Images.SetKeyName(192, "electronics (30).png");
            this.IconList.Images.SetKeyName(193, "electronics (31).png");
            this.IconList.Images.SetKeyName(194, "electronics (32).png");
            this.IconList.Images.SetKeyName(195, "eng (1).png");
            this.IconList.Images.SetKeyName(196, "eng (2).png");
            this.IconList.Images.SetKeyName(197, "eng (3).png");
            this.IconList.Images.SetKeyName(198, "eng (4).png");
            this.IconList.Images.SetKeyName(199, "eng (5).png");
            this.IconList.Images.SetKeyName(200, "eng (6).png");
            this.IconList.Images.SetKeyName(201, "eng (7).png");
            this.IconList.Images.SetKeyName(202, "genetics (1).png");
            this.IconList.Images.SetKeyName(203, "genetics (2).png");
            this.IconList.Images.SetKeyName(204, "genetics (3).png");
            this.IconList.Images.SetKeyName(205, "genetics (4).png");
            this.IconList.Images.SetKeyName(206, "genetics (5).png");
            this.IconList.Images.SetKeyName(207, "genetics (6).png");
            this.IconList.Images.SetKeyName(208, "genetics (7).png");
            this.IconList.Images.SetKeyName(209, "genetics (8).png");
            this.IconList.Images.SetKeyName(210, "genetics (9).png");
            this.IconList.Images.SetKeyName(211, "genetics (10).png");
            this.IconList.Images.SetKeyName(212, "genetics (11).png");
            this.IconList.Images.SetKeyName(213, "genetics (12).png");
            this.IconList.Images.SetKeyName(214, "genetics (13).png");
            this.IconList.Images.SetKeyName(215, "genetics (14).png");
            this.IconList.Images.SetKeyName(216, "genetics (15).png");
            this.IconList.Images.SetKeyName(217, "genetics (16).png");
            this.IconList.Images.SetKeyName(218, "genetics (17).png");
            this.IconList.Images.SetKeyName(219, "genetics (18).png");
            this.IconList.Images.SetKeyName(220, "genetics (19).png");
            this.IconList.Images.SetKeyName(221, "genetics (20).png");
            this.IconList.Images.SetKeyName(222, "genetics (21).png");
            this.IconList.Images.SetKeyName(223, "genetics (22).png");
            this.IconList.Images.SetKeyName(224, "genetics (23).png");
            this.IconList.Images.SetKeyName(225, "genetics (24).png");
            this.IconList.Images.SetKeyName(226, "genetics (25).png");
            this.IconList.Images.SetKeyName(227, "genetics (26).png");
            this.IconList.Images.SetKeyName(228, "genetics (27).png");
            this.IconList.Images.SetKeyName(229, "genetics (28).png");
            this.IconList.Images.SetKeyName(230, "genetics (29).png");
            this.IconList.Images.SetKeyName(231, "genetics (30).png");
            this.IconList.Images.SetKeyName(232, "genetics (31).png");
            this.IconList.Images.SetKeyName(233, "genetics (32).png");
            this.IconList.Images.SetKeyName(234, "genetics (33).png");
            this.IconList.Images.SetKeyName(235, "genetics (34).png");
            this.IconList.Images.SetKeyName(236, "genetics (35).png");
            this.IconList.Images.SetKeyName(237, "genetics (36).png");
            this.IconList.Images.SetKeyName(238, "genetics (37).png");
            this.IconList.Images.SetKeyName(239, "genetics (38).png");
            this.IconList.Images.SetKeyName(240, "genetics (39).png");
            this.IconList.Images.SetKeyName(241, "genetics (40).png");
            this.IconList.Images.SetKeyName(242, "genetics (41).png");
            this.IconList.Images.SetKeyName(243, "genetics (42).png");
            this.IconList.Images.SetKeyName(244, "genetics (43).png");
            this.IconList.Images.SetKeyName(245, "genetics (44).png");
            this.IconList.Images.SetKeyName(246, "genetics (45).png");
            this.IconList.Images.SetKeyName(247, "genetics (46).png");
            this.IconList.Images.SetKeyName(248, "genetics (47).png");
            this.IconList.Images.SetKeyName(249, "genetics (48).png");
            this.IconList.Images.SetKeyName(250, "genetics (49).png");
            this.IconList.Images.SetKeyName(251, "genetics (50).png");
            this.IconList.Images.SetKeyName(252, "genetics (51).png");
            this.IconList.Images.SetKeyName(253, "genetics (52).png");
            this.IconList.Images.SetKeyName(254, "genetics (53).png");
            this.IconList.Images.SetKeyName(255, "genetics (54).png");
            this.IconList.Images.SetKeyName(256, "genetics (55).png");
            this.IconList.Images.SetKeyName(257, "genetics (56).png");
            this.IconList.Images.SetKeyName(258, "hazard (1).png");
            this.IconList.Images.SetKeyName(259, "hazard (2).png");
            this.IconList.Images.SetKeyName(260, "hazard (3).png");
            this.IconList.Images.SetKeyName(261, "hazard (4).png");
            this.IconList.Images.SetKeyName(262, "hazard (5).png");
            this.IconList.Images.SetKeyName(263, "hazard (6).png");
            this.IconList.Images.SetKeyName(264, "hazard (7).png");
            this.IconList.Images.SetKeyName(265, "hazard (8).png");
            this.IconList.Images.SetKeyName(266, "hazard (9).png");
            this.IconList.Images.SetKeyName(267, "hazard (10).png");
            this.IconList.Images.SetKeyName(268, "hazard (11).png");
            this.IconList.Images.SetKeyName(269, "hazard (12).png");
            this.IconList.Images.SetKeyName(270, "hazard (13).png");
            this.IconList.Images.SetKeyName(271, "hazard (14).png");
            this.IconList.Images.SetKeyName(272, "hazard (15).png");
            this.IconList.Images.SetKeyName(273, "hazard (16).png");
            this.IconList.Images.SetKeyName(274, "hm (1).png");
            this.IconList.Images.SetKeyName(275, "hm (2).png");
            this.IconList.Images.SetKeyName(276, "hm (3).png");
            this.IconList.Images.SetKeyName(277, "hm (4).png");
            this.IconList.Images.SetKeyName(278, "hm (5).png");
            this.IconList.Images.SetKeyName(279, "hm (6).png");
            this.IconList.Images.SetKeyName(280, "hm (7).png");
            this.IconList.Images.SetKeyName(281, "humanities (1).png");
            this.IconList.Images.SetKeyName(282, "humanities (2).png");
            this.IconList.Images.SetKeyName(283, "humanities (3).png");
            this.IconList.Images.SetKeyName(284, "humanities (4).png");
            this.IconList.Images.SetKeyName(285, "humanities (5).png");
            this.IconList.Images.SetKeyName(286, "humanities (6).png");
            this.IconList.Images.SetKeyName(287, "humanities (7).png");
            this.IconList.Images.SetKeyName(288, "humanities (8).png");
            this.IconList.Images.SetKeyName(289, "humanities (9).png");
            this.IconList.Images.SetKeyName(290, "humanities (10).png");
            this.IconList.Images.SetKeyName(291, "humanities (11).png");
            this.IconList.Images.SetKeyName(292, "humanities (12).png");
            this.IconList.Images.SetKeyName(293, "humanities (13).png");
            this.IconList.Images.SetKeyName(294, "humanities (14).png");
            this.IconList.Images.SetKeyName(295, "humanities (15).png");
            this.IconList.Images.SetKeyName(296, "humanities (16).png");
            this.IconList.Images.SetKeyName(297, "humanities (17).png");
            this.IconList.Images.SetKeyName(298, "humanities (18).png");
            this.IconList.Images.SetKeyName(299, "humanities (19).png");
            this.IconList.Images.SetKeyName(300, "humanities (20).png");
            this.IconList.Images.SetKeyName(301, "humanities (21).png");
            this.IconList.Images.SetKeyName(302, "humanities (22).png");
            this.IconList.Images.SetKeyName(303, "humanities (23).png");
            this.IconList.Images.SetKeyName(304, "humanities (24).png");
            this.IconList.Images.SetKeyName(305, "humanities (25).png");
            this.IconList.Images.SetKeyName(306, "humanities (26).png");
            this.IconList.Images.SetKeyName(307, "humanities (27).png");
            this.IconList.Images.SetKeyName(308, "humanities (28).png");
            this.IconList.Images.SetKeyName(309, "humanities (29).png");
            this.IconList.Images.SetKeyName(310, "humanities (30).png");
            this.IconList.Images.SetKeyName(311, "humanities (31).png");
            this.IconList.Images.SetKeyName(312, "humanities (32).png");
            this.IconList.Images.SetKeyName(313, "humanities (33).png");
            this.IconList.Images.SetKeyName(314, "humanities (34).png");
            this.IconList.Images.SetKeyName(315, "humanities (35).png");
            this.IconList.Images.SetKeyName(316, "humanities (36).png");
            this.IconList.Images.SetKeyName(317, "humanities (37).png");
            this.IconList.Images.SetKeyName(318, "humanities (38).png");
            this.IconList.Images.SetKeyName(319, "humanities (39).png");
            this.IconList.Images.SetKeyName(320, "law (1).png");
            this.IconList.Images.SetKeyName(321, "law (2).png");
            this.IconList.Images.SetKeyName(322, "law (3).png");
            this.IconList.Images.SetKeyName(323, "law (4).png");
            this.IconList.Images.SetKeyName(324, "law (5).png");
            this.IconList.Images.SetKeyName(325, "law (6).png");
            this.IconList.Images.SetKeyName(326, "law (7).png");
            this.IconList.Images.SetKeyName(327, "law (8).png");
            this.IconList.Images.SetKeyName(328, "law (9).png");
            this.IconList.Images.SetKeyName(329, "law (10).png");
            this.IconList.Images.SetKeyName(330, "law (11).png");
            this.IconList.Images.SetKeyName(331, "law (12).png");
            this.IconList.Images.SetKeyName(332, "law (13).png");
            this.IconList.Images.SetKeyName(333, "law (14).png");
            this.IconList.Images.SetKeyName(334, "law (15).png");
            this.IconList.Images.SetKeyName(335, "law (16).png");
            this.IconList.Images.SetKeyName(336, "lit (1).png");
            this.IconList.Images.SetKeyName(337, "lit (2).png");
            this.IconList.Images.SetKeyName(338, "lit (3).png");
            this.IconList.Images.SetKeyName(339, "mus (1).png");
            this.IconList.Images.SetKeyName(340, "mus (2).png");
            this.IconList.Images.SetKeyName(341, "mus (3).png");
            this.IconList.Images.SetKeyName(342, "mus (4).png");
            this.IconList.Images.SetKeyName(343, "mus (5).png");
            this.IconList.Images.SetKeyName(344, "mus (6).png");
            this.IconList.Images.SetKeyName(345, "phsyc (1).png");
            this.IconList.Images.SetKeyName(346, "phsyc (2).png");
            this.IconList.Images.SetKeyName(347, "phsyc (3).png");
            this.IconList.Images.SetKeyName(348, "phsyc (4).png");
            this.IconList.Images.SetKeyName(349, "phsyc (5).png");
            this.IconList.Images.SetKeyName(350, "phsyc (6).png");
            this.IconList.Images.SetKeyName(351, "phsyc (7).png");
            this.IconList.Images.SetKeyName(352, "phsyc (8).png");
            this.IconList.Images.SetKeyName(353, "phsyc (9).png");
            this.IconList.Images.SetKeyName(354, "phsyc (10).png");
            this.IconList.Images.SetKeyName(355, "phsyc (11).png");
            this.IconList.Images.SetKeyName(356, "phsyc (12).png");
            this.IconList.Images.SetKeyName(357, "phsyc (13).png");
            this.IconList.Images.SetKeyName(358, "phsyc (15).png");
            this.IconList.Images.SetKeyName(359, "phsyc (16).png");
            this.IconList.Images.SetKeyName(360, "security (1).png");
            this.IconList.Images.SetKeyName(361, "security (2).png");
            this.IconList.Images.SetKeyName(362, "security (3).png");
            this.IconList.Images.SetKeyName(363, "security (4).png");
            this.IconList.Images.SetKeyName(364, "security (5).png");
            this.IconList.Images.SetKeyName(365, "theater (1).png");
            this.IconList.Images.SetKeyName(366, "theater (2).png");
            this.IconList.Images.SetKeyName(367, "theater (3).png");
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
        private System.Windows.Forms.ToolStripMenuItem exportIconsToolStripMenuItem;
    }
}

