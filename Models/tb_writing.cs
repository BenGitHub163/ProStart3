using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 文章实体类
    /// </summary>
    public class tb_writing
    {
        /// <summary>
        /// 文章id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int Writing_id { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        [Required]
        public int User_id { get; set; }
        /// <summary>
        /// 文章状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 文章类型id
        /// </summary>
        public int WritingClass_id { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
        [Required]
        public string Writing_title { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        [Required]
        public string Writing_content { get; set; }
        /// <summary>
        /// 文章创建时间
        /// </summary>
        public DateTime Writing_createTime { get; set; }
        /// <summary>
        /// 文章图片路径
        /// </summary>
        public string Writing_image { get; set; }
        /// <summary>
        /// 文章点赞量
        /// </summary>
        [SugarColumn (ColumnName = "Writing_likeAmount")]
        public int writingVisit_likeAmount { get; set; }
        /// <summary>
        /// 文章收藏量
        /// </summary>
        [SugarColumn (ColumnName = "Writing_collectAmount")]
        public int writingVisit_collectAmount { get; set; }
        /// <summary>
        /// 文章访问量
        /// </summary>
        [SugarColumn (ColumnName = "Writing_readAmount")]
        public int writingVisit_readAmount { get; set; }

    }
}
