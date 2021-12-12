using SqlSugar;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProStart3.Model
{
    public class tb_material
    {
        public int Material_id { get; set; }
        public int User_id { get; set; }
        [Required]
        public string Material_title { get; set; }
        [Required]
        public string Material_content { get; set; }
        public DateTime MaterialCreate_time { get; set; }
        public int MaterialClass_id { get; set; }

        
    }
}
