using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 资料类型实体类
    /// </summary>
    public class tb_materialclass
    {
        /// <summary>
        /// 资料类型id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int MaterialClass_id { get; set; }
        /// <summary>
        /// 资料类型名
        /// </summary>
        [Required]
        public string MaterialClass_name { get; set; }
        /// <summary>
        /// 资料类型创建时间
        /// </summary>
        public DateTime MaterialClass_createTime { get; set; }

         
    }
}
