using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Application app;
                Document doc;
                object path = @"C:\Users\Administrator\source\repos\LastOrder\语文作文.docx";
                object missing = Type.Missing;
                app = new ApplicationClass();
                doc = app.Documents.Open(ref path, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);
                StringBuilder context = new StringBuilder();
                foreach (Paragraph p in doc.Paragraphs)
                {
                    context.Append(p.Range.Text + "\n");
                }
                app.Quit();
                Console.WriteLine(context);
                Console.ReadLine();
            }
            catch(SystemException se) 
            {
                Console.WriteLine(se.ToString() + "\n" + se.Message);
                Console.ReadLine();
            }
        }
    }
}
