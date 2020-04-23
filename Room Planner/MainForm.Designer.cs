namespace Room_Planner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.CreatedBox = new System.Windows.Forms.GroupBox();
            this.listFurniture = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCoffee = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonSofa = new System.Windows.Forms.Button();
            this.buttonBed = new System.Windows.Forms.Button();
            this.buttonWalls = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBluprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBlueprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简体中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.CreatedBox.SuspendLayout();
            this.AddBox.SuspendLayout();
            this.flowLayoutPanelRight.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            resources.ApplyResources(this.splitContainer.Panel1, "splitContainer.Panel1");
            this.splitContainer.Panel1.Controls.Add(this.flowLayoutPanelLeft);
            // 
            // splitContainer.Panel2
            // 
            resources.ApplyResources(this.splitContainer.Panel2, "splitContainer.Panel2");
            this.splitContainer.Panel2.Controls.Add(this.CreatedBox);
            this.splitContainer.Panel2.Controls.Add(this.AddBox);
            // 
            // flowLayoutPanelLeft
            // 
            resources.ApplyResources(this.flowLayoutPanelLeft, "flowLayoutPanelLeft");
            this.flowLayoutPanelLeft.Controls.Add(this.pictureBox);
            this.flowLayoutPanelLeft.Name = "flowLayoutPanelLeft";
            this.flowLayoutPanelLeft.SizeChanged += new System.EventHandler(this.flowLayoutPanelLeft_SizeChanged);
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // CreatedBox
            // 
            resources.ApplyResources(this.CreatedBox, "CreatedBox");
            this.CreatedBox.Controls.Add(this.listFurniture);
            this.CreatedBox.Name = "CreatedBox";
            this.CreatedBox.TabStop = false;
            // 
            // listFurniture
            // 
            resources.ApplyResources(this.listFurniture, "listFurniture");
            this.listFurniture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.positionColumnHeader});
            this.listFurniture.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listFurniture.HideSelection = false;
            this.listFurniture.Name = "listFurniture";
            this.listFurniture.UseCompatibleStateImageBehavior = false;
            this.listFurniture.View = System.Windows.Forms.View.Details;
            this.listFurniture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listFurniture_MouseClick);
            // 
            // nameColumnHeader
            // 
            resources.ApplyResources(this.nameColumnHeader, "nameColumnHeader");
            // 
            // positionColumnHeader
            // 
            resources.ApplyResources(this.positionColumnHeader, "positionColumnHeader");
            // 
            // AddBox
            // 
            resources.ApplyResources(this.AddBox, "AddBox");
            this.AddBox.Controls.Add(this.flowLayoutPanelRight);
            this.AddBox.Name = "AddBox";
            this.AddBox.TabStop = false;
            // 
            // flowLayoutPanelRight
            // 
            resources.ApplyResources(this.flowLayoutPanelRight, "flowLayoutPanelRight");
            this.flowLayoutPanelRight.Controls.Add(this.buttonCoffee);
            this.flowLayoutPanelRight.Controls.Add(this.buttonTable);
            this.flowLayoutPanelRight.Controls.Add(this.buttonSofa);
            this.flowLayoutPanelRight.Controls.Add(this.buttonBed);
            this.flowLayoutPanelRight.Controls.Add(this.buttonWalls);
            this.flowLayoutPanelRight.Name = "flowLayoutPanelRight";
            // 
            // buttonCoffee
            // 
            resources.ApplyResources(this.buttonCoffee, "buttonCoffee");
            this.buttonCoffee.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCoffee.BackgroundImage = global::Room_Planner.Properties.Resources.coffee_table;
            this.buttonCoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCoffee.Name = "buttonCoffee";
            this.buttonCoffee.UseVisualStyleBackColor = false;
            this.buttonCoffee.Click += new System.EventHandler(this.buttonCoffee_Click);
            // 
            // buttonTable
            // 
            resources.ApplyResources(this.buttonTable, "buttonTable");
            this.buttonTable.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTable.BackgroundImage = global::Room_Planner.Properties.Resources.table;
            this.buttonTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.UseVisualStyleBackColor = false;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonSofa
            // 
            resources.ApplyResources(this.buttonSofa, "buttonSofa");
            this.buttonSofa.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSofa.BackgroundImage = global::Room_Planner.Properties.Resources.sofa;
            this.buttonSofa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSofa.Name = "buttonSofa";
            this.buttonSofa.UseVisualStyleBackColor = false;
            this.buttonSofa.Click += new System.EventHandler(this.buttonSofa_Click);
            // 
            // buttonBed
            // 
            resources.ApplyResources(this.buttonBed, "buttonBed");
            this.buttonBed.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBed.BackgroundImage = global::Room_Planner.Properties.Resources.double_bed;
            this.buttonBed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBed.Name = "buttonBed";
            this.buttonBed.UseVisualStyleBackColor = false;
            this.buttonBed.Click += new System.EventHandler(this.buttonBed_Click);
            // 
            // buttonWalls
            // 
            resources.ApplyResources(this.buttonWalls, "buttonWalls");
            this.buttonWalls.BackColor = System.Drawing.SystemColors.Window;
            this.buttonWalls.BackgroundImage = global::Room_Planner.Properties.Resources.wall;
            this.buttonWalls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWalls.Name = "buttonWalls";
            this.buttonWalls.UseVisualStyleBackColor = false;
            this.buttonWalls.Click += new System.EventHandler(this.buttonWalls_Click);
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBluToolStripMenuItem,
            this.openBluprintToolStripMenuItem,
            this.saveBlueprintToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // newBluToolStripMenuItem
            // 
            resources.ApplyResources(this.newBluToolStripMenuItem, "newBluToolStripMenuItem");
            this.newBluToolStripMenuItem.Name = "newBluToolStripMenuItem";
            this.newBluToolStripMenuItem.Click += new System.EventHandler(this.newBluToolStripMenuItem_Click);
            // 
            // openBluprintToolStripMenuItem
            // 
            resources.ApplyResources(this.openBluprintToolStripMenuItem, "openBluprintToolStripMenuItem");
            this.openBluprintToolStripMenuItem.Name = "openBluprintToolStripMenuItem";
            this.openBluprintToolStripMenuItem.Click += new System.EventHandler(this.openBluprintToolStripMenuItem_Click);
            // 
            // saveBlueprintToolStripMenuItem
            // 
            resources.ApplyResources(this.saveBlueprintToolStripMenuItem, "saveBlueprintToolStripMenuItem");
            this.saveBlueprintToolStripMenuItem.Name = "saveBlueprintToolStripMenuItem";
            this.saveBlueprintToolStripMenuItem.Click += new System.EventHandler(this.saveBlueprintToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.简体中文ToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // 简体中文ToolStripMenuItem
            // 
            resources.ApplyResources(this.简体中文ToolStripMenuItem, "简体中文ToolStripMenuItem");
            this.简体中文ToolStripMenuItem.Name = "简体中文ToolStripMenuItem";
            this.简体中文ToolStripMenuItem.Click += new System.EventHandler(this.简体中文ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.splitContainer);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanelLeft.ResumeLayout(false);
            this.flowLayoutPanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.CreatedBox.ResumeLayout(false);
            this.AddBox.ResumeLayout(false);
            this.flowLayoutPanelRight.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBluToolStripMenuItem;
        private System.Windows.Forms.GroupBox AddBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRight;
        private System.Windows.Forms.Button buttonCoffee;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button buttonSofa;
        private System.Windows.Forms.Button buttonBed;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox CreatedBox;
        private System.Windows.Forms.ListView listFurniture;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader positionColumnHeader;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLeft;
        private System.Windows.Forms.Button buttonWalls;
        private System.Windows.Forms.ToolStripMenuItem openBluprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBlueprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简体中文ToolStripMenuItem;
    }
}

