namespace oxkiller.UI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSearchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aQFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversionTestToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // conversionTestToolStripMenuItem
            // 
            this.conversionTestToolStripMenuItem.Name = "conversionTestToolStripMenuItem";
            this.conversionTestToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.conversionTestToolStripMenuItem.Text = "Conversion Test";
            this.conversionTestToolStripMenuItem.Click += new System.EventHandler(this.conversionTestToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // loadDatabaseToolStripMenuItem
            // 
            this.loadDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aQFormatToolStripMenuItem});
            this.loadDatabaseToolStripMenuItem.Name = "loadDatabaseToolStripMenuItem";
            this.loadDatabaseToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loadDatabaseToolStripMenuItem.Text = "Import";
            this.loadDatabaseToolStripMenuItem.Click += new System.EventHandler(this.loadDatabaseToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSearchingToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // startSearchingToolStripMenuItem
            // 
            this.startSearchingToolStripMenuItem.Name = "startSearchingToolStripMenuItem";
            this.startSearchingToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.startSearchingToolStripMenuItem.Text = "Start Searching";
            this.startSearchingToolStripMenuItem.Click += new System.EventHandler(this.startSearchingToolStripMenuItem_Click);
            // 
            // aQFormatToolStripMenuItem
            // 
            this.aQFormatToolStripMenuItem.Name = "aQFormatToolStripMenuItem";
            this.aQFormatToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aQFormatToolStripMenuItem.Text = "Q A format";
            this.aQFormatToolStripMenuItem.Click += new System.EventHandler(this.aQFormatToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 137);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "OX Event Killer Solver";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSearchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aQFormatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}