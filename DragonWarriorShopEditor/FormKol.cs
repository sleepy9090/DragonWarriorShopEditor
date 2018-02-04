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
    public partial class FormKol : Form
    {
        string path;

        public FormKol(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void FormKol_Load(object sender, EventArgs e)
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
            comboBox1.SelectedIndex = backend.getComboboxIndex(0x19A1);
            comboBox2.SelectedIndex = backend.getComboboxIndex(0x19A2);
            comboBox3.SelectedIndex = backend.getComboboxIndex(0x19A3);
            comboBox4.SelectedIndex = backend.getComboboxIndex(0x19A4);
            comboBox5.SelectedIndex = backend.getComboboxIndex(0x19A5);

            // Tool Shop
            comboBox6.SelectedIndex = backend.getComboboxIndex(0x19CC);
            comboBox7.SelectedIndex = backend.getComboboxIndex(0x19CD);
            comboBox8.SelectedIndex = backend.getComboboxIndex(0x19CE);
            comboBox9.SelectedIndex = backend.getComboboxIndex(0x19CF);
        }

        private void buttonUpdateItems_Click(object sender, EventArgs e)
        {
            Backend backend = new Backend(path);

            bool result1 = backend.setShopItem(0x19A1, comboBox1.SelectedValue.ToString());
            bool result2 = backend.setShopItem(0x19A2, comboBox2.SelectedValue.ToString());
            bool result3 = backend.setShopItem(0x19A3, comboBox3.SelectedValue.ToString());
            bool result4 = backend.setShopItem(0x19A4, comboBox4.SelectedValue.ToString());
            bool result5 = backend.setShopItem(0x19A5, comboBox5.SelectedValue.ToString());
            bool result6 = backend.setShopItem(0x19CC, comboBox6.SelectedValue.ToString());
            bool result7 = backend.setShopItem(0x19CD, comboBox7.SelectedValue.ToString());
            bool result8 = backend.setShopItem(0x19CE, comboBox8.SelectedValue.ToString());
            bool result9 = backend.setShopItem(0x19CF, comboBox9.SelectedValue.ToString());

            if (result1 && result2 && result3 && result4 && result5 && result6 && result7 && result8 && result9)
            {
                MessageBox.Show("ROM updated!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("ROM update failed.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
