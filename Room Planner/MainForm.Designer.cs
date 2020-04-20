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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCoffee = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonSofa = new System.Windows.Forms.Button();
            this.buttonBed = new System.Windows.Forms.Button();
            this.buttonWalls = new System.Windows.Forms.Button();
            this.CreatedBox = new System.Windows.Forms.GroupBox();
            this.listFurniture = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.AddBox.SuspendLayout();
            this.flowLayoutPanelRight.SuspendLayout();
            this.CreatedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBluToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newBluToolStripMenuItem
            // 
            this.newBluToolStripMenuItem.Name = "newBluToolStripMenuItem";
            this.newBluToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.newBluToolStripMenuItem.Text = "New bluprint  F2";
            this.newBluToolStripMenuItem.Click += new System.EventHandler(this.newBluToolStripMenuItem_Click);
            // 
            // AddBox
            // 
            this.AddBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBox.Controls.Add(this.flowLayoutPanelRight);
            this.AddBox.Location = new System.Drawing.Point(7, 31);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(225, 216);
            this.AddBox.TabIndex = 0;
            this.AddBox.TabStop = false;
            this.AddBox.Text = "Add Furniture";
            // 
            // flowLayoutPanelRight
            // 
            this.flowLayoutPanelRight.AutoScroll = true;
            this.flowLayoutPanelRight.Controls.Add(this.buttonCoffee);
            this.flowLayoutPanelRight.Controls.Add(this.buttonTable);
            this.flowLayoutPanelRight.Controls.Add(this.buttonSofa);
            this.flowLayoutPanelRight.Controls.Add(this.buttonBed);
            this.flowLayoutPanelRight.Controls.Add(this.buttonWalls);
            this.flowLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRight.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanelRight.Name = "flowLayoutPanelRight";
            this.flowLayoutPanelRight.Size = new System.Drawing.Size(219, 192);
            this.flowLayoutPanelRight.TabIndex = 0;
            // 
            // buttonCoffee
            // 
            this.buttonCoffee.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCoffee.BackgroundImage = global::Room_Planner.Properties.Resources.coffee_table;
            this.buttonCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCoffee.Location = new System.Drawing.Point(3, 3);
            this.buttonCoffee.Name = "buttonCoffee";
            this.buttonCoffee.Size = new System.Drawing.Size(75, 75);
            this.buttonCoffee.TabIndex = 0;
            this.buttonCoffee.UseVisualStyleBackColor = false;
            this.buttonCoffee.Click += new System.EventHandler(this.buttonCoffee_Click);
            // 
            // buttonTable
            // 
            this.buttonTable.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTable.BackgroundImage = global::Room_Planner.Properties.Resources.table;
            this.buttonTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTable.Location = new System.Drawing.Point(84, 3);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(75, 75);
            this.buttonTable.TabIndex = 1;
            this.buttonTable.UseVisualStyleBackColor = false;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonSofa
            // 
            this.buttonSofa.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSofa.BackgroundImage = global::Room_Planner.Properties.Resources.sofa;
            this.buttonSofa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSofa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSofa.Location = new System.Drawing.Point(3, 84);
            this.buttonSofa.Name = "buttonSofa";
            this.buttonSofa.Size = new System.Drawing.Size(75, 75);
            this.buttonSofa.TabIndex = 2;
            this.buttonSofa.UseVisualStyleBackColor = false;
            this.buttonSofa.Click += new System.EventHandler(this.buttonSofa_Click);
            // 
            // buttonBed
            // 
            this.buttonBed.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBed.BackgroundImage = global::Room_Planner.Properties.Resources.double_bed;
            this.buttonBed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBed.Location = new System.Drawing.Point(84, 84);
            this.buttonBed.Name = "buttonBed";
            this.buttonBed.Size = new System.Drawing.Size(75, 75);
            this.buttonBed.TabIndex = 3;
            this.buttonBed.UseVisualStyleBackColor = false;
            this.buttonBed.Click += new System.EventHandler(this.buttonBed_Click);
            // 
            // buttonWalls
            // 
            this.buttonWalls.BackColor = System.Drawing.SystemColors.Window;
            this.buttonWalls.BackgroundImage = global::Room_Planner.Properties.Resources.wall;
            this.buttonWalls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWalls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWalls.Location = new System.Drawing.Point(3, 165);
            this.buttonWalls.Name = "buttonWalls";
            this.buttonWalls.Size = new System.Drawing.Size(75, 75);
            this.buttonWalls.TabIndex = 3;
            this.buttonWalls.UseVisualStyleBackColor = false;
            this.buttonWalls.Click += new System.EventHandler(this.buttonWalls_Click);
            // 
            // CreatedBox
            // 
            this.CreatedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedBox.Controls.Add(this.listFurniture);
            this.CreatedBox.Location = new System.Drawing.Point(10, 253);
            this.CreatedBox.Name = "CreatedBox";
            this.CreatedBox.Size = new System.Drawing.Size(219, 185);
            this.CreatedBox.TabIndex = 1;
            this.CreatedBox.TabStop = false;
            this.CreatedBox.Text = "Created Furniture";
            // 
            // listFurniture
            // 
            this.listFurniture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.positionColumnHeader});
            this.listFurniture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFurniture.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listFurniture.HideSelection = false;
            this.listFurniture.Location = new System.Drawing.Point(3, 21);
            this.listFurniture.Name = "listFurniture";
            this.listFurniture.Size = new System.Drawing.Size(213, 161);
            this.listFurniture.TabIndex = 0;
            this.listFurniture.UseCompatibleStateImageBehavior = false;
            this.listFurniture.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            // 
            // positionColumnHeader
            // 
            this.positionColumnHeader.Text = "Position";
            this.positionColumnHeader.Width = 100;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.flowLayoutPanelLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.CreatedBox);
            this.splitContainer.Panel2.Controls.Add(this.AddBox);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 547;
            this.splitContainer.TabIndex = 0;
            // 
            // flowLayoutPanelLeft
            // 
            this.flowLayoutPanelLeft.AutoScroll = true;
            this.flowLayoutPanelLeft.Controls.Add(this.pictureBox);
            this.flowLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLeft.Name = "flowLayoutPanelLeft";
            this.flowLayoutPanelLeft.Size = new System.Drawing.Size(547, 450);
            this.flowLayoutPanelLeft.TabIndex = 1;
            this.flowLayoutPanelLeft.SizeChanged += new System.EventHandler(this.flowLayoutPanelLeft_SizeChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.splitContainer);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomPlanner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.AddBox.ResumeLayout(false);
            this.flowLayoutPanelRight.ResumeLayout(false);
            this.CreatedBox.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanelLeft.ResumeLayout(false);
            this.flowLayoutPanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
    }
}

