using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model
{
    public class tb_visit
    {
        public int Visit_id { get; set; }
        [Required]
        public int User_id { get; set; }
        [Required]
        public int Writing_id { get; set; }
        [Required]
        public DateTime Visit_time { get; set; }
    }
}
