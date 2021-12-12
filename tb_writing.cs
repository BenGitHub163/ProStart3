using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model
{
    public class tb_writing
    {
        public int Writing_id { get; set;  }
        
        [Required]
        public int User_id { get; set; }
        public int Status { get; set; }
        public int WritingClass_id { get; set; }
        [Required]
        public string Writing_title { get; set; }

        [Required]
        public string Writing_content { get; set; }
        public DateTime Writing_createTime { get; set; }
        public string Writing_image { get; set; }
        public int writingVisit_likeAmount { get; set; }
        public int writingVisit_collectAmount { get; set; }
        public int writingVisit_readAmount { get; set; }

    }
}
