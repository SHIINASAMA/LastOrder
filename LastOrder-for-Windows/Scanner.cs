using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spire.Doc.Documents;
using Spire.Doc;

namespace LastOrder_for_Windows
{
    class Scanner
    {
        public static void Scan(Document doc, LineList ll)
        {
            foreach (Section section in doc.Sections)
            {
                foreach (Paragraph paragraph in section.Paragraphs)
                {
                    String sb = paragraph.Text;
                    if (sb != null) 
                    {
                        Sentence.InfoType tp;
                        uint Index = 0;
                        uint NowPos = 0;
                        uint LastPos = 0;
                        foreach(char c in sb) 
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
                                    if (Index == 0) tp = Sentence.InfoType.Head;
                                    else tp = Sentence.InfoType.Null;
                                    ll.Add(Index, new Sentence(tp, sb.Substring((int)LastPos, (int)NowPos - (int)LastPos)));
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
        }
    }
}
