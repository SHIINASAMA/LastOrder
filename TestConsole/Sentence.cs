using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    class Sentence
    {
        public string   Commit;         //附加文本
        public string   Text;           //主要文本
        public char     EndWith;        //结尾字符

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mCommit">初始化的附加文本</param>
        /// <param name="mText">初始化的主要文本</param>
        /// <param name="mEndWith">初始化的结尾字符</param>
        public Sentence(string mCommit,string mText,char mEndWith) 
        {
            Commit = mCommit;
            Text = mText;
            EndWith = mEndWith;
        }
    }
}
