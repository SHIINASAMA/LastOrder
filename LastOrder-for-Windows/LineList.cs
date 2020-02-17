using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LastOrder_for_Windows
{
    class LineList
    {
        public Hashtable TheList = new Hashtable();
        public void Add(uint Index,Sentence sc) 
        {
            TheList.Add(Index, sc);
        }

        public void Add(uint Index,Sentence.InfoType Info,string Text) 
        {
            TheList.Add(Index, new Sentence(Info, Text));
        }

        public void Remove(uint Index) 
        {
            TheList.Remove(Index);
        }

        public void Clear() 
        {
            TheList.Clear();
        }
    }
}
