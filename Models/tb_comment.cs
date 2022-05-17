using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 评论表实体类
    /// </summary>
    public class tb_comment
    {
        /// <summary>
        /// 评论id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int Comment_id { get; set; }
        /// <summary>
        /// 评论人的id
        /// </summary>
        [Display(Name = "用户人的id")]
        public int User_id { get; set; }
        /// <summary>
        /// 评论人的url
        /// </summary>
        [Display(Name = "评论内容的URL")]
        [Required(ErrorMessage = "这是必填项")]
        public string Comment_content { get; set; }
        /// <summary>
        /// 文章的writingid
        /// </summary>
        public int Writing_id { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime Comment_createtime { get; set; }
    }
}
