//负责从Word文档中读取并保存为LineList
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
            ll.Clear();
            uint Index = 0;
            foreach (Section section in doc.Sections)
            {
                foreach (Paragraph paragraph in section.Paragraphs)
                {
                    string sb = paragraph.Text;
                    Sentence.InfoType tp = Sentence.InfoType.Head;
                    if (sb != null)
                    {

                        uint NowPos = 0;
                        uint LastPos = 0;
                        foreach (char c in sb.ToString())
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
                                    Index++;
                                    ll.Add(Index, tp, sb.ToString().Substring((int)LastPos, (int)NowPos - (int)LastPos));
                                    tp = Sentence.InfoType.Null;
                                    LastPos = NowPos;
                                    break;
                                default:
                                    NowPos++;
                                    break;
                            }
                        }
                    }
                    char[] tag = {'.','。','!','！','?','？' };
                    if(sb.IndexOfAny(tag) == -1 && sb.Trim() != "") 
                    {
                        Index++;
                        ll.Add(Index, Sentence.InfoType.Head, sb.ToString());
                    }
                } 
            }
        }
    }
}