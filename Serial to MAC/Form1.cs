using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Serial_to_MAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            bool isNumeric = true;
            string num = serialNum.Text;
            if (Regex.IsMatch(serialNum.Text, "[a-zA-Z!@#$%^&*()_+={}\\[\\]:;\"'<>,.?/~`\\\\|-]"))
            {
                MessageBox.Show("Serial Number Must be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNumeric = false;
                return;
            } else
            {
                isNumeric = true;
            }


            if (num.Length == 9 && isNumeric == true)
            {



                int hexVal = Convert.ToInt32(num);

                string newHexVal = hexVal.ToString("X");

                string subString = newHexVal.Substring(2);
                if (subString.Length < 6)
                {
                    MessageBox.Show("Invalid Serial Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    string formatted = $"00:17:FC:{subString.Substring(0, 2)}:{subString.Substring(2, 2)}:{subString.Substring(4, 2)}";


                listView1.Items.Add(new ListViewItem(new string[] { num, formatted }));
                serialNum.Clear();
            }
            else
            {

                MessageBox.Show("Serial Number Must be 9 Digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                

                
            
            

        }

        private void copyMac_Click(object sender, EventArgs e)
        {
            string clipText = string.Empty;
            foreach (ListViewItem item in listView1.Items)
            {
                clipText += item.SubItems[1].Text;
                clipText += Environment.NewLine;
            }
            if (!String.IsNullOrEmpty(clipText))
            {
                Clipboard.SetText(clipText);
            }
        }

        private void copySerial_Click(object sender, EventArgs e)
        {
            string clipText = string.Empty;
            foreach (ListViewItem item in listView1.Items)
            {
                clipText += item.SubItems[0].Text;
                clipText += Environment.NewLine;
            }
            if (!String.IsNullOrEmpty(clipText))
            {
                Clipboard.SetText(clipText);
            }
        }

        private void serialNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
