using System;
using System.Collections.Generic;
using System.Text;

namespace ProStart3.Model
{
    public class Title_User_Url
    {
        /// <summary>
        /// 文章主键
        /// </summary>
        public int writingid { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 作者网名
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 文章的url
        /// </summary>
        public string url { get; set; }
    }
}
