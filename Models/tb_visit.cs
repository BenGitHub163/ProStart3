using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 访问实体类
    /// </summary>
    public class tb_visit
    {
        /// <summary>
        /// 访问id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int Visit_id { get; set; }
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
        /// 访问时间
        /// </summary>
        [Required]
        public DateTime Visit_time { get; set; }
    }
}
