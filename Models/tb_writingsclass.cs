using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 文章类型实体类
    /// </summary>
    public class tb_writingsclass
    {
        /// <summary>
        /// 文章类型id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int WritingClass_id{ get; set; }
        /// <summary>
        /// 文章类型名
        /// </summary>
        [Required]
        public string WritingClass_name { get; set; }
        /// <summary>
        /// 文章类型名创建时间
        /// </summary>
        public DateTime WritingClass_createTime { get; set; }

        
    }
}
