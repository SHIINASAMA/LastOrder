using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastOrder_for_Windows
{
    class FileBlock
    {
        public byte[]   Length;
        public byte[]   Block;

        public FileBlock(uint length,byte[] block) 
        {
            Length = BitConverter.GetBytes(length);
            Block = block;
        }
    }
}
