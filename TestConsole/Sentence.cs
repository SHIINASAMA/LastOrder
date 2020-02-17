using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    class Sentence
    {
        public string   Info;         //附加文本
        public string   Text;           //主要文本

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mInfo">初始化的附加文本</param>
        /// <param name="mText">初始化的主要文本</param>
        public Sentence(string mInfo,string mText) 
        {
            Info = mInfo;
            Text = mText;
        }
    }
}
