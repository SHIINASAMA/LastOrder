using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spire.Doc;
using Spire.Doc.Documents;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.LoadFromFile(@"C:\Users\Administrator\source\repos\LastOrder\语文作文.docx");

            StringBuilder stringBuilder = new StringBuilder();
            foreach(Section section in doc.Sections) 
            {
                foreach(Paragraph paragraph in section.Paragraphs) 
                {
                    stringBuilder.Append(paragraph.Text + "\n");
                }
            }
            Console.WriteLine(stringBuilder);
            Console.ReadLine();
        }
    }
}
