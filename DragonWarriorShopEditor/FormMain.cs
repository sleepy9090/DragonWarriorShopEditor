using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 2018+
 */
namespace DragonWarriorShopEditor
{
    public partial class FormMain : Form
    {
        string path;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            disableMenuItems();
        }

        private void buttonOpenRom_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                textBoxFilename.Text = path;

                loadRom();
            }
        }

        private void loadRom()
        {
            enableMenuItems();
        }

        private void enableMenuItems()
        {
            pricesToolStripMenuItem.Enabled = true;
            kolShopItemsToolStripMenuItem.Enabled = true;
            brecconaryShopItemsToolStripMenuItem.Enabled = true;
            garinhamShopItemsToolStripMenuItem.Enabled = true;
            cantlinShopItemsToolStripMenuItem.Enabled = true;
            rimuldarShopItemsToolStripMenuItem.Enabled = true;
        }

        private void disableMenuItems()
        {
            pricesToolStripMenuItem.Enabled = false;
            kolShopItemsToolStripMenuItem.Enabled = false;
            brecconaryShopItemsToolStripMenuItem.Enabled = false;
            garinhamShopItemsToolStripMenuItem.Enabled = false;
            cantlinShopItemsToolStripMenuItem.Enabled = false;
            rimuldarShopItemsToolStripMenuItem.Enabled = false;
        }

        #region toolstrip menu items
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }
        #endregion

        private void openROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonOpenRom_Click(sender, e);
        }

        private void pricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrices formPrices = new FormPrices(path);
            formPrices.ShowDialog();
        }

        private void kolShopItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKol formKol = new FormKol(path);
            formKol.ShowDialog();
        }

        private void brecconaryShopItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBrecconary formBrecconary = new FormBrecconary(path);
            formBrecconary.ShowDialog();
        }

        private void garinhamShopItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGarinham formGarinham = new FormGarinham(path);
            formGarinham.ShowDialog();
        }

        private void cantlinShopItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCantlin formCantlin = new FormCantlin(path);
            formCantlin.ShowDialog();
        }

        private void rimuldarShopItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRimuldar formRimuldar = new FormRimuldar(path);
            formRimuldar.ShowDialog();
        }
    }
}
