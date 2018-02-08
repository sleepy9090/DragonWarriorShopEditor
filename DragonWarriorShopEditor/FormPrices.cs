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
            loadROMPrices();
        }

        private void loadROMPrices()
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
            bool result1 = backend.setPrice(0x1957, textBox1.Text);
            bool result2 = backend.setPrice(0x1959, textBox2.Text);
            bool result3 = backend.setPrice(0x195B, textBox3.Text);
            bool result4 = backend.setPrice(0x195D, textBox4.Text);
            bool result5 = backend.setPrice(0x195F, textBox5.Text);
            bool result6 = backend.setPrice(0x1961, textBox6.Text);
            bool result7 = backend.setPrice(0x1963, textBox7.Text);
            bool result8 = backend.setPrice(0x1965, textBox8.Text);
            bool result9 = backend.setPrice(0x1967, textBox9.Text);
            bool result10 = backend.setPrice(0x1969, textBox10.Text);
            bool result11 = backend.setPrice(0x196B, textBox11.Text);
            bool result12 = backend.setPrice(0x196D, textBox12.Text);
            bool result13 = backend.setPrice(0x196F, textBox13.Text);
            bool result14 = backend.setPrice(0x1971, textBox14.Text);
            bool result15 = backend.setPrice(0x1973, textBox15.Text);
            bool result16 = backend.setPrice(0x1975, textBox16.Text);
            bool result17 = backend.setPrice(0x1977, textBox17.Text);
            bool result18 = backend.setPrice(0x1979, textBox18.Text);
            bool result19 = backend.setPrice(0x197B, textBox19.Text);
            bool result20 = backend.setPrice(0x197D, textBox20.Text);
            bool result21 = backend.setPrice(0x197F, textBox21.Text);
            bool result22 = backend.setPrice(0x1981, textBox22.Text);
            bool result23 = backend.setPrice(0x1983, textBox23.Text);

            bool result24 = backend.setPriceSingleByte(0x1999, textBox24.Text);
            bool result25 = backend.setPriceSingleByte(0x199A, textBox25.Text);
            bool result26 = backend.setPriceSingleByte(0x199B, textBox26.Text);
            bool result27 = backend.setPriceSingleByte(0x199C, textBox27.Text);
            bool result28 = backend.setPriceSingleByte(0x199D, textBox28.Text);
            bool result29 = backend.setPriceSingleByte(0x199E, textBox29.Text);
            bool result30 = backend.setPriceSingleByte(0x199F, textBox30.Text);
            bool result31 = backend.setPriceSingleByte(0x19A0, textBox31.Text);

            if(result1 && result2 && result3 && result4 && result5 && result6 && result7 && result8 && result9 
                && result10 && result11 && result12 && result13 && result14 && result15 && result16 && result17 && result18 && result19 
                && result20 && result21 && result22 && result23 && result24 && result25 && result26 && result27 && result28 && result29
                && result30 && result31)
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

        #region textbox validation

        private void validateTextBox255(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                // 
            }
            else
            {
                MessageBox.Show("This must be a numeric value, inclusive, between 0 and 255.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void validateTextBox255(object sender, KeyEventArgs e, TextBox textBox)
        {
            int value;

            if (int.TryParse(textBox.Text, out value))
            {
                if (value > 255)
                {
                    textBox.Text = "255";
                }
            }
            else
            {
                // Should not happen.
            }
        }

        private void validateTextBox65535(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                // 
            }
            else
            {
                MessageBox.Show("This must be a numeric value, inclusive, between 0 and 65535.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void validateTextBox65535(object sender, KeyEventArgs e, TextBox textBox)
        {
            int value;

            if (int.TryParse(textBox.Text, out value))
            {
                if (value > 65535)
                {
                    textBox.Text = "65535";
                }
            }
            else
            {
                // Should not happen.
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox1);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox2);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox3);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox4);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox5);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox6);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox7);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox8_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox8);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox9);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox10_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox10);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox11_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox11);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox12_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox12);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox13_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox13);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox14_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox14);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox15_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox15);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox16_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox16);
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox17_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox17);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox18_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox18);
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox19_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox19);
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox20_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox20);
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox21_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox21);
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox22_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox22);
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox65535(sender, e);
        }

        private void textBox23_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox65535(sender, e, textBox23);
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox255(sender, e);
        }

        private void textBox24_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox255(sender, e, textBox23);
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox255(sender, e);
        }

        private void textBox25_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox255(sender, e, textBox25);
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox255(sender, e);
        }

        private void textBox26_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox255(sender, e, textBox26);
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox255(sender, e);
        }

        private void textBox27_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox255(sender, e, textBox27);
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox255(sender, e);
        }

        private void textBox28_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox255(sender, e, textBox28);
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox255(sender, e);
        }

        private void textBox29_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox255(sender, e, textBox29);
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox255(sender, e);
        }

        private void textBox30_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox255(sender, e, textBox30);
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox255(sender, e);
        }

        private void textBox31_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox255(sender, e, textBox31);
        }
        #endregion
    }
}
