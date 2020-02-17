using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LastOrder_for_Windows
{
    public partial class FindForm : Form
    {
        public uint Taget;
        public FindForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.'))
                e.Handled = true;
            if (e.KeyChar == '\b')
                e.Handled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            Taget = (uint)Int32.Parse(textBox1.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
