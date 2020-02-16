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

            List<Sentence> Sentences = new List<Sentence>();
            foreach (Section section in doc.Sections)
            {
                for(int i = 0; i < section.Paragraphs.Count; i++) 
                {
                    
                }
            }
            foreach(Sentence s in Sentences)
            {
                Console.WriteLine(s.Commit + "\t" + s.Text + s.EndWith);
            }
            Console.ReadLine();
        }
    }
}
