//包装了Sentence列表类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LastOrder_for_Windows
{
    class LineList
    {
        public List<Sentence> TheList = new List<Sentence>();
        public void Add(Sentence sc) 
        {
            TheList.Add(sc);
        }

        public void Add(uint Index,Sentence.InfoType Info,string Text) 
        {
            TheList.Add(new Sentence(Index,Info, Text));
        }

        public void Clear() 
        {
            TheList.Clear();
        }
    }
}
