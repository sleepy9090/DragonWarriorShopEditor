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
    public partial class FormPrices : Form
    {
        string path;

        public FormPrices(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void FormPrices_Load(object sender, EventArgs e)
        {
            setMaxTextboxLength();
            loadROMText();
        }

        private void loadROMText()
        {
            Backend backend = new Backend(path);

            textBox1.Text = backend.getPrice(0x1957);
            textBox2.Text = backend.getPrice(0x1959);
            textBox3.Text = backend.getPrice(0x195B);
            textBox4.Text = backend.getPrice(0x195D);
            textBox5.Text = backend.getPrice(0x195F);
            textBox6.Text = backend.getPrice(0x1961);
            textBox7.Text = backend.getPrice(0x1963);
            textBox8.Text = backend.getPrice(0x1965);
            textBox9.Text = backend.getPrice(0x1967);
            textBox10.Text = backend.getPrice(0x1969);
            textBox11.Text = backend.getPrice(0x196B);
            textBox12.Text = backend.getPrice(0x196D);
            textBox13.Text = backend.getPrice(0x196F);
            textBox14.Text = backend.getPrice(0x1971);
            textBox15.Text = backend.getPrice(0x1973);
            textBox16.Text = backend.getPrice(0x1975);
            textBox17.Text = backend.getPrice(0x1977);
            textBox18.Text = backend.getPrice(0x1979);
            textBox19.Text = backend.getPrice(0x197B);
            textBox20.Text = backend.getPrice(0x197D);
            textBox21.Text = backend.getPrice(0x197F);
            textBox22.Text = backend.getPrice(0x1981);
            textBox23.Text = backend.getPrice(0x1983);

            textBox24.Text = backend.getPriceSingleByte(0x1999);
            textBox25.Text = backend.getPriceSingleByte(0x199A);
            textBox26.Text = backend.getPriceSingleByte(0x199B);
            textBox27.Text = backend.getPriceSingleByte(0x199C);
            textBox28.Text = backend.getPriceSingleByte(0x199D);
            textBox29.Text = backend.getPriceSingleByte(0x199E);
            textBox30.Text = backend.getPriceSingleByte(0x199F);
            textBox31.Text = backend.getPriceSingleByte(0x19A0);
        }

        private void setMaxTextboxLength()
        {
            // Max 65535
            textBox1.MaxLength = 5;
            textBox2.MaxLength = 5;
            textBox3.MaxLength = 5;
            textBox4.MaxLength = 5;
            textBox5.MaxLength = 5;
            textBox6.MaxLength = 5;
            textBox7.MaxLength = 5;
            textBox8.MaxLength = 5;
            textBox9.MaxLength = 5;
            textBox10.MaxLength = 5;
            textBox11.MaxLength = 5;
            textBox12.MaxLength = 5;
            textBox13.MaxLength = 5;
            textBox14.MaxLength = 5;
            textBox15.MaxLength = 5;
            textBox16.MaxLength = 5;
            textBox17.MaxLength = 5;
            textBox18.MaxLength = 5;
            textBox19.MaxLength = 5;
            textBox20.MaxLength = 5;
            textBox21.MaxLength = 5;
            textBox22.MaxLength = 5;
            textBox23.MaxLength = 5;

            // 255
            textBox24.MaxLength = 3;
            textBox25.MaxLength = 3;
            textBox26.MaxLength = 3;
            textBox27.MaxLength = 3;
            textBox28.MaxLength = 3;
            textBox29.MaxLength = 3;
            textBox30.MaxLength = 3;
            textBox31.MaxLength = 3;
        }

        private void buttonUpdatePrices_Click(object sender, EventArgs e)
        {

            Backend backend = new Backend(path);
            backend.setPrice(0x1957, textBox1.Text);
            backend.setPrice(0x1959, textBox2.Text);
            backend.setPrice(0x195B, textBox3.Text);
            backend.setPrice(0x195D, textBox4.Text);
            backend.setPrice(0x195F, textBox5.Text);
            backend.setPrice(0x1961, textBox6.Text);
            backend.setPrice(0x1963, textBox7.Text);
            backend.setPrice(0x1965, textBox8.Text);
            backend.setPrice(0x1967, textBox9.Text);
            backend.setPrice(0x1969, textBox10.Text);
            backend.setPrice(0x196B, textBox11.Text);
            backend.setPrice(0x196D, textBox12.Text);
            backend.setPrice(0x196F, textBox13.Text);
            backend.setPrice(0x1971, textBox14.Text);
            backend.setPrice(0x1973, textBox15.Text);
            backend.setPrice(0x1975, textBox16.Text);
            backend.setPrice(0x1977, textBox17.Text);
            backend.setPrice(0x1979, textBox18.Text);
            backend.setPrice(0x197B, textBox19.Text);
            backend.setPrice(0x197D, textBox20.Text);
            backend.setPrice(0x197F, textBox21.Text);
            backend.setPrice(0x1981, textBox22.Text);
            backend.setPrice(0x1983, textBox23.Text);

            backend.setPriceSingleByte(0x1999, textBox24.Text);
            backend.setPriceSingleByte(0x199A, textBox25.Text);
            backend.setPriceSingleByte(0x199B, textBox26.Text);
            backend.setPriceSingleByte(0x199C, textBox27.Text);
            backend.setPriceSingleByte(0x199D, textBox28.Text);
            backend.setPriceSingleByte(0x199E, textBox29.Text);
            backend.setPriceSingleByte(0x199F, textBox30.Text);
            backend.setPriceSingleByte(0x19A0, textBox31.Text);

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
