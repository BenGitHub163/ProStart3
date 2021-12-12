using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model
{
    public class tb_collectFolder
    {
        public int CollectFolder_id { get; set; }
        [Required]
        public string CollectFloder_name { get; set; }
        [Required]
        public int User_id { get; set; }
        public DateTime Create_time { get; set; }
    }
}
