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
    public partial class FormCantlin : Form
    {
        string path;

        public FormCantlin(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void FormCantlin_Load(object sender, EventArgs e)
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

            comboBox10.DataSource = new BindingSource(shopItems, null);
            comboBox10.DisplayMember = "Value";
            comboBox10.ValueMember = "Key";

            comboBox11.DataSource = new BindingSource(shopItems, null);
            comboBox11.DisplayMember = "Value";
            comboBox11.ValueMember = "Key";

            comboBox12.DataSource = new BindingSource(shopItems, null);
            comboBox12.DisplayMember = "Value";
            comboBox12.ValueMember = "Key";

            comboBox13.DataSource = new BindingSource(shopItems, null);
            comboBox13.DisplayMember = "Value";
            comboBox13.ValueMember = "Key";

            comboBox14.DataSource = new BindingSource(shopItems, null);
            comboBox14.DisplayMember = "Value";
            comboBox14.ValueMember = "Key";

            comboBox15.DataSource = new BindingSource(shopItems, null);
            comboBox15.DisplayMember = "Value";
            comboBox15.ValueMember = "Key";

            comboBox16.DataSource = new BindingSource(shopItems, null);
            comboBox16.DisplayMember = "Value";
            comboBox16.ValueMember = "Key";
        }

        private void setComboBoxes(Backend backend)
        {
            // Weapon Shop (North)
            comboBox1.SelectedIndex = backend.getComboboxIndex(0x19B6);
            comboBox2.SelectedIndex = backend.getComboboxIndex(0x19B7);
            comboBox3.SelectedIndex = backend.getComboboxIndex(0x19B8);
            comboBox4.SelectedIndex = backend.getComboboxIndex(0x19B9);
            comboBox5.SelectedIndex = backend.getComboboxIndex(0x19BA);
            comboBox6.SelectedIndex = backend.getComboboxIndex(0x19BB);

            // Weapon Shop (South)
            comboBox7.SelectedIndex = backend.getComboboxIndex(0x19BD);
            comboBox8.SelectedIndex = backend.getComboboxIndex(0x19BE);
            comboBox9.SelectedIndex = backend.getComboboxIndex(0x19BF);
            comboBox10.SelectedIndex = backend.getComboboxIndex(0x19C0);

            // Weapon Shop (Locked)
            comboBox11.SelectedIndex = backend.getComboboxIndex(0x19C2);
            comboBox12.SelectedIndex = backend.getComboboxIndex(0x19C3);

            // Tool Shop (North)
            comboBox13.SelectedIndex = backend.getComboboxIndex(0x19D9);
            comboBox14.SelectedIndex = backend.getComboboxIndex(0x19DA);

            // Tool Shop (South)
            comboBox15.SelectedIndex = backend.getComboboxIndex(0x19DC);
            comboBox16.SelectedIndex = backend.getComboboxIndex(0x19DD);

        }

        private void buttonUpdateItems_Click(object sender, EventArgs e)
        {
            Backend backend = new Backend(path);

            backend.setShopItem(0x19B6, comboBox1.SelectedValue.ToString());
            backend.setShopItem(0x19B7, comboBox2.SelectedValue.ToString());
            backend.setShopItem(0x19B8, comboBox3.SelectedValue.ToString());
            backend.setShopItem(0x19B9, comboBox4.SelectedValue.ToString());
            backend.setShopItem(0x19BA, comboBox5.SelectedValue.ToString());
            backend.setShopItem(0x19BB, comboBox6.SelectedValue.ToString());
            backend.setShopItem(0x19BD, comboBox7.SelectedValue.ToString());
            backend.setShopItem(0x19BE, comboBox8.SelectedValue.ToString());
            backend.setShopItem(0x19BF, comboBox9.SelectedValue.ToString());
            backend.setShopItem(0x19C0, comboBox10.SelectedValue.ToString());
            backend.setShopItem(0x19C2, comboBox11.SelectedValue.ToString());
            backend.setShopItem(0x19C3, comboBox12.SelectedValue.ToString());
            backend.setShopItem(0x19D9, comboBox13.SelectedValue.ToString());
            backend.setShopItem(0x19DA, comboBox14.SelectedValue.ToString());
            backend.setShopItem(0x19DC, comboBox15.SelectedValue.ToString());
            backend.setShopItem(0x19DD, comboBox16.SelectedValue.ToString());

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
