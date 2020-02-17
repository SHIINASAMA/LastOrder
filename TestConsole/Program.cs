using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Collections;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.LoadFromFile(@"C:\Users\Administrator\source\repos\LastOrder\语文作文.docx");

            StringBuilder text = new StringBuilder();
            foreach (Section section in doc.Sections)
            {
                foreach(Paragraph p in section.Paragraphs) 
                {
                    text.Append(p.Text);
                }
                text.Append('\n');
            }

            Cut(text.ToString());

            //foreach(DictionaryEntry de in ht) 
            //{
            //    Sentence temp = (Sentence)de.Value;
            //    Console.WriteLine(de.Key + "\t" + temp.Info + "\t" + temp.Text);
            //}

            //Console.ReadLine();
        }

        static Hashtable ht = new Hashtable();
        static void Cut(string AllText) 
        {
            if (AllText == null) return;

            int LastPos = 0;
            int NowPos = 0;
            int Index = 0;
            string mInfo;
            foreach(char c in AllText) 
            {
                switch (c) 
                {
                    case '.':
                    case '。':
                    case '!':
                    case '！':
                    case '?':
                    case '？':
                        NowPos++;
                        ht.Add(Index, new Sentence("Null", AllText.Substring(LastPos, NowPos - LastPos)));
                        LastPos = NowPos;
                        Index++;
                        break;
                    default:
                        NowPos++;
                        break;
                }
            }
        }
    }
}
