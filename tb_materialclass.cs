using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model
{
    public class tb_materialclass
    {

        public int MaterialClass_id { get; set; }
        [Required]
        public string MaterialClass_name { get; set; }
        public DateTime MaterialClass_createTime { get; set; }

         
    }
}
