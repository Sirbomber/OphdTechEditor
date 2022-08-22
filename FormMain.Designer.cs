
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
            this.IconList.Images.SetKeyName(0, "ai (1).png");
            this.IconList.Images.SetKeyName(1, "ai (2).png");
            this.IconList.Images.SetKeyName(2, "ai (3).png");
            this.IconList.Images.SetKeyName(3, "ai (4).png");
            this.IconList.Images.SetKeyName(4, "ai (5).png");
            this.IconList.Images.SetKeyName(5, "ai (6).png");
            this.IconList.Images.SetKeyName(6, "ai (7).png");
            this.IconList.Images.SetKeyName(7, "ai (8).png");
            this.IconList.Images.SetKeyName(8, "ai (9).png");
            this.IconList.Images.SetKeyName(9, "ai (10).png");
            this.IconList.Images.SetKeyName(10, "ai (11).png");
            this.IconList.Images.SetKeyName(11, "ai (12).png");
            this.IconList.Images.SetKeyName(12, "analysis (1).png");
            this.IconList.Images.SetKeyName(13, "analysis (2).png");
            this.IconList.Images.SetKeyName(14, "analysis (3).png");
            this.IconList.Images.SetKeyName(15, "analysis (4).png");
            this.IconList.Images.SetKeyName(16, "analysis (5).png");
            this.IconList.Images.SetKeyName(17, "analysis (6).png");
            this.IconList.Images.SetKeyName(18, "analysis (7).png");
            this.IconList.Images.SetKeyName(19, "analysis (8).png");
            this.IconList.Images.SetKeyName(20, "analysis (9).png");
            this.IconList.Images.SetKeyName(21, "analysis (10).png");
            this.IconList.Images.SetKeyName(22, "analytics (1).png");
            this.IconList.Images.SetKeyName(23, "analytics (2).png");
            this.IconList.Images.SetKeyName(24, "analytics (3).png");
            this.IconList.Images.SetKeyName(25, "analytics (4).png");
            this.IconList.Images.SetKeyName(26, "analytics (5).png");
            this.IconList.Images.SetKeyName(27, "analytics (6).png");
            this.IconList.Images.SetKeyName(28, "analytics (7).png");
            this.IconList.Images.SetKeyName(29, "analytics (8).png");
            this.IconList.Images.SetKeyName(30, "analytics (9).png");
            this.IconList.Images.SetKeyName(31, "analytics (10).png");
            this.IconList.Images.SetKeyName(32, "analytics (11).png");
            this.IconList.Images.SetKeyName(33, "analytics (12).png");
            this.IconList.Images.SetKeyName(34, "analytics (13).png");
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
            this.IconList.Images.SetKeyName(320, "industry (1).png");
            this.IconList.Images.SetKeyName(321, "industry (99).png");
            this.IconList.Images.SetKeyName(322, "industry (100).png");
            this.IconList.Images.SetKeyName(323, "industry (101).png");
            this.IconList.Images.SetKeyName(324, "industry (102).png");
            this.IconList.Images.SetKeyName(325, "industry (103).png");
            this.IconList.Images.SetKeyName(326, "industry (104).png");
            this.IconList.Images.SetKeyName(327, "industry (105).png");
            this.IconList.Images.SetKeyName(328, "industry (106).png");
            this.IconList.Images.SetKeyName(329, "industry (107).png");
            this.IconList.Images.SetKeyName(330, "industry (108).png");
            this.IconList.Images.SetKeyName(331, "industry (109).png");
            this.IconList.Images.SetKeyName(332, "industry (110).png");
            this.IconList.Images.SetKeyName(333, "industry (111).png");
            this.IconList.Images.SetKeyName(334, "industry (112).png");
            this.IconList.Images.SetKeyName(335, "industry (113).png");
            this.IconList.Images.SetKeyName(336, "industry (114).png");
            this.IconList.Images.SetKeyName(337, "industry (115).png");
            this.IconList.Images.SetKeyName(338, "industry (116).png");
            this.IconList.Images.SetKeyName(339, "industry (117).png");
            this.IconList.Images.SetKeyName(340, "industry (118).png");
            this.IconList.Images.SetKeyName(341, "industry (119).png");
            this.IconList.Images.SetKeyName(342, "industry (120).png");
            this.IconList.Images.SetKeyName(343, "industry (121).png");
            this.IconList.Images.SetKeyName(344, "industry (122).png");
            this.IconList.Images.SetKeyName(345, "industry (123).png");
            this.IconList.Images.SetKeyName(346, "industry (124).png");
            this.IconList.Images.SetKeyName(347, "industry (125).png");
            this.IconList.Images.SetKeyName(348, "industry (126).png");
            this.IconList.Images.SetKeyName(349, "industry (127).png");
            this.IconList.Images.SetKeyName(350, "industry (128).png");
            this.IconList.Images.SetKeyName(351, "industry (129).png");
            this.IconList.Images.SetKeyName(352, "industry (130).png");
            this.IconList.Images.SetKeyName(353, "industry (131).png");
            this.IconList.Images.SetKeyName(354, "industry (132).png");
            this.IconList.Images.SetKeyName(355, "industry (133).png");
            this.IconList.Images.SetKeyName(356, "industry (134).png");
            this.IconList.Images.SetKeyName(357, "industry (135).png");
            this.IconList.Images.SetKeyName(358, "industry (136).png");
            this.IconList.Images.SetKeyName(359, "industry (137).png");
            this.IconList.Images.SetKeyName(360, "industry (138).png");
            this.IconList.Images.SetKeyName(361, "industry (139).png");
            this.IconList.Images.SetKeyName(362, "industry (140).png");
            this.IconList.Images.SetKeyName(363, "industry (141).png");
            this.IconList.Images.SetKeyName(364, "industry (142).png");
            this.IconList.Images.SetKeyName(365, "industry (143).png");
            this.IconList.Images.SetKeyName(366, "industry (144).png");
            this.IconList.Images.SetKeyName(367, "industry (145).png");
            this.IconList.Images.SetKeyName(368, "industry (146).png");
            this.IconList.Images.SetKeyName(369, "industry (147).png");
            this.IconList.Images.SetKeyName(370, "industry (148).png");
            this.IconList.Images.SetKeyName(371, "industry (149).png");
            this.IconList.Images.SetKeyName(372, "industry (150).png");
            this.IconList.Images.SetKeyName(373, "industry (151).png");
            this.IconList.Images.SetKeyName(374, "industry (152).png");
            this.IconList.Images.SetKeyName(375, "industry (153).png");
            this.IconList.Images.SetKeyName(376, "industry (154).png");
            this.IconList.Images.SetKeyName(377, "industry (155).png");
            this.IconList.Images.SetKeyName(378, "industry (156).png");
            this.IconList.Images.SetKeyName(379, "industry (157).png");
            this.IconList.Images.SetKeyName(380, "industry (158).png");
            this.IconList.Images.SetKeyName(381, "industry (159).png");
            this.IconList.Images.SetKeyName(382, "industry (160).png");
            this.IconList.Images.SetKeyName(383, "industry (161).png");
            this.IconList.Images.SetKeyName(384, "industry (162).png");
            this.IconList.Images.SetKeyName(385, "industry (163).png");
            this.IconList.Images.SetKeyName(386, "industry (164).png");
            this.IconList.Images.SetKeyName(387, "industry (165).png");
            this.IconList.Images.SetKeyName(388, "industry (166).png");
            this.IconList.Images.SetKeyName(389, "industry (167).png");
            this.IconList.Images.SetKeyName(390, "industry (168).png");
            this.IconList.Images.SetKeyName(391, "industry (169).png");
            this.IconList.Images.SetKeyName(392, "industry (170).png");
            this.IconList.Images.SetKeyName(393, "industry (171).png");
            this.IconList.Images.SetKeyName(394, "industry (172).png");
            this.IconList.Images.SetKeyName(395, "industry (173).png");
            this.IconList.Images.SetKeyName(396, "industry (174).png");
            this.IconList.Images.SetKeyName(397, "industry (175).png");
            this.IconList.Images.SetKeyName(398, "industry (176).png");
            this.IconList.Images.SetKeyName(399, "industry (177).png");
            this.IconList.Images.SetKeyName(400, "industry (178).png");
            this.IconList.Images.SetKeyName(401, "industry (179).png");
            this.IconList.Images.SetKeyName(402, "industry (180).png");
            this.IconList.Images.SetKeyName(403, "industry (181).png");
            this.IconList.Images.SetKeyName(404, "industry (182).png");
            this.IconList.Images.SetKeyName(405, "industry (183).png");
            this.IconList.Images.SetKeyName(406, "industry (184).png");
            this.IconList.Images.SetKeyName(407, "industry (185).png");
            this.IconList.Images.SetKeyName(408, "industry (186).png");
            this.IconList.Images.SetKeyName(409, "industry (187).png");
            this.IconList.Images.SetKeyName(410, "industry (188).png");
            this.IconList.Images.SetKeyName(411, "industry (189).png");
            this.IconList.Images.SetKeyName(412, "industry (190).png");
            this.IconList.Images.SetKeyName(413, "industry (191).png");
            this.IconList.Images.SetKeyName(414, "industry (192).png");
            this.IconList.Images.SetKeyName(415, "industry (193).png");
            this.IconList.Images.SetKeyName(416, "industry (194).png");
            this.IconList.Images.SetKeyName(417, "industry (195).png");
            this.IconList.Images.SetKeyName(418, "industry (196).png");
            this.IconList.Images.SetKeyName(419, "industry (197).png");
            this.IconList.Images.SetKeyName(420, "industry (198).png");
            this.IconList.Images.SetKeyName(421, "industry (199).png");
            this.IconList.Images.SetKeyName(422, "industry (200).png");
            this.IconList.Images.SetKeyName(423, "law (1).png");
            this.IconList.Images.SetKeyName(424, "law (2).png");
            this.IconList.Images.SetKeyName(425, "law (3).png");
            this.IconList.Images.SetKeyName(426, "law (4).png");
            this.IconList.Images.SetKeyName(427, "law (5).png");
            this.IconList.Images.SetKeyName(428, "law (6).png");
            this.IconList.Images.SetKeyName(429, "law (7).png");
            this.IconList.Images.SetKeyName(430, "law (8).png");
            this.IconList.Images.SetKeyName(431, "law (9).png");
            this.IconList.Images.SetKeyName(432, "law (10).png");
            this.IconList.Images.SetKeyName(433, "law (11).png");
            this.IconList.Images.SetKeyName(434, "law (12).png");
            this.IconList.Images.SetKeyName(435, "law (13).png");
            this.IconList.Images.SetKeyName(436, "law (14).png");
            this.IconList.Images.SetKeyName(437, "law (15).png");
            this.IconList.Images.SetKeyName(438, "law (16).png");
            this.IconList.Images.SetKeyName(439, "lit (1).png");
            this.IconList.Images.SetKeyName(440, "lit (2).png");
            this.IconList.Images.SetKeyName(441, "lit (3).png");
            this.IconList.Images.SetKeyName(442, "Medicine (1).png");
            this.IconList.Images.SetKeyName(443, "Medicine (90).png");
            this.IconList.Images.SetKeyName(444, "Medicine (91).png");
            this.IconList.Images.SetKeyName(445, "Medicine (92).png");
            this.IconList.Images.SetKeyName(446, "Medicine (93).png");
            this.IconList.Images.SetKeyName(447, "Medicine (94).png");
            this.IconList.Images.SetKeyName(448, "Medicine (95).png");
            this.IconList.Images.SetKeyName(449, "Medicine (96).png");
            this.IconList.Images.SetKeyName(450, "Medicine (97).png");
            this.IconList.Images.SetKeyName(451, "Medicine (98).png");
            this.IconList.Images.SetKeyName(452, "Medicine (99).png");
            this.IconList.Images.SetKeyName(453, "Medicine (100).png");
            this.IconList.Images.SetKeyName(454, "Medicine (101).png");
            this.IconList.Images.SetKeyName(455, "Medicine (102).png");
            this.IconList.Images.SetKeyName(456, "Medicine (103).png");
            this.IconList.Images.SetKeyName(457, "Medicine (104).png");
            this.IconList.Images.SetKeyName(458, "Medicine (105).png");
            this.IconList.Images.SetKeyName(459, "Medicine (106).png");
            this.IconList.Images.SetKeyName(460, "Medicine (107).png");
            this.IconList.Images.SetKeyName(461, "Medicine (108).png");
            this.IconList.Images.SetKeyName(462, "Medicine (109).png");
            this.IconList.Images.SetKeyName(463, "Medicine (110).png");
            this.IconList.Images.SetKeyName(464, "Medicine (111).png");
            this.IconList.Images.SetKeyName(465, "Medicine (112).png");
            this.IconList.Images.SetKeyName(466, "Medicine (113).png");
            this.IconList.Images.SetKeyName(467, "Medicine (114).png");
            this.IconList.Images.SetKeyName(468, "Medicine (115).png");
            this.IconList.Images.SetKeyName(469, "Medicine (116).png");
            this.IconList.Images.SetKeyName(470, "Medicine (117).png");
            this.IconList.Images.SetKeyName(471, "Medicine (118).png");
            this.IconList.Images.SetKeyName(472, "Medicine (119).png");
            this.IconList.Images.SetKeyName(473, "Medicine (120).png");
            this.IconList.Images.SetKeyName(474, "Medicine (121).png");
            this.IconList.Images.SetKeyName(475, "Medicine (122).png");
            this.IconList.Images.SetKeyName(476, "Medicine (123).png");
            this.IconList.Images.SetKeyName(477, "Medicine (124).png");
            this.IconList.Images.SetKeyName(478, "Medicine (125).png");
            this.IconList.Images.SetKeyName(479, "Medicine (126).png");
            this.IconList.Images.SetKeyName(480, "Medicine (127).png");
            this.IconList.Images.SetKeyName(481, "Medicine (128).png");
            this.IconList.Images.SetKeyName(482, "Medicine (129).png");
            this.IconList.Images.SetKeyName(483, "Medicine (130).png");
            this.IconList.Images.SetKeyName(484, "Medicine (131).png");
            this.IconList.Images.SetKeyName(485, "Medicine (132).png");
            this.IconList.Images.SetKeyName(486, "Medicine (133).png");
            this.IconList.Images.SetKeyName(487, "Medicine (134).png");
            this.IconList.Images.SetKeyName(488, "Medicine (135).png");
            this.IconList.Images.SetKeyName(489, "Medicine (136).png");
            this.IconList.Images.SetKeyName(490, "Medicine (137).png");
            this.IconList.Images.SetKeyName(491, "Medicine (138).png");
            this.IconList.Images.SetKeyName(492, "Medicine (139).png");
            this.IconList.Images.SetKeyName(493, "Medicine (140).png");
            this.IconList.Images.SetKeyName(494, "Medicine (141).png");
            this.IconList.Images.SetKeyName(495, "Medicine (142).png");
            this.IconList.Images.SetKeyName(496, "Medicine (143).png");
            this.IconList.Images.SetKeyName(497, "Medicine (144).png");
            this.IconList.Images.SetKeyName(498, "Medicine (145).png");
            this.IconList.Images.SetKeyName(499, "Medicine (146).png");
            this.IconList.Images.SetKeyName(500, "Medicine (147).png");
            this.IconList.Images.SetKeyName(501, "Medicine (148).png");
            this.IconList.Images.SetKeyName(502, "Medicine (149).png");
            this.IconList.Images.SetKeyName(503, "Medicine (150).png");
            this.IconList.Images.SetKeyName(504, "Medicine (151).png");
            this.IconList.Images.SetKeyName(505, "Medicine (152).png");
            this.IconList.Images.SetKeyName(506, "Medicine (153).png");
            this.IconList.Images.SetKeyName(507, "Medicine (154).png");
            this.IconList.Images.SetKeyName(508, "Medicine (155).png");
            this.IconList.Images.SetKeyName(509, "Medicine (156).png");
            this.IconList.Images.SetKeyName(510, "Medicine (157).png");
            this.IconList.Images.SetKeyName(511, "Medicine (158).png");
            this.IconList.Images.SetKeyName(512, "Medicine (159).png");
            this.IconList.Images.SetKeyName(513, "Medicine (160).png");
            this.IconList.Images.SetKeyName(514, "Medicine (161).png");
            this.IconList.Images.SetKeyName(515, "Medicine (162).png");
            this.IconList.Images.SetKeyName(516, "Medicine (163).png");
            this.IconList.Images.SetKeyName(517, "Medicine (164).png");
            this.IconList.Images.SetKeyName(518, "Medicine (165).png");
            this.IconList.Images.SetKeyName(519, "Medicine (166).png");
            this.IconList.Images.SetKeyName(520, "Medicine (167).png");
            this.IconList.Images.SetKeyName(521, "Medicine (168).png");
            this.IconList.Images.SetKeyName(522, "Medicine (169).png");
            this.IconList.Images.SetKeyName(523, "Medicine (170).png");
            this.IconList.Images.SetKeyName(524, "Medicine (171).png");
            this.IconList.Images.SetKeyName(525, "Medicine (172).png");
            this.IconList.Images.SetKeyName(526, "Medicine (173).png");
            this.IconList.Images.SetKeyName(527, "Medicine (174).png");
            this.IconList.Images.SetKeyName(528, "Medicine (175).png");
            this.IconList.Images.SetKeyName(529, "Medicine (176).png");
            this.IconList.Images.SetKeyName(530, "Medicine (177).png");
            this.IconList.Images.SetKeyName(531, "Medicine (178).png");
            this.IconList.Images.SetKeyName(532, "microbiology (1).png");
            this.IconList.Images.SetKeyName(533, "microbiology (2).png");
            this.IconList.Images.SetKeyName(534, "microbiology (3).png");
            this.IconList.Images.SetKeyName(535, "microbiology (4).png");
            this.IconList.Images.SetKeyName(536, "microbiology (5).png");
            this.IconList.Images.SetKeyName(537, "microbiology (6).png");
            this.IconList.Images.SetKeyName(538, "microbiology (7).png");
            this.IconList.Images.SetKeyName(539, "microbiology (8).png");
            this.IconList.Images.SetKeyName(540, "microbiology (9).png");
            this.IconList.Images.SetKeyName(541, "microbiology (11).png");
            this.IconList.Images.SetKeyName(542, "microbiology (12).png");
            this.IconList.Images.SetKeyName(543, "microbiology (13).png");
            this.IconList.Images.SetKeyName(544, "microbiology (14).png");
            this.IconList.Images.SetKeyName(545, "microbiology (15).png");
            this.IconList.Images.SetKeyName(546, "microbiology (16).png");
            this.IconList.Images.SetKeyName(547, "microbiology (17).png");
            this.IconList.Images.SetKeyName(548, "microbiology (18).png");
            this.IconList.Images.SetKeyName(549, "microbiology (19).png");
            this.IconList.Images.SetKeyName(550, "microbiology (20).png");
            this.IconList.Images.SetKeyName(551, "microbiology (21).png");
            this.IconList.Images.SetKeyName(552, "microbiology (22).png");
            this.IconList.Images.SetKeyName(553, "microbiology (23).png");
            this.IconList.Images.SetKeyName(554, "microbiology (24).png");
            this.IconList.Images.SetKeyName(555, "microbiology (25).png");
            this.IconList.Images.SetKeyName(556, "microbiology (26).png");
            this.IconList.Images.SetKeyName(557, "microbiology (27).png");
            this.IconList.Images.SetKeyName(558, "microbiology (28).png");
            this.IconList.Images.SetKeyName(559, "microbiology (29).png");
            this.IconList.Images.SetKeyName(560, "microbiology (30).png");
            this.IconList.Images.SetKeyName(561, "microbiology (31).png");
            this.IconList.Images.SetKeyName(562, "microbiology (32).png");
            this.IconList.Images.SetKeyName(563, "microbiology (33).png");
            this.IconList.Images.SetKeyName(564, "microbiology (34).png");
            this.IconList.Images.SetKeyName(565, "microbiology (35).png");
            this.IconList.Images.SetKeyName(566, "microbiology (36).png");
            this.IconList.Images.SetKeyName(567, "microbiology (37).png");
            this.IconList.Images.SetKeyName(568, "microbiology (38).png");
            this.IconList.Images.SetKeyName(569, "microbiology (39).png");
            this.IconList.Images.SetKeyName(570, "microbiology (40).png");
            this.IconList.Images.SetKeyName(571, "microbiology (41).png");
            this.IconList.Images.SetKeyName(572, "microbiology (42).png");
            this.IconList.Images.SetKeyName(573, "microbiology (43).png");
            this.IconList.Images.SetKeyName(574, "molecules (1).png");
            this.IconList.Images.SetKeyName(575, "molecules (2).png");
            this.IconList.Images.SetKeyName(576, "molecules (3).png");
            this.IconList.Images.SetKeyName(577, "molecules (4).png");
            this.IconList.Images.SetKeyName(578, "molecules (5).png");
            this.IconList.Images.SetKeyName(579, "molecules (6).png");
            this.IconList.Images.SetKeyName(580, "molecules (7).png");
            this.IconList.Images.SetKeyName(581, "molecules (8).png");
            this.IconList.Images.SetKeyName(582, "molecules (9).png");
            this.IconList.Images.SetKeyName(583, "molecules (10).png");
            this.IconList.Images.SetKeyName(584, "molecules (11).png");
            this.IconList.Images.SetKeyName(585, "molecules (12).png");
            this.IconList.Images.SetKeyName(586, "molecules (13).png");
            this.IconList.Images.SetKeyName(587, "molecules (14).png");
            this.IconList.Images.SetKeyName(588, "molecules (15).png");
            this.IconList.Images.SetKeyName(589, "molecules (16).png");
            this.IconList.Images.SetKeyName(590, "molecules (17).png");
            this.IconList.Images.SetKeyName(591, "molecules (18).png");
            this.IconList.Images.SetKeyName(592, "molecules (19).png");
            this.IconList.Images.SetKeyName(593, "molecules (20).png");
            this.IconList.Images.SetKeyName(594, "molecules (21).png");
            this.IconList.Images.SetKeyName(595, "molecules (22).png");
            this.IconList.Images.SetKeyName(596, "molecules (23).png");
            this.IconList.Images.SetKeyName(597, "molecules (24).png");
            this.IconList.Images.SetKeyName(598, "molecules (25).png");
            this.IconList.Images.SetKeyName(599, "molecules (26).png");
            this.IconList.Images.SetKeyName(600, "molecules (27).png");
            this.IconList.Images.SetKeyName(601, "molecules (28).png");
            this.IconList.Images.SetKeyName(602, "molecules (29).png");
            this.IconList.Images.SetKeyName(603, "molecules (30).png");
            this.IconList.Images.SetKeyName(604, "molecules (31).png");
            this.IconList.Images.SetKeyName(605, "molecules (32).png");
            this.IconList.Images.SetKeyName(606, "molecules (33).png");
            this.IconList.Images.SetKeyName(607, "molecules (34).png");
            this.IconList.Images.SetKeyName(608, "mus (1).png");
            this.IconList.Images.SetKeyName(609, "mus (2).png");
            this.IconList.Images.SetKeyName(610, "mus (3).png");
            this.IconList.Images.SetKeyName(611, "mus (4).png");
            this.IconList.Images.SetKeyName(612, "mus (5).png");
            this.IconList.Images.SetKeyName(613, "mus (6).png");
            this.IconList.Images.SetKeyName(614, "phsyc (1).png");
            this.IconList.Images.SetKeyName(615, "phsyc (2).png");
            this.IconList.Images.SetKeyName(616, "phsyc (3).png");
            this.IconList.Images.SetKeyName(617, "phsyc (4).png");
            this.IconList.Images.SetKeyName(618, "phsyc (5).png");
            this.IconList.Images.SetKeyName(619, "phsyc (6).png");
            this.IconList.Images.SetKeyName(620, "phsyc (7).png");
            this.IconList.Images.SetKeyName(621, "phsyc (8).png");
            this.IconList.Images.SetKeyName(622, "phsyc (9).png");
            this.IconList.Images.SetKeyName(623, "phsyc (10).png");
            this.IconList.Images.SetKeyName(624, "phsyc (11).png");
            this.IconList.Images.SetKeyName(625, "phsyc (12).png");
            this.IconList.Images.SetKeyName(626, "phsyc (13).png");
            this.IconList.Images.SetKeyName(627, "phsyc (15).png");
            this.IconList.Images.SetKeyName(628, "phsyc (16).png");
            this.IconList.Images.SetKeyName(629, "planet (1).png");
            this.IconList.Images.SetKeyName(630, "planet (2).png");
            this.IconList.Images.SetKeyName(631, "planet (3).png");
            this.IconList.Images.SetKeyName(632, "planet (4).png");
            this.IconList.Images.SetKeyName(633, "planet (5).png");
            this.IconList.Images.SetKeyName(634, "planet (6).png");
            this.IconList.Images.SetKeyName(635, "planet (7).png");
            this.IconList.Images.SetKeyName(636, "planet (8).png");
            this.IconList.Images.SetKeyName(637, "planet (9).png");
            this.IconList.Images.SetKeyName(638, "planet (10).png");
            this.IconList.Images.SetKeyName(639, "planet (11).png");
            this.IconList.Images.SetKeyName(640, "planet (12).png");
            this.IconList.Images.SetKeyName(641, "planet (13).png");
            this.IconList.Images.SetKeyName(642, "planet (14).png");
            this.IconList.Images.SetKeyName(643, "planet (15).png");
            this.IconList.Images.SetKeyName(644, "planet (16).png");
            this.IconList.Images.SetKeyName(645, "planet (17).png");
            this.IconList.Images.SetKeyName(646, "planet (18).png");
            this.IconList.Images.SetKeyName(647, "planet (19).png");
            this.IconList.Images.SetKeyName(648, "planet (20).png");
            this.IconList.Images.SetKeyName(649, "planet (21).png");
            this.IconList.Images.SetKeyName(650, "planet (22).png");
            this.IconList.Images.SetKeyName(651, "planet (23).png");
            this.IconList.Images.SetKeyName(652, "planet (24).png");
            this.IconList.Images.SetKeyName(653, "planet (25).png");
            this.IconList.Images.SetKeyName(654, "planet (26).png");
            this.IconList.Images.SetKeyName(655, "planet (27).png");
            this.IconList.Images.SetKeyName(656, "planet (28).png");
            this.IconList.Images.SetKeyName(657, "planet (29).png");
            this.IconList.Images.SetKeyName(658, "planet (30).png");
            this.IconList.Images.SetKeyName(659, "planet (31).png");
            this.IconList.Images.SetKeyName(660, "planet (32).png");
            this.IconList.Images.SetKeyName(661, "plant (1).png");
            this.IconList.Images.SetKeyName(662, "plant (2).png");
            this.IconList.Images.SetKeyName(663, "plant (3).png");
            this.IconList.Images.SetKeyName(664, "plant (4).png");
            this.IconList.Images.SetKeyName(665, "plant (5).png");
            this.IconList.Images.SetKeyName(666, "plant (6).png");
            this.IconList.Images.SetKeyName(667, "plant (7).png");
            this.IconList.Images.SetKeyName(668, "plant (8).png");
            this.IconList.Images.SetKeyName(669, "plant (9).png");
            this.IconList.Images.SetKeyName(670, "plant (10).png");
            this.IconList.Images.SetKeyName(671, "plant (11).png");
            this.IconList.Images.SetKeyName(672, "plant (12).png");
            this.IconList.Images.SetKeyName(673, "plant (13).png");
            this.IconList.Images.SetKeyName(674, "plant (14).png");
            this.IconList.Images.SetKeyName(675, "plant (15).png");
            this.IconList.Images.SetKeyName(676, "plant (16).png");
            this.IconList.Images.SetKeyName(677, "plant (17).png");
            this.IconList.Images.SetKeyName(678, "plant (18).png");
            this.IconList.Images.SetKeyName(679, "plant (19).png");
            this.IconList.Images.SetKeyName(680, "plant (20).png");
            this.IconList.Images.SetKeyName(681, "plant (21).png");
            this.IconList.Images.SetKeyName(682, "plant (22).png");
            this.IconList.Images.SetKeyName(683, "plant (23).png");
            this.IconList.Images.SetKeyName(684, "plant (24).png");
            this.IconList.Images.SetKeyName(685, "plant (25).png");
            this.IconList.Images.SetKeyName(686, "plant (26).png");
            this.IconList.Images.SetKeyName(687, "plant (27).png");
            this.IconList.Images.SetKeyName(688, "plant (28).png");
            this.IconList.Images.SetKeyName(689, "plant (29).png");
            this.IconList.Images.SetKeyName(690, "plant (30).png");
            this.IconList.Images.SetKeyName(691, "plant (31).png");
            this.IconList.Images.SetKeyName(692, "plant (32).png");
            this.IconList.Images.SetKeyName(693, "plant (33).png");
            this.IconList.Images.SetKeyName(694, "plant (34).png");
            this.IconList.Images.SetKeyName(695, "plant (35).png");
            this.IconList.Images.SetKeyName(696, "plant (36).png");
            this.IconList.Images.SetKeyName(697, "plant (37).png");
            this.IconList.Images.SetKeyName(698, "plant (38).png");
            this.IconList.Images.SetKeyName(699, "plant (39).png");
            this.IconList.Images.SetKeyName(700, "plant (40).png");
            this.IconList.Images.SetKeyName(701, "plant (41).png");
            this.IconList.Images.SetKeyName(702, "plant (42).png");
            this.IconList.Images.SetKeyName(703, "plant (43).png");
            this.IconList.Images.SetKeyName(704, "plant (44).png");
            this.IconList.Images.SetKeyName(705, "plant (45).png");
            this.IconList.Images.SetKeyName(706, "plant (46).png");
            this.IconList.Images.SetKeyName(707, "plant (47).png");
            this.IconList.Images.SetKeyName(708, "plant (48).png");
            this.IconList.Images.SetKeyName(709, "plant (49).png");
            this.IconList.Images.SetKeyName(710, "plant (50).png");
            this.IconList.Images.SetKeyName(711, "plant (51).png");
            this.IconList.Images.SetKeyName(712, "plant (52).png");
            this.IconList.Images.SetKeyName(713, "plant (53).png");
            this.IconList.Images.SetKeyName(714, "plant (54).png");
            this.IconList.Images.SetKeyName(715, "plant (55).png");
            this.IconList.Images.SetKeyName(716, "plant (56).png");
            this.IconList.Images.SetKeyName(717, "plant (57).png");
            this.IconList.Images.SetKeyName(718, "plant (58).png");
            this.IconList.Images.SetKeyName(719, "plant (59).png");
            this.IconList.Images.SetKeyName(720, "plant (60).png");
            this.IconList.Images.SetKeyName(721, "plant (61).png");
            this.IconList.Images.SetKeyName(722, "plant (62).png");
            this.IconList.Images.SetKeyName(723, "plant (63).png");
            this.IconList.Images.SetKeyName(724, "plant (64).png");
            this.IconList.Images.SetKeyName(725, "plant (65).png");
            this.IconList.Images.SetKeyName(726, "plant (66).png");
            this.IconList.Images.SetKeyName(727, "plant (67).png");
            this.IconList.Images.SetKeyName(728, "plant (68).png");
            this.IconList.Images.SetKeyName(729, "plant (69).png");
            this.IconList.Images.SetKeyName(730, "plant (70).png");
            this.IconList.Images.SetKeyName(731, "plant (71).png");
            this.IconList.Images.SetKeyName(732, "radio (1).png");
            this.IconList.Images.SetKeyName(733, "radio (2).png");
            this.IconList.Images.SetKeyName(734, "radio (3).png");
            this.IconList.Images.SetKeyName(735, "radio (4).png");
            this.IconList.Images.SetKeyName(736, "radio (5).png");
            this.IconList.Images.SetKeyName(737, "radio (6).png");
            this.IconList.Images.SetKeyName(738, "radio (7).png");
            this.IconList.Images.SetKeyName(739, "robot (1).png");
            this.IconList.Images.SetKeyName(740, "robot (2).png");
            this.IconList.Images.SetKeyName(741, "robot (3).png");
            this.IconList.Images.SetKeyName(742, "robot (4).png");
            this.IconList.Images.SetKeyName(743, "robot (5).png");
            this.IconList.Images.SetKeyName(744, "robot (6).png");
            this.IconList.Images.SetKeyName(745, "robot (7).png");
            this.IconList.Images.SetKeyName(746, "robot (8).png");
            this.IconList.Images.SetKeyName(747, "robot (9).png");
            this.IconList.Images.SetKeyName(748, "robot (10).png");
            this.IconList.Images.SetKeyName(749, "robot (11).png");
            this.IconList.Images.SetKeyName(750, "robot (12).png");
            this.IconList.Images.SetKeyName(751, "robot (13).png");
            this.IconList.Images.SetKeyName(752, "robot (14).png");
            this.IconList.Images.SetKeyName(753, "robot (15).png");
            this.IconList.Images.SetKeyName(754, "robot (16).png");
            this.IconList.Images.SetKeyName(755, "robot (17).png");
            this.IconList.Images.SetKeyName(756, "robot (18).png");
            this.IconList.Images.SetKeyName(757, "robot (19).png");
            this.IconList.Images.SetKeyName(758, "robot (20).png");
            this.IconList.Images.SetKeyName(759, "robot (21).png");
            this.IconList.Images.SetKeyName(760, "robot (22).png");
            this.IconList.Images.SetKeyName(761, "robot (23).png");
            this.IconList.Images.SetKeyName(762, "robot (24).png");
            this.IconList.Images.SetKeyName(763, "robot (25).png");
            this.IconList.Images.SetKeyName(764, "robot (26).png");
            this.IconList.Images.SetKeyName(765, "robot (27).png");
            this.IconList.Images.SetKeyName(766, "robot (28).png");
            this.IconList.Images.SetKeyName(767, "robot (29).png");
            this.IconList.Images.SetKeyName(768, "robot (30).png");
            this.IconList.Images.SetKeyName(769, "robot (31).png");
            this.IconList.Images.SetKeyName(770, "robot (32).png");
            this.IconList.Images.SetKeyName(771, "robot (33).png");
            this.IconList.Images.SetKeyName(772, "robot (34).png");
            this.IconList.Images.SetKeyName(773, "robot (35).png");
            this.IconList.Images.SetKeyName(774, "robot (36).png");
            this.IconList.Images.SetKeyName(775, "robot (37).png");
            this.IconList.Images.SetKeyName(776, "robot (38).png");
            this.IconList.Images.SetKeyName(777, "satellite (1).png");
            this.IconList.Images.SetKeyName(778, "satellite (2).png");
            this.IconList.Images.SetKeyName(779, "satellite (3).png");
            this.IconList.Images.SetKeyName(780, "satellite (4).png");
            this.IconList.Images.SetKeyName(781, "satellite (5).png");
            this.IconList.Images.SetKeyName(782, "satellite (6).png");
            this.IconList.Images.SetKeyName(783, "satellite (7).png");
            this.IconList.Images.SetKeyName(784, "satellite (8).png");
            this.IconList.Images.SetKeyName(785, "satellite (9).png");
            this.IconList.Images.SetKeyName(786, "satellite (10).png");
            this.IconList.Images.SetKeyName(787, "satellite (11).png");
            this.IconList.Images.SetKeyName(788, "security (1).png");
            this.IconList.Images.SetKeyName(789, "security (2).png");
            this.IconList.Images.SetKeyName(790, "security (3).png");
            this.IconList.Images.SetKeyName(791, "security (4).png");
            this.IconList.Images.SetKeyName(792, "security (5).png");
            this.IconList.Images.SetKeyName(793, "space (1).png");
            this.IconList.Images.SetKeyName(794, "space (2).png");
            this.IconList.Images.SetKeyName(795, "space (3).png");
            this.IconList.Images.SetKeyName(796, "space (4).png");
            this.IconList.Images.SetKeyName(797, "space (5).png");
            this.IconList.Images.SetKeyName(798, "space (6).png");
            this.IconList.Images.SetKeyName(799, "space (7).png");
            this.IconList.Images.SetKeyName(800, "space (8).png");
            this.IconList.Images.SetKeyName(801, "space (9).png");
            this.IconList.Images.SetKeyName(802, "space (10).png");
            this.IconList.Images.SetKeyName(803, "space (11).png");
            this.IconList.Images.SetKeyName(804, "space (12).png");
            this.IconList.Images.SetKeyName(805, "space (13).png");
            this.IconList.Images.SetKeyName(806, "space (14).png");
            this.IconList.Images.SetKeyName(807, "space (15).png");
            this.IconList.Images.SetKeyName(808, "space (16).png");
            this.IconList.Images.SetKeyName(809, "space (17).png");
            this.IconList.Images.SetKeyName(810, "space (18).png");
            this.IconList.Images.SetKeyName(811, "space (19).png");
            this.IconList.Images.SetKeyName(812, "space (20).png");
            this.IconList.Images.SetKeyName(813, "space (21).png");
            this.IconList.Images.SetKeyName(814, "space (22).png");
            this.IconList.Images.SetKeyName(815, "space (23).png");
            this.IconList.Images.SetKeyName(816, "space (24).png");
            this.IconList.Images.SetKeyName(817, "space (25).png");
            this.IconList.Images.SetKeyName(818, "space (26).png");
            this.IconList.Images.SetKeyName(819, "space (27).png");
            this.IconList.Images.SetKeyName(820, "space (28).png");
            this.IconList.Images.SetKeyName(821, "space (29).png");
            this.IconList.Images.SetKeyName(822, "space (30).png");
            this.IconList.Images.SetKeyName(823, "space (31).png");
            this.IconList.Images.SetKeyName(824, "space (32).png");
            this.IconList.Images.SetKeyName(825, "space (33).png");
            this.IconList.Images.SetKeyName(826, "space (34).png");
            this.IconList.Images.SetKeyName(827, "theater (1).png");
            this.IconList.Images.SetKeyName(828, "theater (2).png");
            this.IconList.Images.SetKeyName(829, "theater (3).png");
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

