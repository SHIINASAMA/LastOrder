//单独的句子类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastOrder_for_Windows
{
    class Sentence
    {
        public enum InfoType 
        {
            Head,Null
        }

        public uint     Index; 
        public InfoType Info;
        public string   Text;

        public Sentence(uint Index,InfoType Info,string Text) 
        {
            this.Index = Index;
            this.Info  = Info;
            this.Text  = Text;
        }

        public static string Info2String(InfoType type) 
        {
            switch (type) 
            {
                case InfoType.Head:
                    return "段首";
                case InfoType.Null:
                    return "内容";
                default:
                    return null;
            }
        }
    }
}
