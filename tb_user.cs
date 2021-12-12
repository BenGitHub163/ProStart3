using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProStart3.Model
{
    public class tb_user 
    {
        public int User_id { get; set; }
        [Display(Name ="账号")]
        [Required(ErrorMessage ="账号是必须的")]
        public int User_userName { get; set; }
        public string User_email { get; set; }
        [Display(Name = "密码")]
        [Required(ErrorMessage = "密码是必须的")]
        public string Password { get; set; }
        public string User_nickname { get; set; }
        public string User_profilePicture { get; set; }
        public string User_sex { get; set; }
        public int User_classId { get; set; }
    }
}
