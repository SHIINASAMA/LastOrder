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
        private LineList ll = new LineList();       //Sentence链表
        private uint     NowIndex;                  //当前索引的位置
        private MarkList ml = new MarkList();       //书签列表类

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
            listView1.Items.Clear();
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
                else return;

                string ext = Path.GetExtension(path).ToUpper();
                switch (ext)
                {
                    case ".DOC":
                    case ".DOCX":
                        Document doc = new Document(path);
                        Scanner.Scan(doc, ll);
                        ShowLineList(ll);
                        break;
                    case ".LO":
                        break;
                }
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
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
            listView1.Items[(int)Taget - 1].EnsureVisible();
            ShowStatus();
        }

        private void SelItemUp() 
        {
            if (listView1.SelectedItems.Count == 0) return;
            if (listView1.Items.Count == 0) return;
            if (listView1.Items.IndexOf(listView1.SelectedItems[0]) <= 0) return;

            listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0]) - 1].Selected = true;
            listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0]) - 1].EnsureVisible();
            if (listView1.Items.IndexOf(listView1.SelectedItems[0]) <= 0) return;
            ShowStatus();
        }
        private void SelItemDown() 
        {
            if (listView1.SelectedItems.Count == 0) return;
            if (listView1.Items.Count == 0) return;
            if (listView1.Items.IndexOf(listView1.SelectedItems[0]) == listView1.Items.Count - 1) return;

            listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0]) + 1].Selected = true;
            listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0]) + 1].EnsureVisible();
            if (listView1.Items.IndexOf(listView1.SelectedItems[0]) <= 0) return;
            ShowStatus();
        }

        private void ShowStatus() 
        {
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            Tab1.Text = "Index:" + listView1.SelectedItems[0].Text + "|" + "Type:" + listView1.SelectedItems[0].SubItems[1].Text;
            NowIndex = (uint)listView1.Items.IndexOf(listView1.SelectedItems[0]);
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
            if (e.KeyData == Keys.Left) SelItemUp();
            if (e.KeyData == Keys.Right) SelItemDown();
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

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ShowStatus();
        }

        private void 书签BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkForm mf = new MarkForm(ml);
            mf.ShowDialog();
            if (mf.NowPos != 0)
            {
                if (mf.NowPos <= listView1.Items.Count - 1)
                {
                    NowIndex = mf.NowPos;
                    listView1.Items[(int)NowIndex - 1].Selected = true;
                    listView1.Items[(int)NowIndex - 1].EnsureVisible();
                }
                else
                {
                    MessageBox.Show("该书签的Index值超过该文档最大值");
                }
            }
            ml = mf.ml;
            GC.Collect();
        }
    }
}
