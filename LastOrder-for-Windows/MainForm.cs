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
            IndexHeader.Width = 50;
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
                else return;

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
            }
            catch (SystemException se)
            {

            }
        }

        private void 查找FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
