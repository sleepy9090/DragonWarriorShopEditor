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
    public partial class FormBrecconary : Form
    {
        string path;

        public FormBrecconary(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void FormBrecconary_Load(object sender, EventArgs e)
        {
            Backend backend = new Backend(path);

            populateComboBoxes(backend);
            setComboBoxes(backend);
        }

        private void populateComboBoxes(Backend backend)
        {
            Dictionary<string, string> shopItems = backend.getShopItems();

            comboBox1.DataSource = new BindingSource(shopItems, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            comboBox2.DataSource = new BindingSource(shopItems, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";

            comboBox3.DataSource = new BindingSource(shopItems, null);
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";

            comboBox4.DataSource = new BindingSource(shopItems, null);
            comboBox4.DisplayMember = "Value";
            comboBox4.ValueMember = "Key";

            comboBox5.DataSource = new BindingSource(shopItems, null);
            comboBox5.DisplayMember = "Value";
            comboBox5.ValueMember = "Key";

            comboBox6.DataSource = new BindingSource(shopItems, null);
            comboBox6.DisplayMember = "Value";
            comboBox6.ValueMember = "Key";

            comboBox7.DataSource = new BindingSource(shopItems, null);
            comboBox7.DisplayMember = "Value";
            comboBox7.ValueMember = "Key";

            comboBox8.DataSource = new BindingSource(shopItems, null);
            comboBox8.DisplayMember = "Value";
            comboBox8.ValueMember = "Key";

            comboBox9.DataSource = new BindingSource(shopItems, null);
            comboBox9.DisplayMember = "Value";
            comboBox9.ValueMember = "Key";
        }

        private void setComboBoxes(Backend backend)
        {
            // Weapon Shop
            comboBox1.SelectedIndex = backend.getComboboxIndex(0x19A7);
            comboBox2.SelectedIndex = backend.getComboboxIndex(0x19A8);
            comboBox3.SelectedIndex = backend.getComboboxIndex(0x19A9);
            comboBox4.SelectedIndex = backend.getComboboxIndex(0x19AA);
            comboBox5.SelectedIndex = backend.getComboboxIndex(0x19AB);
            comboBox6.SelectedIndex = backend.getComboboxIndex(0x19AC);

            // Tool Shop
            comboBox7.SelectedIndex = backend.getComboboxIndex(0x19D1);
            comboBox8.SelectedIndex = backend.getComboboxIndex(0x19D2);
            comboBox9.SelectedIndex = backend.getComboboxIndex(0x19D3);
        }

        private void buttonUpdateItems_Click(object sender, EventArgs e)
        {
            Backend backend = new Backend(path);

            backend.setShopItem(0x19A7, comboBox1.SelectedValue.ToString());
            backend.setShopItem(0x19A8, comboBox2.SelectedValue.ToString());
            backend.setShopItem(0x19A9, comboBox3.SelectedValue.ToString());
            backend.setShopItem(0x19AA, comboBox4.SelectedValue.ToString());
            backend.setShopItem(0x19AB, comboBox5.SelectedValue.ToString());
            backend.setShopItem(0x19AC, comboBox6.SelectedValue.ToString());
            backend.setShopItem(0x19D1, comboBox7.SelectedValue.ToString());
            backend.setShopItem(0x19D2, comboBox8.SelectedValue.ToString());
            backend.setShopItem(0x19D3, comboBox9.SelectedValue.ToString());

            //    MessageBox.Show("There was a problem updating the ROM header. " + errorMsg + ".",
            //        "Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error,
            //        MessageBoxDefaultButton.Button1);
            //}
            //else
            //{
            MessageBox.Show("ROM updated!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            //}
        }
    }
}
