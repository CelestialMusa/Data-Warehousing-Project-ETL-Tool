namespace Energy_Cons_DW_BI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeDataCVSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesCVSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAllObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTablesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createDataInsertingStoredProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropAllTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropAllObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dropTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.truncateTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truncateTablesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(685, 225);
            this.listBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(706, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(459, 225);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.databaseToolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.readFromListsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeDataCVSToolStripMenuItem,
            this.storesCVSToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openFileToolStripMenuItem.Text = "Open &File";
            // 
            // storeDataCVSToolStripMenuItem
            // 
            this.storeDataCVSToolStripMenuItem.Name = "storeDataCVSToolStripMenuItem";
            this.storeDataCVSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.storeDataCVSToolStripMenuItem.Text = "Store Data CVS";
            this.storeDataCVSToolStripMenuItem.Click += new System.EventHandler(this.storeDataCVSToolStripMenuItem_Click_1);
            // 
            // storesCVSToolStripMenuItem
            // 
            this.storesCVSToolStripMenuItem.Name = "storesCVSToolStripMenuItem";
            this.storesCVSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.storesCVSToolStripMenuItem.Text = "Stores CVS";
            this.storesCVSToolStripMenuItem.Click += new System.EventHandler(this.storesCVSToolStripMenuItem_Click);
            // 
            // readFromListsToolStripMenuItem
            // 
            this.readFromListsToolStripMenuItem.Name = "readFromListsToolStripMenuItem";
            this.readFromListsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.readFromListsToolStripMenuItem.Text = "&Read From Lists";
            this.readFromListsToolStripMenuItem.Click += new System.EventHandler(this.readFromListsToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // databaseToolsToolStripMenuItem
            // 
            this.databaseToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTablesToolStripMenuItem,
            this.dropAllTablesToolStripMenuItem,
            this.toolStripSeparator1,
            this.truncateTablesToolStripMenuItem,
            this.truncateTablesToolStripMenuItem1});
            this.databaseToolsToolStripMenuItem.Name = "databaseToolsToolStripMenuItem";
            this.databaseToolsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.databaseToolsToolStripMenuItem.Text = "Database Tools";
            // 
            // createTablesToolStripMenuItem
            // 
            this.createTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAllObjectsToolStripMenuItem,
            this.toolStripSeparator3,
            this.createDatabaseToolStripMenuItem,
            this.createTablesToolStripMenuItem1,
            this.createDataInsertingStoredProcedureToolStripMenuItem});
            this.createTablesToolStripMenuItem.Name = "createTablesToolStripMenuItem";
            this.createTablesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.createTablesToolStripMenuItem.Text = "Create Statements";
            // 
            // createAllObjectsToolStripMenuItem
            // 
            this.createAllObjectsToolStripMenuItem.Name = "createAllObjectsToolStripMenuItem";
            this.createAllObjectsToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.createAllObjectsToolStripMenuItem.Text = "Create All Objects";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(275, 6);
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.createDatabaseToolStripMenuItem.Text = "Create Database";
            // 
            // createTablesToolStripMenuItem1
            // 
            this.createTablesToolStripMenuItem1.Name = "createTablesToolStripMenuItem1";
            this.createTablesToolStripMenuItem1.Size = new System.Drawing.Size(278, 22);
            this.createTablesToolStripMenuItem1.Text = "Create Tables";
            this.createTablesToolStripMenuItem1.Click += new System.EventHandler(this.createTablesToolStripMenuItem1_Click);
            // 
            // createDataInsertingStoredProcedureToolStripMenuItem
            // 
            this.createDataInsertingStoredProcedureToolStripMenuItem.Name = "createDataInsertingStoredProcedureToolStripMenuItem";
            this.createDataInsertingStoredProcedureToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.createDataInsertingStoredProcedureToolStripMenuItem.Text = "Create Data Inserting Stored Procedure";
            // 
            // dropAllTablesToolStripMenuItem
            // 
            this.dropAllTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropAllObjectsToolStripMenuItem,
            this.toolStripSeparator4,
            this.dropTablesToolStripMenuItem});
            this.dropAllTablesToolStripMenuItem.Name = "dropAllTablesToolStripMenuItem";
            this.dropAllTablesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.dropAllTablesToolStripMenuItem.Text = "Drop Statements";
            // 
            // dropAllObjectsToolStripMenuItem
            // 
            this.dropAllObjectsToolStripMenuItem.Name = "dropAllObjectsToolStripMenuItem";
            this.dropAllObjectsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dropAllObjectsToolStripMenuItem.Text = "Drop All Objects";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // dropTablesToolStripMenuItem
            // 
            this.dropTablesToolStripMenuItem.Name = "dropTablesToolStripMenuItem";
            this.dropTablesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dropTablesToolStripMenuItem.Text = "Drop Tables";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // truncateTablesToolStripMenuItem
            // 
            this.truncateTablesToolStripMenuItem.Name = "truncateTablesToolStripMenuItem";
            this.truncateTablesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.truncateTablesToolStripMenuItem.Text = "Insert Records";
            this.truncateTablesToolStripMenuItem.Click += new System.EventHandler(this.insertRecordsToolStripMenuItem_Click);
            // 
            // truncateTablesToolStripMenuItem1
            // 
            this.truncateTablesToolStripMenuItem1.Name = "truncateTablesToolStripMenuItem1";
            this.truncateTablesToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.truncateTablesToolStripMenuItem1.Text = "Truncate Tables";
            this.truncateTablesToolStripMenuItem1.Click += new System.EventHandler(this.truncateTablesToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developersToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // developersToolStripMenuItem
            // 
            this.developersToolStripMenuItem.Name = "developersToolStripMenuItem";
            this.developersToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.developersToolStripMenuItem.Text = "Developers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1090, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1190, 368);
            this.Name = "MainForm";
            this.Text = "Data Warehouses ETL Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeDataCVSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesCVSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFromListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropAllTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem truncateTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truncateTablesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem createAllObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTablesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createDataInsertingStoredProcedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropAllObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem dropTablesToolStripMenuItem;
    }
}

