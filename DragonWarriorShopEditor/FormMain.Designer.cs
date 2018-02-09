namespace DragonWarriorShopEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kolShopItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brecconaryShopItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garinhamShopItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantlinShopItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rimuldarShopItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpenRom = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openROMToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openROMToolStripMenuItem
            // 
            this.openROMToolStripMenuItem.Name = "openROMToolStripMenuItem";
            this.openROMToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openROMToolStripMenuItem.Text = "&Open ROM";
            this.openROMToolStripMenuItem.Click += new System.EventHandler(this.openROMToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pricesToolStripMenuItem,
            this.toolStripSeparator2,
            this.kolShopItemsToolStripMenuItem,
            this.brecconaryShopItemsToolStripMenuItem,
            this.garinhamShopItemsToolStripMenuItem,
            this.cantlinShopItemsToolStripMenuItem,
            this.rimuldarShopItemsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // pricesToolStripMenuItem
            // 
            this.pricesToolStripMenuItem.Name = "pricesToolStripMenuItem";
            this.pricesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.pricesToolStripMenuItem.Text = "&Prices";
            this.pricesToolStripMenuItem.Click += new System.EventHandler(this.pricesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // kolShopItemsToolStripMenuItem
            // 
            this.kolShopItemsToolStripMenuItem.Name = "kolShopItemsToolStripMenuItem";
            this.kolShopItemsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.kolShopItemsToolStripMenuItem.Text = "&Kol Shop Items";
            this.kolShopItemsToolStripMenuItem.Click += new System.EventHandler(this.kolShopItemsToolStripMenuItem_Click);
            // 
            // brecconaryShopItemsToolStripMenuItem
            // 
            this.brecconaryShopItemsToolStripMenuItem.Name = "brecconaryShopItemsToolStripMenuItem";
            this.brecconaryShopItemsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.brecconaryShopItemsToolStripMenuItem.Text = "&Brecconary Shop Items";
            this.brecconaryShopItemsToolStripMenuItem.Click += new System.EventHandler(this.brecconaryShopItemsToolStripMenuItem_Click);
            // 
            // garinhamShopItemsToolStripMenuItem
            // 
            this.garinhamShopItemsToolStripMenuItem.Name = "garinhamShopItemsToolStripMenuItem";
            this.garinhamShopItemsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.garinhamShopItemsToolStripMenuItem.Text = "&Garinham Shop Items";
            this.garinhamShopItemsToolStripMenuItem.Click += new System.EventHandler(this.garinhamShopItemsToolStripMenuItem_Click);
            // 
            // cantlinShopItemsToolStripMenuItem
            // 
            this.cantlinShopItemsToolStripMenuItem.Name = "cantlinShopItemsToolStripMenuItem";
            this.cantlinShopItemsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cantlinShopItemsToolStripMenuItem.Text = "&Cantlin Shop Items";
            this.cantlinShopItemsToolStripMenuItem.Click += new System.EventHandler(this.cantlinShopItemsToolStripMenuItem_Click);
            // 
            // rimuldarShopItemsToolStripMenuItem
            // 
            this.rimuldarShopItemsToolStripMenuItem.Name = "rimuldarShopItemsToolStripMenuItem";
            this.rimuldarShopItemsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rimuldarShopItemsToolStripMenuItem.Text = "&Rimuldar Shop Items";
            this.rimuldarShopItemsToolStripMenuItem.Click += new System.EventHandler(this.rimuldarShopItemsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpenRom);
            this.groupBox2.Controls.Add(this.textBoxFilename);
            this.groupBox2.Controls.Add(this.labelFilename);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 44);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // buttonOpenRom
            // 
            this.buttonOpenRom.Location = new System.Drawing.Point(352, 11);
            this.buttonOpenRom.Name = "buttonOpenRom";
            this.buttonOpenRom.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenRom.TabIndex = 1;
            this.buttonOpenRom.Text = "&Open ROM";
            this.buttonOpenRom.UseVisualStyleBackColor = true;
            this.buttonOpenRom.Click += new System.EventHandler(this.buttonOpenRom_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(64, 13);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.ReadOnly = true;
            this.textBoxFilename.Size = new System.Drawing.Size(282, 20);
            this.textBoxFilename.TabIndex = 1;
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(6, 16);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(52, 13);
            this.labelFilename.TabIndex = 0;
            this.labelFilename.Text = "Filename:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DragonWarriorShopEditor.Properties.Resources.shop;
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 278);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Dragon Warrior Shop Editor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openROMToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOpenRom;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem kolShopItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brecconaryShopItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garinhamShopItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantlinShopItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rimuldarShopItemsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

