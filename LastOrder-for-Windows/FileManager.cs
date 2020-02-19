//LO文件管理类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace LastOrder_for_Windows
{
    class FileManager
    {
        public void LoadFromFile(string path, LineList ll)
        {
            ll.Clear();
            using(FileStream fs = new FileStream(path, FileMode.Open)) 
            {
                byte[] Header = new byte[4];
                fs.Read(Header, 0, 4);
                if(System.Text.Encoding.Unicode.GetString(Header) != "LO") 
                {
                    MessageBox.Show("文件损坏");
                    return;
                }

                uint Index = 0;
                while (true) 
                {
                    if (fs.Position >= fs.Length) break;

                    Index++;

                    byte[] temp1 = new byte[4];
                    fs.Read(temp1, 0, 4);
                    uint len = BitConverter.ToUInt32(temp1, 0);

                    byte[] temp2 = new byte[4];
                    fs.Read(temp2, 0, 4);
                    string info = System.Text.Encoding.Unicode.GetString(temp2);

                    byte[] temp3 = new byte[len - 4];
                    fs.Read(temp3, 0, (int)len - 4);
                    string text = System.Text.Encoding.Unicode.GetString(temp3);

                    ll.Add(Index, Sentence.String2Info(info), text);
                }
                fs.Close();
                fs.Dispose();

            }
        }

        public void SaveAs(string path, LineList ll)
        {
            List<FileBlock> FileBlocks = new List<FileBlock>();
            foreach (Sentence sc in ll.TheList) 
            {
                byte[] temp = System.Text.Encoding.Unicode.GetBytes(Sentence.Info2String(sc.Info) + sc.Text);
                FileBlocks.Add(new FileBlock((uint)temp.Length, temp));
            }

            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate)) 
            {
                byte[] Header = System.Text.Encoding.Unicode.GetBytes("LO");
                fs.Write(Header, 0, Header.Length);
                foreach(FileBlock fb in FileBlocks) 
                {
                    fs.Write(fb.Length, 0, 4);
                    fs.Write(fb.Block, 0, fb.Block.Length);
                }
                fs.Close();
                fs.Dispose();
            }
        }
    }
}