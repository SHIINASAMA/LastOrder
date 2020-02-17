using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using Spire.Doc;
using Spire.Doc.Documents;

namespace LastOrder_for_Windows
{
    public partial class MainForm : Form
    {
        private LineList ll;

        public MainForm()
        {
            InitializeComponent();

            ll = new LineList(); 

            //初始化表头
            ColumnHeader IndexHeader = new ColumnHeader();
            ColumnHeader TypeHeader = new ColumnHeader();
            ColumnHeader TextHeader = new ColumnHeader();

            IndexHeader.Text = "Index";
            IndexHeader.Width = 50;
            TypeHeader.Text = "Type";
            TypeHeader.Width = 50;
            TextHeader.Text = "Text";
            TextHeader.Width = 500;

            listView1.Columns.Add(IndexHeader);
            listView1.Columns.Add(TypeHeader);
            listView1.Columns.Add(TextHeader);

        }

        private void ShowLineList() 
        {
            listView1.BeginUpdate();    
            foreach(DictionaryEntry de in ll.TheList) 
            {
                Sentence sc = (Sentence)de.Value;
                ListViewItem lvi = new ListViewItem();
                lvi.Text = de.Key.ToString();
                lvi.SubItems.Add(Sentence.Info2String(sc.Info));
                lvi.SubItems.Add(sc.Text);
                listView1.Items.Add(lvi);
            }         
            listView1.EndUpdate();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ll.Clear();
            string path;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "LO段落文档|*.LO|Word文档|*.doc|Word文档|*.docx";
            if (dlg.ShowDialog() == DialogResult.OK) path = dlg.FileName;
            else return;

            Document doc = new Document(path);
            Scanner.Scan(doc, ll);

            ShowLineList();
        }
    }
}
