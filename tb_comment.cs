using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace ProStart3.Model
{
    public class tb_comment
    {
        public int Comment_id { get; set; }
        /// <summary>
        /// 评论人的id
        /// </summary>
        [Display(Name = "用户人的id")]
        public int User_id { get; set; }
        /// <summary>
        /// 评论人的url
        /// </summary>
        [Display(Name = "评论的URL")]
        [Required(ErrorMessage = "这是必填项")]
        public string Comment_content { get; set; }
        public DateTime Comment_createtime { get; set; }

         
    }
}
