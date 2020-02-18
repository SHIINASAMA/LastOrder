using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastOrder_for_Windows
{
    public class Bookmark
    {
        public uint     Index;
        public string   Preview;

        public Bookmark(uint Index,string Preview) 
        {
            this.Index = Index;
            this.Preview = Preview;
        }
    }
}
