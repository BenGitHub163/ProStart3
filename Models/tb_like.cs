using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 点赞实体类
    /// </summary>
    public class tb_like
    {
        /// <summary>
        /// 点赞id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int Like_id { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        [Required]
        public int User_id { get; set; }
        /// <summary>
        /// 文章id
        /// </summary>
        [Required]
        public int Writing_id { get; set; }
        /// <summary>
        /// 点赞时间
        /// </summary>
        [Required]
        public DateTime Like_time { get; set; }
    }
}
