using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 收藏表实体类
    /// </summary>
    public class tb_collect
    {
        /// <summary>
        /// 收藏表的主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int Collect_id { get; set; }
        /// <summary>
        /// 收藏动作的发起者
        /// </summary>
        [Required]
        public int User_id { get; set; }
        /// <summary>
        /// 被收藏文章的主键
        /// </summary>
        [Required]
        public int Writing_id { get; set; }
        /// <summary>
        /// 收藏夹的主键id
        /// </summary>
        [Required]
        public int CollectFolder_id { get; set; }
        /// <summary>
        /// 动作的发生时间
        /// </summary>
        public DateTime Collect_time { get; set; }
    }
}
