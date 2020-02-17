using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Spire.Doc;
using Spire.Doc.Documents;
using System.IO;

namespace LastOrder_for_Windows
{
    public partial class MainForm : Form
    {
        private uint     NowIndex;          //当前索引的位置

        public MainForm()
        {
            InitializeComponent();

            //初始化表头
            ColumnHeader IndexHeader = new ColumnHeader();
            ColumnHeader TypeHeader = new ColumnHeader();
            ColumnHeader TextHeader = new ColumnHeader();

            IndexHeader.Text = "Index";
            IndexHeader.Width = 60;
            TypeHeader.Text = "Type";
            TypeHeader.Width = 50;
            TextHeader.Text = "Text";
            TextHeader.Width = 800;

            listView1.Columns.Add(IndexHeader);
            listView1.Columns.Add(TypeHeader);
            listView1.Columns.Add(TextHeader);

        }

        private void ShowLineList(LineList ll) 
        {
            listView1.BeginUpdate();    
            foreach(Sentence sc in ll.TheList) 
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sc.Index.ToString();
                lvi.SubItems.Add(Sentence.Info2String(sc.Info));
                lvi.SubItems.Add(sc.Text);
                listView1.Items.Add(lvi);
            }         
            listView1.EndUpdate();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path;
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "LO段落文档|*.LO|Word文档|*.doc|Word文档|*.docx";
                if (dlg.ShowDialog() == DialogResult.OK) path = dlg.FileName;
                else {
                    GC.Collect();
                    return;
                }

                string ext = Path.GetExtension(path).ToUpper();
                switch (ext)
                {
                    case ".DOC":
                    case ".DOCX":
                        Document doc = new Document(path);
                        LineList ll = new LineList();
                        Scanner.Scan(doc, ll);
                        ShowLineList(ll);
                        break;
                    case ".LO":
                        break;
                }

                GC.Collect();
            }
            catch (SystemException se)
            {

            }
        }

        private void 查找FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uint Taget = 0;
            FindForm ff = new FindForm();
            if (ff.ShowDialog() == DialogResult.OK)
            {
                Taget = ff.Taget;
            }
            else return;

            if(listView1.Items.Count == 0)
            {
                MessageBox.Show("请先打开文件再操作");
                return;
            }

            listView1.Items[(int)Taget - 1].Selected = true;
        }

        private void SelItemUp() 
        {
            if (listView1.SelectedItems.Count == 0) return;
            if (listView1.Items.Count == 0) return;
            if (listView1.Items.IndexOf(listView1.SelectedItems[0]) <= 0) return;

            listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0]) - 1].Selected = true;
            if (listView1.Items.IndexOf(listView1.SelectedItems[0]) <= 0) return;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            Tab1.Text = "Index:" + listView1.SelectedItems[0].Text + "|" + "Type:" + listView1.SelectedItems[0].SubItems[1].Text;
        }
        private void SelItemDown() 
        {
            if (listView1.SelectedItems.Count == 0) return;
            if (listView1.Items.Count == 0) return;
            if (listView1.Items.IndexOf(listView1.SelectedItems[0]) == listView1.Items.Count - 1) return;

            listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0]) + 1].Selected = true;
            if (listView1.Items.IndexOf(listView1.SelectedItems[0]) <= 0) return;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            Tab1.Text = "Index:" + listView1.SelectedItems[0].Text + "|" + "Type:" + listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void PreBtn_Click(object sender, EventArgs e)
        {
            SelItemUp();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            SelItemDown();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) SelItemUp();
            if (e.KeyData == Keys.Down) SelItemDown();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Tab1.Text = "就绪";
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
