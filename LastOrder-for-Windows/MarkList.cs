using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastOrder_for_Windows
{
    public class MarkList
    {
        public List<Bookmark> Bookmarks = new List<Bookmark>();

        public void Add(Bookmark bm) 
        {
            Bookmarks.Add(bm);
        }

        public void Add(uint Index, string Preview)
        {
            Bookmarks.Add(new Bookmark(Index, Preview));
        }

        public void Clear() 
        {
            Bookmarks.Clear();
        }
    }
}
