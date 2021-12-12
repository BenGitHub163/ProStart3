using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model
{
    /// <summary>
    /// 这是给通过用户id放回'我的文章'的定制的类型模型
    /// </summary>
    public class PersonalWritingReturnType
    {
        [Required]
        public string title { get; set; }
        public DateTime Create_time { get; set; }
        [Required]
        public int Status { get; set; }
        public int LikeAmount { get; set; }
        public int CollectAmount { get; set; }
        public int VisitAmount { get; set; }
        public string Url { get; set; }
    }
}
