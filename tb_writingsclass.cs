using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model
{
    public class tb_writingsclass
    {
        public int WritingClass_id{ get; set; }
        [Required]
        public string WritingClass_name { get; set; }
        public DateTime WritingClass_createTime { get; set; }

        
    }
}
