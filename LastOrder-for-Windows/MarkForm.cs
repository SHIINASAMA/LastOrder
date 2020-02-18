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
    public partial class MarkForm : Form
    {
        public uint NowPos = 0;
        public MarkList ml;
        public MarkForm(MarkList ml)
        {
            InitializeComponent();
            this.ml = ml;

            //初始化表头
            ColumnHeader IndexHeader = new ColumnHeader();
            ColumnHeader PreviewHeader = new ColumnHeader();

            IndexHeader.Text = "Index";
            IndexHeader.Width = 60;
            PreviewHeader.Text = "Preview";
            PreviewHeader.Width = 100;

            listView1.Columns.Add(IndexHeader);
            listView1.Columns.Add(PreviewHeader);

            ShowMarkList(ml);
        }

        private void ShowMarkList(MarkList ml) 
        {
            listView1.Items.Clear();
            listView1.BeginUpdate();
            foreach(Bookmark bk in ml.Bookmarks) 
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = bk.Index.ToString();
                lvi.SubItems.Add(bk.Preview);
                listView1.Items.Add(lvi);
            }
            listView1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMarkForm amf = new AddMarkForm();
            if(amf.ShowDialog() == DialogResult.OK) 
            {
                ml.Add(amf.Taget, amf.Preview);
                ShowMarkList(ml);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0) return;
            if (listView1.SelectedItems.Count == 0) return;
            listView1.Items.RemoveAt(listView1.Items.IndexOf(listView1.SelectedItems[0]));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0) return;
            if (listView1.SelectedItems.Count == 0) return;
            NowPos = (uint)Int32.Parse(listView1.SelectedItems[0].Text);
        }
    }
}
