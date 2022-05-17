using SqlSugar;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 资料实体类
    /// </summary>
    public class tb_material
    {
        /// <summary>
        /// 资料id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int Material_id { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int User_id { get; set; }
        /// <summary>
        /// 资料标题
        /// </summary>
        [Required]
        public string Material_title { get; set; }
        /// <summary>
        /// 资料内容
        /// </summary>
        [Required]
        public string Material_content { get; set; }
        /// <summary>
        /// 资料创建时间
        /// </summary>
        public DateTime MaterialCreate_time { get; set; }
        /// <summary>
        /// 资料类型id
        /// </summary>
        public int MaterialClass_id { get; set; }

        
    }
}
