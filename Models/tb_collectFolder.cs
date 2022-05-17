using SqlSugar;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 收藏文件夹实体类
    /// </summary>
    public class tb_collectFolder
    {
        /// <summary>
        /// 文件夹id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int CollectFolder_id { get; set; }
        /// <summary>
        /// 文件夹名
        /// </summary>
        [Required]
        public string CollectFolder_name { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        [Required]
        public int User_id { get; set; }
        /// <summary>
        /// 文件夹建立时间
        /// </summary>
        public DateTime Create_time { get; set; }
    }
}
